namespace Kindergarten
{
    partial class VeliKayit
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
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.TxtVeliTelNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtVeliSoyad = new System.Windows.Forms.MaskedTextBox();
            this.TxtVeliAd = new System.Windows.Forms.MaskedTextBox();
            this.TxtVeliSifre = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdres = new System.Windows.Forms.MaskedTextBox();
            this.CmbVeliCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVeliTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.BtnKayitYap.Location = new System.Drawing.Point(318, 360);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(150, 45);
            this.BtnKayitYap.TabIndex = 46;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = true;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // TxtVeliTelNo
            // 
            this.TxtVeliTelNo.Location = new System.Drawing.Point(156, 195);
            this.TxtVeliTelNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVeliTelNo.Name = "TxtVeliTelNo";
            this.TxtVeliTelNo.Size = new System.Drawing.Size(195, 20);
            this.TxtVeliTelNo.TabIndex = 45;
            // 
            // TxtVeliSoyad
            // 
            this.TxtVeliSoyad.Location = new System.Drawing.Point(156, 116);
            this.TxtVeliSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVeliSoyad.Name = "TxtVeliSoyad";
            this.TxtVeliSoyad.Size = new System.Drawing.Size(195, 20);
            this.TxtVeliSoyad.TabIndex = 44;
            // 
            // TxtVeliAd
            // 
            this.TxtVeliAd.Location = new System.Drawing.Point(156, 73);
            this.TxtVeliAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVeliAd.Name = "TxtVeliAd";
            this.TxtVeliAd.Size = new System.Drawing.Size(195, 20);
            this.TxtVeliAd.TabIndex = 43;
            // 
            // TxtVeliSifre
            // 
            this.TxtVeliSifre.Location = new System.Drawing.Point(156, 334);
            this.TxtVeliSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVeliSifre.Name = "TxtVeliSifre";
            this.TxtVeliSifre.Size = new System.Drawing.Size(195, 20);
            this.TxtVeliSifre.TabIndex = 42;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(156, 289);
            this.TxtAdres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(195, 20);
            this.TxtAdres.TabIndex = 41;
            // 
            // CmbVeliCinsiyet
            // 
            this.CmbVeliCinsiyet.FormattingEnabled = true;
            this.CmbVeliCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbVeliCinsiyet.Location = new System.Drawing.Point(156, 242);
            this.CmbVeliCinsiyet.Name = "CmbVeliCinsiyet";
            this.CmbVeliCinsiyet.Size = new System.Drawing.Size(195, 21);
            this.CmbVeliCinsiyet.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(77, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Şifre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(67, 284);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(95, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(120, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Veli Kayıt Sistemi";
            // 
            // TxtVeliTcNo
            // 
            this.TxtVeliTcNo.Location = new System.Drawing.Point(156, 153);
            this.TxtVeliTcNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVeliTcNo.Name = "TxtVeliTcNo";
            this.TxtVeliTcNo.Size = new System.Drawing.Size(195, 20);
            this.TxtVeliTcNo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(64, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "TcNo:";
            // 
            // VeliKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtVeliTcNo);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.TxtVeliTelNo);
            this.Controls.Add(this.TxtVeliSoyad);
            this.Controls.Add(this.TxtVeliAd);
            this.Controls.Add(this.TxtVeliSifre);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.CmbVeliCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "VeliKayit";
            this.Text = "VeliKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayitYap;
        private System.Windows.Forms.MaskedTextBox TxtVeliTelNo;
        private System.Windows.Forms.MaskedTextBox TxtVeliSoyad;
        private System.Windows.Forms.MaskedTextBox TxtVeliAd;
        private System.Windows.Forms.MaskedTextBox TxtVeliSifre;
        private System.Windows.Forms.MaskedTextBox TxtAdres;
        private System.Windows.Forms.ComboBox CmbVeliCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtVeliTcNo;
        private System.Windows.Forms.Label label6;
    }
}