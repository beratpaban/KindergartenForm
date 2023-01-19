namespace Kindergarten
{
    partial class VeriTabaniYedekle
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
            this.BtnBackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.TxtYedekleYol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYedekSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYedekYol = new System.Windows.Forms.TextBox();
            this.BtnYedektenYukle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBackup
            // 
            this.BtnBackup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBackup.Location = new System.Drawing.Point(298, 124);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(72, 28);
            this.BtnBackup.TabIndex = 7;
            this.BtnBackup.Text = "Yedekle";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSec);
            this.groupBox1.Controls.Add(this.TxtYedekleYol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnBackup);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 326);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yedekle";
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(298, 79);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(72, 28);
            this.btnSec.TabIndex = 10;
            this.btnSec.Text = "....";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // TxtYedekleYol
            // 
            this.TxtYedekleYol.Location = new System.Drawing.Point(98, 79);
            this.TxtYedekleYol.Name = "TxtYedekleYol";
            this.TxtYedekleYol.Size = new System.Drawing.Size(194, 25);
            this.TxtYedekleYol.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Konum:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYedekSec);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtYedekYol);
            this.groupBox2.Controls.Add(this.BtnYedektenYukle);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 326);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekten Yükle";
            // 
            // btnYedekSec
            // 
            this.btnYedekSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekSec.Location = new System.Drawing.Point(299, 85);
            this.btnYedekSec.Name = "btnYedekSec";
            this.btnYedekSec.Size = new System.Drawing.Size(72, 28);
            this.btnYedekSec.TabIndex = 14;
            this.btnYedekSec.Text = "....";
            this.btnYedekSec.UseVisualStyleBackColor = true;
            this.btnYedekSec.Click += new System.EventHandler(this.btnYedekSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Konum:";
            // 
            // TxtYedekYol
            // 
            this.TxtYedekYol.Location = new System.Drawing.Point(99, 85);
            this.TxtYedekYol.Name = "TxtYedekYol";
            this.TxtYedekYol.Size = new System.Drawing.Size(194, 25);
            this.TxtYedekYol.TabIndex = 13;
            // 
            // BtnYedektenYukle
            // 
            this.BtnYedektenYukle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYedektenYukle.Location = new System.Drawing.Point(299, 130);
            this.BtnYedektenYukle.Name = "BtnYedektenYukle";
            this.BtnYedektenYukle.Size = new System.Drawing.Size(72, 28);
            this.BtnYedektenYukle.TabIndex = 11;
            this.BtnYedektenYukle.Text = "Yükle";
            this.BtnYedektenYukle.UseVisualStyleBackColor = true;
            this.BtnYedektenYukle.Click += new System.EventHandler(this.BtnYedektenYukle_Click);
            // 
            // VeriTabaniYedekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VeriTabaniYedekle";
            this.Text = "SQL Yedekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox TxtYedekleYol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYedekSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYedekYol;
        private System.Windows.Forms.Button BtnYedektenYukle;
    }
}