using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace goldfish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseEntities db = new DatabaseEntities();
        Table table = new Table();
        toplamBalik baliktoplam = new toplamBalik();
        zayiat zayi = new zayiat();
        private void bkaydet_Click(object sender, EventArgs e)
        {
            if(radioZayiat.Checked)
            {
                if (tcins.Text != "" && ttur.Text != "" && tadet.Text != ""&& dateTimePicker1.Value != null)
                {
                    if(db.toplamBalik.Any(x=> x.cins == tcins.Text && x.tur == ttur.Text))
                    {
                        var baligim = db.toplamBalik.Where(x => x.cins == tcins.Text && x.tur == ttur.Text).SingleOrDefault();
                        if (baligim.adet - Convert.ToDouble(tadet.Text) >= 0)
                        {
                            zayi.cins = tcins.Text; ;
                            zayi.tur = ttur.Text;
                            zayi.adet = Convert.ToDouble(tadet.Text);
                            zayi.tarih = dateTimePicker1.Value;
                            baligim.adet = baligim.adet - Convert.ToDouble(tadet.Text);
                            MessageBox.Show("Zayiat Kaydedildi!");
                            db.zayiat.Add(zayi);
                        }
                        else
                        {
                            MessageBox.Show("Toplam Balık Adedinden Fazla Ölüm Olamaz!" );
                        }
                        db.SaveChanges();
                        dataGridView1.DataSource = db.Table.OrderByDescending(a => a.Id).ToList();
                        dataGridView1.ReadOnly = true;
                        gridDuzenle(dataGridView1);
                        
                        temizle();
                    }
                }
            }
            else
            {
                if (tadet.Text != "" && ttur.Text != "" && tcins.Text != "" && talimFiyat.Text != "" && dateTimePicker1.Value != null)
                {
                    table.tur = ttur.Text;
                    table.cins = tcins.Text;
                    table.adet = Convert.ToDouble(tadet.Text);
                    table.alisFiyati = Convert.ToDouble(talimFiyat.Text);
                    table.alimTarihi = dateTimePicker1.Value;
                    db.Table.Add(table);
                    if (db.toplamBalik.Any(a => a.cins == tcins.Text && a.tur == ttur.Text))
                    {
                        var x = db.toplamBalik.Where(a => a.cins == tcins.Text && a.tur == ttur.Text).SingleOrDefault();
                        x.adet = Convert.ToDouble(tadet.Text) + x.adet;
                        db.SaveChanges();
                    }
                    else
                    {
                        baliktoplam.cins = tcins.Text;
                        baliktoplam.tur = ttur.Text;
                        baliktoplam.adet = Convert.ToDouble(tadet.Text);
                        db.toplamBalik.Add(baliktoplam);
                    }

                    db.SaveChanges();
                    temizle();
                    dataGridView1.DataSource = db.Table.OrderByDescending(a => a.Id).ToList();
                    dataGridView1.ReadOnly = true;
                    gridDuzenle(dataGridView1);

                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz!");
                }
            }
            
        }
        public void temizle()
        {
            ttur.Text = "";
            tcins.Text = "";
            tadet.Text = "";
            talimFiyat.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void tadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void talimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            try
            {
                var sil = db.Table.Find(Convert.ToInt32(tsil.Text));
                var toplam = db.toplamBalik.Where(a => a.cins == sil.cins && a.tur == sil.tur).FirstOrDefault();
                toplam.adet = toplam.adet - sil.adet;
                db.Table.Remove(sil);
                db.SaveChanges();
                dataGridView1.DataSource = db.Table.OrderByDescending(a => a.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Değer Girdiniz!");
            }
        }
        public static void gridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "tur":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tür"; break;
                        case "cins":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Cins"; break;
                        case "adet":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Adet"; break;
                        case "alimTarihi":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Alım Tarihi"; break;
                        case "alisFiyati":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Alış Fiyatı"; break;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBalikGirisi.Checked = true;
            dataGridView1.DataSource = db.Table.OrderByDescending(a => a.Id).ToList();
            dataGridView1.ReadOnly = true;
            gridDuzenle(dataGridView1);
        }

        private void tsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void radioZayiat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioZayiat.Checked)
            {
                talimFiyat.Clear();
                talimFiyat.ReadOnly = true;
                label5.Text = "ZAYİAT TARİHİ";
            }
            else
            {
                talimFiyat.ReadOnly = false;
                label5.Text = "ALIM TARİHİ";
            }
        }
    }
}
