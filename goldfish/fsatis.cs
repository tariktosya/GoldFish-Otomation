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
    public partial class fsatis : Form
    {
        public fsatis()
        {
            InitializeComponent();
        }
        DatabaseEntities db =new DatabaseEntities();
        satislar satis = new satislar();
        toplamBalik baliktoplam =new toplamBalik();
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ttur.Text != "" && tcins.Text != "" && tadet.Text != "" && tbirimfiyat.Text != "" && dateTimePicker1.Value != null)
            {
                if (db.toplamBalik.Any(x=>x.tur==ttur.Text&&x.cins==tcins.Text)) {
                    var balik = db.toplamBalik.Where(x => x.tur == ttur.Text && x.cins == tcins.Text).SingleOrDefault();
                    if (balik.adet - Convert.ToDouble(tadet.Text) >= 0) {
                        satis.firma = tFirma.Text;
                        satis.balikTuru = ttur.Text;
                        satis.balikCinsi = tcins.Text;
                        satis.adet = Convert.ToDouble(tadet.Text);
                        satis.birimFiyat = Convert.ToDouble(tbirimfiyat.Text);
                        satis.tarih = dateTimePicker1.Value;
                        satis.toplam = Convert.ToDouble(tadet.Text) * Convert.ToDouble(tbirimfiyat.Text);
                        balik.adet = balik.adet - Convert.ToDouble(tadet.Text);
                        db.satislar.Add(satis);
                        db.SaveChanges();
                        MessageBox.Show("Satış Tamamlandı.");
                        ttur.Text = "";
                        tcins.Text = "";
                        tadet.Text = "";
                        tbirimfiyat.Text = "";
                        tFirma.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        ttoplam.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Satılmak İstenen Adet Mevcut Değil. Toplam Adet =" + balik.adet);
                    }
                }
                else
                {
                    MessageBox.Show("TÜR ve CİNS Bilgilerini Kontrol Ediniz!");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tadet.Text != "" && tbirimfiyat.Text !="") {
                ttoplam.Text = (Convert.ToDouble(tadet.Text) * Convert.ToDouble(tbirimfiyat.Text)).ToString() + " ₺";
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
            }
        }
    }
}
