namespace Kindergarten
{
    partial class VeliGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeliGiris));
            this.BtnVeliGiris = new System.Windows.Forms.Button();
            this.MskSifre = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVeliGiris
            // 
            this.BtnVeliGiris.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnVeliGiris.Location = new System.Drawing.Point(167, 317);
            this.BtnVeliGiris.Name = "BtnVeliGiris";
            this.BtnVeliGiris.Size = new System.Drawing.Size(127, 37);
            this.BtnVeliGiris.TabIndex = 11;
            this.BtnVeliGiris.Text = "Giriş Yap";
            this.BtnVeliGiris.UseVisualStyleBackColor = true;
            this.BtnVeliGiris.Click += new System.EventHandler(this.BtnVeliGiris_Click);
            // 
            // MskSifre
            // 
            this.MskSifre.Location = new System.Drawing.Point(156, 269);
            this.MskSifre.Name = "MskSifre";
            this.MskSifre.Size = new System.Drawing.Size(150, 20);
            this.MskSifre.TabIndex = 10;
            this.MskSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(201, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // MskTcNo
            // 
            this.MskTcNo.Location = new System.Drawing.Point(156, 176);
            this.MskTcNo.Mask = "00000000000";
            this.MskTcNo.Name = "MskTcNo";
            this.MskTcNo.Size = new System.Drawing.Size(150, 20);
            this.MskTcNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(156, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veli Giriş Paneli";
            // 
            // VeliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BtnVeliGiris);
            this.Controls.Add(this.MskSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskTcNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VeliGiris";
            this.Text = "VeliGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVeliGiris;
        private System.Windows.Forms.MaskedTextBox MskSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}