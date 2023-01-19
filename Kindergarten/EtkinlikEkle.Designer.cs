namespace Kindergarten
{
    partial class EtkinlikEkle
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
            this.TxtEtkAd = new System.Windows.Forms.TextBox();
            this.TxtEtkKaz = new System.Windows.Forms.TextBox();
            this.btnEtkEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etkinlik Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etkinlik Kazanımı:";
            // 
            // TxtEtkAd
            // 
            this.TxtEtkAd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEtkAd.Location = new System.Drawing.Point(228, 86);
            this.TxtEtkAd.Name = "TxtEtkAd";
            this.TxtEtkAd.Size = new System.Drawing.Size(159, 31);
            this.TxtEtkAd.TabIndex = 3;
            // 
            // TxtEtkKaz
            // 
            this.TxtEtkKaz.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEtkKaz.Location = new System.Drawing.Point(228, 132);
            this.TxtEtkKaz.Name = "TxtEtkKaz";
            this.TxtEtkKaz.Size = new System.Drawing.Size(159, 31);
            this.TxtEtkKaz.TabIndex = 4;
            // 
            // btnEtkEkle
            // 
            this.btnEtkEkle.Location = new System.Drawing.Point(228, 178);
            this.btnEtkEkle.Name = "btnEtkEkle";
            this.btnEtkEkle.Size = new System.Drawing.Size(159, 35);
            this.btnEtkEkle.TabIndex = 5;
            this.btnEtkEkle.Text = "Ekle";
            this.btnEtkEkle.UseVisualStyleBackColor = true;
            this.btnEtkEkle.Click += new System.EventHandler(this.btnEtkEkle_Click);
            // 
            // EtkinlikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 254);
            this.Controls.Add(this.btnEtkEkle);
            this.Controls.Add(this.TxtEtkKaz);
            this.Controls.Add(this.TxtEtkAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EtkinlikEkle";
            this.Text = "EtkinlikEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEtkAd;
        private System.Windows.Forms.TextBox TxtEtkKaz;
        private System.Windows.Forms.Button btnEtkEkle;
    }
}