namespace goldfish
{
    partial class Form1
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
            this.tcins = new System.Windows.Forms.TextBox();
            this.CİNS = new System.Windows.Forms.Label();
            this.bkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ttur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tadet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.talimFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSil = new System.Windows.Forms.Button();
            this.radioZayiat = new System.Windows.Forms.RadioButton();
            this.radioBalikGirisi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcins
            // 
            this.tcins.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tcins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tcins.Location = new System.Drawing.Point(268, 105);
            this.tcins.Name = "tcins";
            this.tcins.Size = new System.Drawing.Size(279, 32);
            this.tcins.TabIndex = 1;
            // 
            // CİNS
            // 
            this.CİNS.AutoSize = true;
            this.CİNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CİNS.Location = new System.Drawing.Point(75, 110);
            this.CİNS.Name = "CİNS";
            this.CİNS.Size = new System.Drawing.Size(65, 26);
            this.CİNS.TabIndex = 1;
            this.CİNS.Text = "CİNS";
            // 
            // bkaydet
            // 
            this.bkaydet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bkaydet.Location = new System.Drawing.Point(579, 158);
            this.bkaydet.Name = "bkaydet";
            this.bkaydet.Size = new System.Drawing.Size(126, 70);
            this.bkaydet.TabIndex = 5;
            this.bkaydet.Text = "KAYDET";
            this.bkaydet.UseVisualStyleBackColor = false;
            this.bkaydet.Click += new System.EventHandler(this.bkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 319);
            this.dataGridView1.TabIndex = 3;
            // 
            // ttur
            // 
            this.ttur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ttur.Location = new System.Drawing.Point(268, 67);
            this.ttur.Name = "ttur";
            this.ttur.Size = new System.Drawing.Size(279, 32);
            this.ttur.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÜR";
            // 
            // tadet
            // 
            this.tadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tadet.Location = new System.Drawing.Point(268, 146);
            this.tadet.Name = "tadet";
            this.tadet.Size = new System.Drawing.Size(279, 32);
            this.tadet.TabIndex = 2;
            this.tadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tadet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(75, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADET";
            // 
            // talimFiyat
            // 
            this.talimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.talimFiyat.Location = new System.Drawing.Point(268, 184);
            this.talimFiyat.Name = "talimFiyat";
            this.talimFiyat.Size = new System.Drawing.Size(279, 32);
            this.talimFiyat.TabIndex = 3;
            this.talimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.talimFiyat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(75, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "ALIM FİYATI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(75, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "ALIM TARİHİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 28);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // tsil
            // 
            this.tsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tsil.Location = new System.Drawing.Point(852, 96);
            this.tsil.Name = "tsil";
            this.tsil.Size = new System.Drawing.Size(126, 32);
            this.tsil.TabIndex = 6;
            this.tsil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsil_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(805, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİLİNECEK NUMARA";
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bSil.Location = new System.Drawing.Point(852, 134);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(126, 70);
            this.bSil.TabIndex = 7;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // radioZayiat
            // 
            this.radioZayiat.AutoSize = true;
            this.radioZayiat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioZayiat.Location = new System.Drawing.Point(579, 109);
            this.radioZayiat.Name = "radioZayiat";
            this.radioZayiat.Size = new System.Drawing.Size(110, 30);
            this.radioZayiat.TabIndex = 8;
            this.radioZayiat.TabStop = true;
            this.radioZayiat.Text = "ZAYİAT";
            this.radioZayiat.UseVisualStyleBackColor = true;
            this.radioZayiat.CheckedChanged += new System.EventHandler(this.radioZayiat_CheckedChanged);
            // 
            // radioBalikGirisi
            // 
            this.radioBalikGirisi.AutoSize = true;
            this.radioBalikGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioBalikGirisi.Location = new System.Drawing.Point(579, 73);
            this.radioBalikGirisi.Name = "radioBalikGirisi";
            this.radioBalikGirisi.Size = new System.Drawing.Size(168, 30);
            this.radioBalikGirisi.TabIndex = 8;
            this.radioBalikGirisi.TabStop = true;
            this.radioBalikGirisi.Text = "BALIK GİRİŞİ";
            this.radioBalikGirisi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 622);
            this.Controls.Add(this.radioBalikGirisi);
            this.Controls.Add(this.radioZayiat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bkaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CİNS);
            this.Controls.Add(this.talimFiyat);
            this.Controls.Add(this.tadet);
            this.Controls.Add(this.ttur);
            this.Controls.Add(this.tsil);
            this.Controls.Add(this.tcins);
            this.MaximumSize = new System.Drawing.Size(1099, 669);
            this.MinimumSize = new System.Drawing.Size(1099, 669);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BALIK GİRİŞİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcins;
        private System.Windows.Forms.Label CİNS;
        private System.Windows.Forms.Button bkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ttur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox talimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.TextBox tadet;
        private System.Windows.Forms.RadioButton radioZayiat;
        private System.Windows.Forms.RadioButton radioBalikGirisi;
    }
}

