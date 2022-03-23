using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goldfish
{
    public partial class fStart : Form
    {
        public fStart()
        {
            InitializeComponent();
        }
        Form1 balikGiris = new Form1();
        fborclar borclar = new fborclar();
        fMasraflar masraflar = new fMasraflar();
        fRapor rapor = new fRapor();
        fsatis satis = new fsatis();
        private void bSatisIslemleri_Click(object sender, EventArgs e)
        {
            satis.ShowDialog();
        }

        private void bBalikGirisCikis_Click(object sender, EventArgs e)
        {
            balikGiris.ShowDialog();
        }

        private void bMasraflar_Click(object sender, EventArgs e)
        {
            masraflar.ShowDialog();
        }

        private void bBorcIslemleri_Click(object sender, EventArgs e)
        {
            borclar.ShowDialog();
        }

        private void bRaporEkrani_Click(object sender, EventArgs e)
        {
            rapor.ShowDialog();
        }

        private void bYedekle_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası|0.bak";
            save.FileName = "GoldFish_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))
                    {
                        File.Delete(save.FileName);
                    }
                    var dbHedef = save.FileName;
                    string dbKaynak = Application.StartupPath + @"\Database.mdf";
                    using (var db = new DatabaseEntities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "] TO DISK='" + dbHedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedekleme Tamamlanmıştır.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bGeriYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }
    }
}
