namespace Kindergarten
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVeliGiris = new System.Windows.Forms.Button();
            this.BtnPersonelGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(306, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cloffy Kindergarten";
            // 
            // BtnVeliGiris
            // 
            this.BtnVeliGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVeliGiris.BackgroundImage")));
            this.BtnVeliGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVeliGiris.Location = new System.Drawing.Point(18, 229);
            this.BtnVeliGiris.Name = "BtnVeliGiris";
            this.BtnVeliGiris.Size = new System.Drawing.Size(200, 150);
            this.BtnVeliGiris.TabIndex = 2;
            this.BtnVeliGiris.UseVisualStyleBackColor = true;
            this.BtnVeliGiris.Click += new System.EventHandler(this.BtnVeliGiris_Click);
            // 
            // BtnPersonelGiris
            // 
            this.BtnPersonelGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPersonelGiris.BackgroundImage")));
            this.BtnPersonelGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPersonelGiris.Location = new System.Drawing.Point(256, 229);
            this.BtnPersonelGiris.Name = "BtnPersonelGiris";
            this.BtnPersonelGiris.Size = new System.Drawing.Size(200, 150);
            this.BtnPersonelGiris.TabIndex = 3;
            this.BtnPersonelGiris.UseVisualStyleBackColor = true;
            this.BtnPersonelGiris.Click += new System.EventHandler(this.BtnPersonelGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(93, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Veli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(301, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPersonelGiris);
            this.Controls.Add(this.BtnVeliGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVeliGiris;
        private System.Windows.Forms.Button BtnPersonelGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}