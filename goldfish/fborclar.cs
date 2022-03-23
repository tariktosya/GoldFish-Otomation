using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goldfish
{
    public partial class fborclar : Form
    {
        public fborclar()
        {
            InitializeComponent();
        }
        DatabaseEntities db = new DatabaseEntities();
        borclar borc = new borclar();
        borcIslemleri borcislem = new borcIslemleri();

        private void ttutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void fborclar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Yok.";
            dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
            gridDuzenle(dataGridView1);
        }
        public void gridDuzenle(DataGridView dgv)
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
                        case "isim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "İsim"; break;
                        case "tur":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tür"; break;
                        case "alimTarih":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Alım Tarihi"; break;
                        case "odemeTarih":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Ödeme Tarihi"; break;
                        case "tutar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tutar"; break;
                        case "aciklama":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioVerecek.Checked = false;
            radioAlacak.Checked = false;
            tisim.ReadOnly = true;
            if (tisim2.Text != "")
            {
                if (db.borclar.Any(a => a.isim == tisim2.Text))
                {
                    var kisi = db.borclar.Where(a => a.isim == tisim2.Text).SingleOrDefault();
                    if (kisi.tur == "alacak")
                    {
                        radioAlacak.Checked = true;
                    }
                    else if (kisi.tur == "verecek")
                    {
                        radioVerecek.Checked = true;
                    }
                    tisim.Text = kisi.isim;
                    ttutar.Text = kisi.tutar.ToString();
                    dateTimePicker1.Value = kisi.alimTarih.Value;
                    dateTimePicker2.Value = kisi.odemeTarih.Value;
                    textBox1.Text = kisi.tur;
                }
                else
                {
                    MessageBox.Show("Borç Bulunamadı!");
                }
            }

        }

        private void todenecek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }



        private void bekle_Click(object sender, EventArgs e)
        {
            if (tisim2.Text != "" && todenecek.Text != "")
            {
                if (db.borclar.Any(a => a.isim == tisim2.Text))
                {
                    var kisi = db.borclar.Where(a => a.isim == tisim2.Text).SingleOrDefault();
                    if (kisi.tutar - Convert.ToDouble(todenecek.Text) >= 0)
                    {
                        kisi.tutar = kisi.tutar - Convert.ToDouble(todenecek.Text);
                        borcislem.isim = kisi.isim;
                        borcislem.islem = "Borç Ödeme";
                        borcislem.borcTuru = kisi.tur;
                        borcislem.tutar = Convert.ToDouble(todenecek.Text);
                        borcislem.tarih = dateTimePicker3.Value;
                        db.borcIslemleri.Add(borcislem);
                        MessageBox.Show("Borç Güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show(kisi.tutar + "₺ Tutarından Fazla Ödeme Yapılamaz!");
                    }
                    dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
                    gridDuzenle(dataGridView1);
                    db.SaveChanges();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Borç Bulunamadı!");
                }
            }
        }

        private void bborcEkle_Click(object sender, EventArgs e)
        {
            if (tisim2.Text != "" && todenecek.Text != "")
            {
                if (db.borclar.Any(a => a.isim == tisim2.Text))
                {
                    var kisi = db.borclar.Where(a => a.isim == tisim2.Text).SingleOrDefault();
                    kisi.tutar = kisi.tutar + Convert.ToDouble(todenecek.Text);

                    borcislem.isim = kisi.isim;
                    borcislem.islem = "Borç Ekleme";
                    borcislem.tutar = Convert.ToDouble(todenecek.Text);
                    borcislem.tarih = dateTimePicker3.Value;
                    db.borcIslemleri.Add(borcislem);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
                    gridDuzenle(dataGridView1);
                    MessageBox.Show("Borç Güncellendi!");
                    temizle();
                }
                else
                {
                    MessageBox.Show("Borç Bulunamadı!");
                }
            }
        }


        private void bguncelle_Click(object sender, EventArgs e)
        {
            if (tisim.Text != "" && ttutar.Text != "" && (radioAlacak.Checked != false || radioVerecek.Checked != false) && dateTimePicker1.Value != null && textBox1.Text != "")
            {
                tisim.ReadOnly = false;
                if (db.borclar.Any(x => x.isim == tisim.Text))
                {
                    var kisi = db.borclar.Where(x => x.isim == tisim.Text).SingleOrDefault();
                    if (radioAlacak.Checked == true)
                    {
                        kisi.tur = "alacak";
                    }
                    if (radioVerecek.Checked == true)
                    {
                        kisi.tur = "verecek";
                    }
                    kisi.alimTarih = dateTimePicker1.Value;
                    kisi.odemeTarih = dateTimePicker2.Value;
                    kisi.tutar = Convert.ToDouble(ttutar.Text);
                    kisi.aciklama = textBox1.Text;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Tamamlandı");
                    temizle();
                }

            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
            dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
            gridDuzenle(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tisim.Text != "" && ttutar.Text != "" && (radioAlacak.Checked != false || radioVerecek.Checked != false) && dateTimePicker1.Value != null && textBox1.Text != "")
            {
                tisim.ReadOnly = false;
                if (db.borclar.Any(x => x.isim == tisim.Text))
                {
                    MessageBox.Show("Kayıtlı İsim!");
                }
                else
                {
                    borc.isim = tisim.Text;
                    if (radioAlacak.Checked == true)
                    {
                        borc.tur = "alacak";
                    }
                    if (radioVerecek.Checked == true)
                    {
                        borc.tur = "verecek";
                    }
                    borc.alimTarih = dateTimePicker1.Value;
                    borc.odemeTarih = dateTimePicker2.Value;
                    borc.tutar = Convert.ToDouble(ttutar.Text);
                    borc.aciklama = textBox1.Text;
                    db.borclar.Add(borc);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
                    gridDuzenle(dataGridView1);
                    MessageBox.Show("Ekleme Tamamlandı.");
                    temizle();
                }
                
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }
        public void temizle()
        {
            tisim.Clear();
            ttutar.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox1.Text=("Yok.");
            tisim2.Clear();
            ttutar.Clear();
            tisim.Focus();
            tisim.ReadOnly = false;
            todenecek.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tisim2.Text != "")
            {
                if (db.borclar.Any(x => x.isim == tisim2.Text))
                {
                    var sil = db.borclar.Where(x => x.isim == tisim2.Text).SingleOrDefault();
                    db.borclar.Remove(sil);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.borclar.OrderByDescending(a => a.Id).ToList();
                    gridDuzenle(dataGridView1);
                    temizle();
                    MessageBox.Show(sil.isim + "-İsimli Borç Silindi!");
                }
            }
            else
            {
                MessageBox.Show("İSİM Alanını Doldurunuz!");
            }
        }

        private void fborclar_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
