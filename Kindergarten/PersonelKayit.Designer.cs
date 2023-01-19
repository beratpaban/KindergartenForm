namespace Kindergarten
{
    partial class PersonelKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPerAd = new System.Windows.Forms.TextBox();
            this.TxtPerSoyad = new System.Windows.Forms.TextBox();
            this.MskTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.CmbPerCinsiyet = new System.Windows.Forms.ComboBox();
            this.CmbPerUnvan = new System.Windows.Forms.ComboBox();
            this.MskTxtDogum = new System.Windows.Forms.MaskedTextBox();
            this.CmbTxtEtk = new System.Windows.Forms.ComboBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ünvan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Etkinlik Seç:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cinsiyet:";
            // 
            // TxtPerAd
            // 
            this.TxtPerAd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPerAd.Location = new System.Drawing.Point(176, 70);
            this.TxtPerAd.Name = "TxtPerAd";
            this.TxtPerAd.Size = new System.Drawing.Size(167, 31);
            this.TxtPerAd.TabIndex = 9;
            // 
            // TxtPerSoyad
            // 
            this.TxtPerSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPerSoyad.Location = new System.Drawing.Point(176, 124);
            this.TxtPerSoyad.Name = "TxtPerSoyad";
            this.TxtPerSoyad.Size = new System.Drawing.Size(167, 31);
            this.TxtPerSoyad.TabIndex = 10;
            // 
            // MskTxtTc
            // 
            this.MskTxtTc.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtTc.Location = new System.Drawing.Point(176, 188);
            this.MskTxtTc.Mask = "00000000000";
            this.MskTxtTc.Name = "MskTxtTc";
            this.MskTxtTc.Size = new System.Drawing.Size(167, 31);
            this.MskTxtTc.TabIndex = 11;
            // 
            // CmbPerCinsiyet
            // 
            this.CmbPerCinsiyet.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbPerCinsiyet.FormattingEnabled = true;
            this.CmbPerCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbPerCinsiyet.Location = new System.Drawing.Point(176, 246);
            this.CmbPerCinsiyet.Name = "CmbPerCinsiyet";
            this.CmbPerCinsiyet.Size = new System.Drawing.Size(167, 31);
            this.CmbPerCinsiyet.TabIndex = 12;
            // 
            // CmbPerUnvan
            // 
            this.CmbPerUnvan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbPerUnvan.FormattingEnabled = true;
            this.CmbPerUnvan.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Öğretmen"});
            this.CmbPerUnvan.Location = new System.Drawing.Point(176, 297);
            this.CmbPerUnvan.Name = "CmbPerUnvan";
            this.CmbPerUnvan.Size = new System.Drawing.Size(167, 31);
            this.CmbPerUnvan.TabIndex = 13;
            // 
            // MskTxtDogum
            // 
            this.MskTxtDogum.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtDogum.Location = new System.Drawing.Point(176, 346);
            this.MskTxtDogum.Mask = "00/00/0000";
            this.MskTxtDogum.Name = "MskTxtDogum";
            this.MskTxtDogum.Size = new System.Drawing.Size(167, 31);
            this.MskTxtDogum.TabIndex = 14;
            this.MskTxtDogum.ValidatingType = typeof(System.DateTime);
            // 
            // CmbTxtEtk
            // 
            this.CmbTxtEtk.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbTxtEtk.FormattingEnabled = true;
            this.CmbTxtEtk.Location = new System.Drawing.Point(176, 393);
            this.CmbTxtEtk.Name = "CmbTxtEtk";
            this.CmbTxtEtk.Size = new System.Drawing.Size(167, 31);
            this.CmbTxtEtk.TabIndex = 15;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(372, 504);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(100, 35);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(176, 438);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(167, 31);
            this.TxtSifre.TabIndex = 18;
            // 
            // PersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.CmbTxtEtk);
            this.Controls.Add(this.MskTxtDogum);
            this.Controls.Add(this.CmbPerUnvan);
            this.Controls.Add(this.CmbPerCinsiyet);
            this.Controls.Add(this.MskTxtTc);
            this.Controls.Add(this.TxtPerSoyad);
            this.Controls.Add(this.TxtPerAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PersonelKayit";
            this.Text = "PersonelKayit";
            this.Load += new System.EventHandler(this.PersonelKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPerAd;
        private System.Windows.Forms.TextBox TxtPerSoyad;
        private System.Windows.Forms.MaskedTextBox MskTxtTc;
        private System.Windows.Forms.ComboBox CmbPerCinsiyet;
        private System.Windows.Forms.ComboBox CmbPerUnvan;
        private System.Windows.Forms.MaskedTextBox MskTxtDogum;
        private System.Windows.Forms.ComboBox CmbTxtEtk;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}