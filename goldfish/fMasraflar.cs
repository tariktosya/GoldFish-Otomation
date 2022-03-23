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
    public partial class fMasraflar : Form
    {
        public fMasraflar()
        {
            InitializeComponent();
        }
        DatabaseEntities db = new DatabaseEntities();
        masraflar masraf = new masraflar();
        private void KAYDET_Click(object sender, EventArgs e)
        {
            if (tbaslik.Text != "" && ttutar.Text != "" && taciklama.Text != "" && dateTimePicker1.Value != null)
            {
                masraf.baslik = tbaslik.Text;
                masraf.tutar = Convert.ToDouble(ttutar.Text);
                masraf.aciklama = taciklama.Text;
                masraf.tarih = dateTimePicker1.Value;
                db.masraflar.Add(masraf);
                db.SaveChanges();
                MessageBox.Show("Masraf Kaydedildi");

                tbaslik.Text = "";
                ttutar.Text = "";
                taciklama.Text = "Yok.";
                dateTimePicker1.Value = DateTime.Now;


                dataGridView1.DataSource = db.masraflar.OrderByDescending(a => a.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
            }
        }

        private void ttutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void fMasraflar_Load(object sender, EventArgs e)
        {
            taciklama.Text = "Yok.";
            dataGridView1.DataSource = db.masraflar.OrderByDescending(a => a.Id).ToList();
            dataGridView1.ReadOnly = true;
            gridDuzenle(dataGridView1);
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
                        case "baslik":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Başlık"; break;
                        case "tutar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tutar"; break;
                        case "aciklama":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "tarih":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dgv.Columns[i].HeaderText = "Tarih"; break;
                    }
                }
            }
        }
    }
}

