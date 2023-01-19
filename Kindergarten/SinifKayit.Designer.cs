namespace Kindergarten
{
    partial class SinifKayit
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbPerID = new System.Windows.Forms.ComboBox();
            this.CmbEtkID = new System.Windows.Forms.ComboBox();
            this.TxtSinifAd = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSinifSil = new System.Windows.Forms.Button();
            this.BtnSinifKaydet = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etkinlikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazanımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDataSet4 = new Kindergarten.KindergartenDataSet4();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.persidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergartenDataSet5 = new Kindergarten.KindergartenDataSet5();
            this.etkinlikTableAdapter = new Kindergarten.KindergartenDataSet4TableAdapters.etkinlikTableAdapter();
            this.personelTableAdapter = new Kindergarten.KindergartenDataSet5TableAdapters.personelTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.kindergartenDataSet6 = new Kindergarten.KindergartenDataSet6();
            this.sinifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinifTableAdapter = new Kindergarten.KindergartenDataSet6TableAdapters.sinifTableAdapter();
            this.sinifidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinifBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbPerID);
            this.groupBox1.Controls.Add(this.CmbEtkID);
            this.groupBox1.Controls.Add(this.TxtSinifAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Aç";
            // 
            // CmbPerID
            // 
            this.CmbPerID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbPerID.FormattingEnabled = true;
            this.CmbPerID.Location = new System.Drawing.Point(147, 174);
            this.CmbPerID.Name = "CmbPerID";
            this.CmbPerID.Size = new System.Drawing.Size(195, 28);
            this.CmbPerID.TabIndex = 37;
            // 
            // CmbEtkID
            // 
            this.CmbEtkID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbEtkID.FormattingEnabled = true;
            this.CmbEtkID.Location = new System.Drawing.Point(147, 135);
            this.CmbEtkID.Name = "CmbEtkID";
            this.CmbEtkID.Size = new System.Drawing.Size(195, 28);
            this.CmbEtkID.TabIndex = 36;
            // 
            // TxtSinifAd
            // 
            this.TxtSinifAd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSinifAd.Location = new System.Drawing.Point(147, 91);
            this.TxtSinifAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSinifAd.Name = "TxtSinifAd";
            this.TxtSinifAd.Size = new System.Drawing.Size(195, 27);
            this.TxtSinifAd.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Personel ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Etkinlik ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sınıf:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnSinifSil);
            this.groupBox2.Controls.Add(this.BtnSinifKaydet);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(382, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 176);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(207, 115);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(150, 35);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSinifSil
            // 
            this.BtnSinifSil.Location = new System.Drawing.Point(30, 115);
            this.BtnSinifSil.Name = "BtnSinifSil";
            this.BtnSinifSil.Size = new System.Drawing.Size(150, 35);
            this.BtnSinifSil.TabIndex = 2;
            this.BtnSinifSil.Text = "Sil";
            this.BtnSinifSil.UseVisualStyleBackColor = true;
            this.BtnSinifSil.Click += new System.EventHandler(this.BtnSinifSil_Click);
            // 
            // BtnSinifKaydet
            // 
            this.BtnSinifKaydet.Location = new System.Drawing.Point(207, 42);
            this.BtnSinifKaydet.Name = "BtnSinifKaydet";
            this.BtnSinifKaydet.Size = new System.Drawing.Size(150, 35);
            this.BtnSinifKaydet.TabIndex = 1;
            this.BtnSinifKaydet.Text = "Kayıt Et";
            this.BtnSinifKaydet.UseVisualStyleBackColor = true;
            this.BtnSinifKaydet.Click += new System.EventHandler(this.BtnSinifKaydet_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(30, 42);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(150, 35);
            this.BtnListele.TabIndex = 0;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(15, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 276);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Etkinlik Seç";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etkinlikidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.kazanımDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etkinlikBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // etkinlikidDataGridViewTextBoxColumn
            // 
            this.etkinlikidDataGridViewTextBoxColumn.DataPropertyName = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn.HeaderText = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn.Name = "etkinlikidDataGridViewTextBoxColumn";
            this.etkinlikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // kazanımDataGridViewTextBoxColumn
            // 
            this.kazanımDataGridViewTextBoxColumn.DataPropertyName = "kazanım";
            this.kazanımDataGridViewTextBoxColumn.HeaderText = "kazanım";
            this.kazanımDataGridViewTextBoxColumn.Name = "kazanımDataGridViewTextBoxColumn";
            // 
            // etkinlikBindingSource
            // 
            this.etkinlikBindingSource.DataMember = "etkinlik";
            this.etkinlikBindingSource.DataSource = this.kindergartenDataSet4;
            // 
            // kindergartenDataSet4
            // 
            this.kindergartenDataSet4.DataSetName = "KindergartenDataSet4";
            this.kindergartenDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 573);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 276);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel Seç";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn1,
            this.soyadDataGridViewTextBoxColumn,
            this.tcnoDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.etkinlikidDataGridViewTextBoxColumn1,
            this.cinsiyetDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.personelBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(759, 246);
            this.dataGridView2.TabIndex = 0;
            // 
            // persidDataGridViewTextBoxColumn
            // 
            this.persidDataGridViewTextBoxColumn.DataPropertyName = "persid";
            this.persidDataGridViewTextBoxColumn.HeaderText = "persid";
            this.persidDataGridViewTextBoxColumn.Name = "persidDataGridViewTextBoxColumn";
            this.persidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tcno";
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "unvan";
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            // 
            // etkinlikidDataGridViewTextBoxColumn1
            // 
            this.etkinlikidDataGridViewTextBoxColumn1.DataPropertyName = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn1.HeaderText = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn1.Name = "etkinlikidDataGridViewTextBoxColumn1";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.kindergartenDataSet5;
            // 
            // kindergartenDataSet5
            // 
            this.kindergartenDataSet5.DataSetName = "KindergartenDataSet5";
            this.kindergartenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etkinlikTableAdapter
            // 
            this.etkinlikTableAdapter.ClearBeforeFill = true;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(382, 275);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 276);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sınıflar";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinifidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn2,
            this.etkinlikidDataGridViewTextBoxColumn2,
            this.persidDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.sinifBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(378, 246);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.DoubleClick += new System.EventHandler(this.dataGridView3_DoubleClick);
            // 
            // kindergartenDataSet6
            // 
            this.kindergartenDataSet6.DataSetName = "KindergartenDataSet6";
            this.kindergartenDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinifBindingSource
            // 
            this.sinifBindingSource.DataMember = "sinif";
            this.sinifBindingSource.DataSource = this.kindergartenDataSet6;
            // 
            // sinifTableAdapter
            // 
            this.sinifTableAdapter.ClearBeforeFill = true;
            // 
            // sinifidDataGridViewTextBoxColumn
            // 
            this.sinifidDataGridViewTextBoxColumn.DataPropertyName = "sinifid";
            this.sinifidDataGridViewTextBoxColumn.HeaderText = "sinifid";
            this.sinifidDataGridViewTextBoxColumn.Name = "sinifidDataGridViewTextBoxColumn";
            this.sinifidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn2
            // 
            this.adDataGridViewTextBoxColumn2.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn2.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn2.Name = "adDataGridViewTextBoxColumn2";
            // 
            // etkinlikidDataGridViewTextBoxColumn2
            // 
            this.etkinlikidDataGridViewTextBoxColumn2.DataPropertyName = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn2.HeaderText = "etkinlikid";
            this.etkinlikidDataGridViewTextBoxColumn2.Name = "etkinlikidDataGridViewTextBoxColumn2";
            // 
            // persidDataGridViewTextBoxColumn1
            // 
            this.persidDataGridViewTextBoxColumn1.DataPropertyName = "persid";
            this.persidDataGridViewTextBoxColumn1.HeaderText = "persid";
            this.persidDataGridViewTextBoxColumn1.Name = "persidDataGridViewTextBoxColumn1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sınıf ID:";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Location = new System.Drawing.Point(147, 50);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(195, 27);
            this.TxtID.TabIndex = 40;
            // 
            // SinifKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 861);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SinifKayit";
            this.Text = "SinifKayit";
            this.Load += new System.EventHandler(this.SinifKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergartenDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinifBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtSinifAd;
        private System.Windows.Forms.ComboBox CmbPerID;
        private System.Windows.Forms.ComboBox CmbEtkID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSinifSil;
        private System.Windows.Forms.Button BtnSinifKaydet;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private KindergartenDataSet4 kindergartenDataSet4;
        private System.Windows.Forms.BindingSource etkinlikBindingSource;
        private KindergartenDataSet4TableAdapters.etkinlikTableAdapter etkinlikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazanımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KindergartenDataSet5 kindergartenDataSet5;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private KindergartenDataSet5TableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn persidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private KindergartenDataSet6 kindergartenDataSet6;
        private System.Windows.Forms.BindingSource sinifBindingSource;
        private KindergartenDataSet6TableAdapters.sinifTableAdapter sinifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn persidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtID;
    }
}