namespace goldfish
{
    partial class fRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tToplamSatis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioVerecek = new System.Windows.Forms.RadioButton();
            this.radioAlacak = new System.Windows.Forms.RadioButton();
            this.radioMasraflar = new System.Windows.Forms.RadioButton();
            this.radioZayiat = new System.Windows.Forms.RadioButton();
            this.radioToplamBalik = new System.Windows.Forms.RadioButton();
            this.radioBorcIslemleri = new System.Windows.Forms.RadioButton();
            this.radioBalikGirisleri = new System.Windows.Forms.RadioButton();
            this.radioSatislar = new System.Windows.Forms.RadioButton();
            this.bListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datebaslangic = new System.Windows.Forms.DateTimePicker();
            this.datebitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ttoplam2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBorcEkleme = new System.Windows.Forms.RadioButton();
            this.radioBorcSilme = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(297, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Satış";
            // 
            // tToplamSatis
            // 
            this.tToplamSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tToplamSatis.Location = new System.Drawing.Point(495, 266);
            this.tToplamSatis.Name = "tToplamSatis";
            this.tToplamSatis.ReadOnly = true;
            this.tToplamSatis.Size = new System.Drawing.Size(128, 30);
            this.tToplamSatis.TabIndex = 1;
            this.tToplamSatis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioVerecek);
            this.groupBox2.Controls.Add(this.radioAlacak);
            this.groupBox2.Controls.Add(this.radioMasraflar);
            this.groupBox2.Controls.Add(this.radioZayiat);
            this.groupBox2.Controls.Add(this.radioToplamBalik);
            this.groupBox2.Controls.Add(this.radioBorcIslemleri);
            this.groupBox2.Controls.Add(this.radioBalikGirisleri);
            this.groupBox2.Controls.Add(this.radioSatislar);
            this.groupBox2.Location = new System.Drawing.Point(30, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 308);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR TÜRÜ";
            // 
            // radioVerecek
            // 
            this.radioVerecek.AutoSize = true;
            this.radioVerecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioVerecek.Location = new System.Drawing.Point(6, 126);
            this.radioVerecek.Name = "radioVerecek";
            this.radioVerecek.Size = new System.Drawing.Size(165, 29);
            this.radioVerecek.TabIndex = 0;
            this.radioVerecek.TabStop = true;
            this.radioVerecek.Text = "VERECEKLER";
            this.radioVerecek.UseVisualStyleBackColor = true;
            // 
            // radioAlacak
            // 
            this.radioAlacak.AutoSize = true;
            this.radioAlacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioAlacak.Location = new System.Drawing.Point(6, 91);
            this.radioAlacak.Name = "radioAlacak";
            this.radioAlacak.Size = new System.Drawing.Size(153, 29);
            this.radioAlacak.TabIndex = 0;
            this.radioAlacak.TabStop = true;
            this.radioAlacak.Text = "ALACAKLAR";
            this.radioAlacak.UseVisualStyleBackColor = true;
            // 
            // radioMasraflar
            // 
            this.radioMasraflar.AutoSize = true;
            this.radioMasraflar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioMasraflar.Location = new System.Drawing.Point(6, 56);
            this.radioMasraflar.Name = "radioMasraflar";
            this.radioMasraflar.Size = new System.Drawing.Size(155, 29);
            this.radioMasraflar.TabIndex = 0;
            this.radioMasraflar.TabStop = true;
            this.radioMasraflar.Text = "MASRAFLAR";
            this.radioMasraflar.UseVisualStyleBackColor = true;
            // 
            // radioZayiat
            // 
            this.radioZayiat.AutoSize = true;
            this.radioZayiat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioZayiat.Location = new System.Drawing.Point(6, 266);
            this.radioZayiat.Name = "radioZayiat";
            this.radioZayiat.Size = new System.Drawing.Size(104, 29);
            this.radioZayiat.TabIndex = 0;
            this.radioZayiat.TabStop = true;
            this.radioZayiat.Text = "ZAYİAT";
            this.radioZayiat.UseVisualStyleBackColor = true;
            // 
            // radioToplamBalik
            // 
            this.radioToplamBalik.AutoSize = true;
            this.radioToplamBalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioToplamBalik.Location = new System.Drawing.Point(6, 231);
            this.radioToplamBalik.Name = "radioToplamBalik";
            this.radioToplamBalik.Size = new System.Drawing.Size(179, 29);
            this.radioToplamBalik.TabIndex = 0;
            this.radioToplamBalik.TabStop = true;
            this.radioToplamBalik.Text = "TOPLAM BALIK";
            this.radioToplamBalik.UseVisualStyleBackColor = true;
            // 
            // radioBorcIslemleri
            // 
            this.radioBorcIslemleri.AutoSize = true;
            this.radioBorcIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioBorcIslemleri.Location = new System.Drawing.Point(6, 161);
            this.radioBorcIslemleri.Name = "radioBorcIslemleri";
            this.radioBorcIslemleri.Size = new System.Drawing.Size(197, 29);
            this.radioBorcIslemleri.TabIndex = 0;
            this.radioBorcIslemleri.TabStop = true;
            this.radioBorcIslemleri.Text = "BORÇ İŞLEMLERİ";
            this.radioBorcIslemleri.UseVisualStyleBackColor = true;
            this.radioBorcIslemleri.CheckedChanged += new System.EventHandler(this.radioBorcIslemleri_CheckedChanged);
            // 
            // radioBalikGirisleri
            // 
            this.radioBalikGirisleri.AutoSize = true;
            this.radioBalikGirisleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioBalikGirisleri.Location = new System.Drawing.Point(6, 196);
            this.radioBalikGirisleri.Name = "radioBalikGirisleri";
            this.radioBalikGirisleri.Size = new System.Drawing.Size(189, 29);
            this.radioBalikGirisleri.TabIndex = 0;
            this.radioBalikGirisleri.TabStop = true;
            this.radioBalikGirisleri.Text = "BALIK GİRİŞLERİ";
            this.radioBalikGirisleri.UseVisualStyleBackColor = true;
            // 
            // radioSatislar
            // 
            this.radioSatislar.AutoSize = true;
            this.radioSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioSatislar.Location = new System.Drawing.Point(6, 21);
            this.radioSatislar.Name = "radioSatislar";
            this.radioSatislar.Size = new System.Drawing.Size(131, 29);
            this.radioSatislar.TabIndex = 11;
            this.radioSatislar.TabStop = true;
            this.radioSatislar.Text = "SATIŞLAR";
            this.radioSatislar.UseVisualStyleBackColor = true;
            // 
            // bListele
            // 
            this.bListele.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bListele.Location = new System.Drawing.Point(296, 99);
            this.bListele.Name = "bListele";
            this.bListele.Size = new System.Drawing.Size(128, 84);
            this.bListele.TabIndex = 0;
            this.bListele.Text = "LİSTELE";
            this.bListele.UseVisualStyleBackColor = false;
            this.bListele.Click += new System.EventHandler(this.bListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1291, 460);
            this.dataGridView1.TabIndex = 5;
            // 
            // datebaslangic
            // 
            this.datebaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.datebaslangic.Location = new System.Drawing.Point(292, 65);
            this.datebaslangic.Name = "datebaslangic";
            this.datebaslangic.Size = new System.Drawing.Size(249, 28);
            this.datebaslangic.TabIndex = 6;
            // 
            // datebitis
            // 
            this.datebitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.datebitis.Location = new System.Drawing.Point(566, 65);
            this.datebitis.Name = "datebitis";
            this.datebitis.Size = new System.Drawing.Size(249, 28);
            this.datebitis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(308, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(613, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "BİTİŞ TARİHİ";
            // 
            // ttoplam2
            // 
            this.ttoplam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ttoplam2.Location = new System.Drawing.Point(712, 267);
            this.ttoplam2.Name = "ttoplam2";
            this.ttoplam2.ReadOnly = true;
            this.ttoplam2.Size = new System.Drawing.Size(128, 30);
            this.ttoplam2.TabIndex = 1;
            this.ttoplam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(649, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Balık Alımına Toplam Ödenen";
            // 
            // radioBorcEkleme
            // 
            this.radioBorcEkleme.AutoSize = true;
            this.radioBorcEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioBorcEkleme.Location = new System.Drawing.Point(252, 189);
            this.radioBorcEkleme.Name = "radioBorcEkleme";
            this.radioBorcEkleme.Size = new System.Drawing.Size(152, 24);
            this.radioBorcEkleme.TabIndex = 0;
            this.radioBorcEkleme.TabStop = true;
            this.radioBorcEkleme.Text = "BORÇ EKLEME";
            this.radioBorcEkleme.UseVisualStyleBackColor = true;
            // 
            // radioBorcSilme
            // 
            this.radioBorcSilme.AutoSize = true;
            this.radioBorcSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioBorcSilme.Location = new System.Drawing.Point(252, 224);
            this.radioBorcSilme.Name = "radioBorcSilme";
            this.radioBorcSilme.Size = new System.Drawing.Size(146, 24);
            this.radioBorcSilme.TabIndex = 0;
            this.radioBorcSilme.TabStop = true;
            this.radioBorcSilme.Text = "BORÇ ÖDEME";
            this.radioBorcSilme.UseVisualStyleBackColor = true;
            // 
            // fRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 822);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datebitis);
            this.Controls.Add(this.datebaslangic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioBorcSilme);
            this.Controls.Add(this.radioBorcEkleme);
            this.Controls.Add(this.bListele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttoplam2);
            this.Controls.Add(this.tToplamSatis);
            this.MaximumSize = new System.Drawing.Size(1351, 869);
            this.MinimumSize = new System.Drawing.Size(1351, 869);
            this.Name = "fRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPOR";
            this.Load += new System.EventHandler(this.fRapor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tToplamSatis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioVerecek;
        private System.Windows.Forms.RadioButton radioAlacak;
        private System.Windows.Forms.RadioButton radioMasraflar;
        private System.Windows.Forms.RadioButton radioSatislar;
        private System.Windows.Forms.RadioButton radioToplamBalik;
        private System.Windows.Forms.RadioButton radioBalikGirisleri;
        private System.Windows.Forms.Button bListele;
        private System.Windows.Forms.RadioButton radioZayiat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker datebaslangic;
        private System.Windows.Forms.DateTimePicker datebitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttoplam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBorcIslemleri;
        private System.Windows.Forms.RadioButton radioBorcEkleme;
        private System.Windows.Forms.RadioButton radioBorcSilme;
    }
}