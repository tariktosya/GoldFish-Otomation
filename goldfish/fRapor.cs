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
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }
        DatabaseEntities db = new DatabaseEntities();
        private void bListele_Click(object sender, EventArgs e)
        {
            DateTime baslangic = datebaslangic.Value.AddDays(-1);
            if (radioSatislar.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM SATIŞ";
                var list = db.satislar.Where(x => x.tarih <= datebitis.Value&& x.tarih >= baslangic);
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.toplam).ToString();
            }
            if (radioMasraflar.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM MASRAF";
                var list = db.masraflar.Where(x => x.tarih <= datebitis.Value && x.tarih >= baslangic);
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.tutar).ToString();
            }
            if (radioAlacak.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM ALACAK";
                var list = db.borclar.Where(x => x.alimTarih <= datebitis.Value && x.alimTarih >= baslangic && x.tur=="alacak");
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.tutar).ToString();
            }
            if (radioVerecek.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM VERECEK";
                var list = db.borclar.Where(x => x.alimTarih <= datebitis.Value && x.alimTarih >= baslangic && x.tur == "verecek");
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.tutar).ToString();
            }
            if (radioBalikGirisleri.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = true;
                ttoplam2.Visible = true;
                label1.Text = "TOPLAM GİRDİ";
                var list = db.Table.Where(x => x.alimTarihi <= datebitis.Value && x.alimTarihi >= baslangic);
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.adet).ToString();
                ttoplam2.Text = list.Sum(x => (x.alisFiyati * x.adet)).ToString();
            }
            if (radioToplamBalik.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM BALIK";
                dataGridView1.DataSource = db.toplamBalik.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = db.toplamBalik.Sum(x => x.adet).ToString();
            }
            if (radioZayiat.Checked)
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
                label2.Visible = false;
                ttoplam2.Visible = false;
                label1.Text = "TOPLAM ZAYİAT";
                var list = db.zayiat.Where(x => x.tarih <= datebitis.Value && x.tarih >= baslangic);
                dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                dataGridView1.ReadOnly = true;
                gridDuzenle(dataGridView1);
                tToplamSatis.Text = list.Sum(x => x.adet).ToString();
            }
            if (radioBorcIslemleri.Checked)
            {
                label2.Visible = false;
                ttoplam2.Visible = false;
                if (radioBorcSilme.Checked) {
                    label1.Text = "TOPLAM İŞLEM";
                    var list = db.borcIslemleri.Where(x => x.tarih <= datebitis.Value && x.tarih >= baslangic && x.islem== "Borç Ödeme");
                    dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                    dataGridView1.ReadOnly = true;
                    gridDuzenle(dataGridView1);
                    tToplamSatis.Text = list.Sum(x => x.tutar).ToString();
                }
                if (radioBorcEkleme.Checked)
                {
                    label1.Text = "TOPLAM İŞLEM";
                    var list = db.borcIslemleri.Where(x => x.tarih <= datebitis.Value && x.tarih >= baslangic && x.islem == "Borç Ekleme");
                    dataGridView1.DataSource = list.OrderByDescending(x => x.Id).ToList();
                    dataGridView1.ReadOnly = true;
                    gridDuzenle(dataGridView1);
                    tToplamSatis.Text = list.Sum(x => x.tutar).ToString();
                }

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

        private void fRapor_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            ttoplam2.Visible = false;
            radioBorcEkleme.Visible = false;
            radioBorcSilme.Visible = false;
        }

        private void radioBorcIslemleri_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBorcIslemleri.Checked)
            {
                radioBorcEkleme.Visible = true;
                radioBorcSilme.Visible = true;
            }
            else
            {
                radioBorcEkleme.Visible = false;
                radioBorcSilme.Visible = false;
            }
        }
    }
}
