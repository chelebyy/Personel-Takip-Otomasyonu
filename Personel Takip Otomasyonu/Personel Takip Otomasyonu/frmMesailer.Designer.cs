namespace Personel_Takip_Otomasyonu
{
    partial class frmMesailer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtizinSayisi = new System.Windows.Forms.TextBox();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.btnPersonelMesailer = new System.Windows.Forms.Button();
            this.btnTumIzinleriKullan = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIzinKullan = new System.Windows.Forms.Button();
            this.lblPersonelIDAra = new System.Windows.Forms.Label();
            this.txtPersonelIDAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(796, 495);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(198, 83);
            this.txtAciklama.TabIndex = 25;
            // 
            // txtizinSayisi
            // 
            this.txtizinSayisi.Location = new System.Drawing.Point(796, 458);
            this.txtizinSayisi.Name = "txtizinSayisi";
            this.txtizinSayisi.Size = new System.Drawing.Size(198, 20);
            this.txtizinSayisi.TabIndex = 24;
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(557, 495);
            this.maskedtxtBitis.Mask = "90:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBitis.TabIndex = 23;
            this.maskedtxtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(459, 495);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(92, 20);
            this.dateTimeBitis.TabIndex = 22;
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(557, 459);
            this.maskedtxtBaslangic.Mask = "90:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBaslangic.TabIndex = 21;
            this.maskedtxtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(459, 458);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(92, 20);
            this.dateTimeBaslangic.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "İzin Sayısı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bitiş Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Başlangıç Saati :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mesai ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Personel ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adı Soyadı :";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(138, 461);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(192, 20);
            this.txtMesaiID.TabIndex = 29;
            this.txtMesaiID.TextChanged += new System.EventHandler(this.txtMesaiID_TextChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(138, 487);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(192, 20);
            this.txtPersonelID.TabIndex = 30;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(138, 513);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(192, 20);
            this.txtAdiSoyadi.TabIndex = 31;
            // 
            // btnPersonelMesailer
            // 
            this.btnPersonelMesailer.Location = new System.Drawing.Point(28, 596);
            this.btnPersonelMesailer.Name = "btnPersonelMesailer";
            this.btnPersonelMesailer.Size = new System.Drawing.Size(124, 33);
            this.btnPersonelMesailer.TabIndex = 32;
            this.btnPersonelMesailer.Text = "Personel Mesaileri";
            this.btnPersonelMesailer.UseVisualStyleBackColor = true;
            this.btnPersonelMesailer.Click += new System.EventHandler(this.btnPersonelMesailer_Click);
            // 
            // btnTumIzinleriKullan
            // 
            this.btnTumIzinleriKullan.Location = new System.Drawing.Point(174, 596);
            this.btnTumIzinleriKullan.Name = "btnTumIzinleriKullan";
            this.btnTumIzinleriKullan.Size = new System.Drawing.Size(124, 33);
            this.btnTumIzinleriKullan.TabIndex = 33;
            this.btnTumIzinleriKullan.Text = "Tüm İzinleri Kullan";
            this.btnTumIzinleriKullan.UseVisualStyleBackColor = true;
            this.btnTumIzinleriKullan.Click += new System.EventHandler(this.btnTumIzinleriKullan_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(605, 596);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 33);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(459, 596);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 33);
            this.btnGuncelle.TabIndex = 35;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(751, 596);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(124, 33);
            this.btnTemizle.TabIndex = 36;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(897, 596);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(124, 33);
            this.btnCikis.TabIndex = 37;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIzinKullan
            // 
            this.btnIzinKullan.Location = new System.Drawing.Point(318, 596);
            this.btnIzinKullan.Name = "btnIzinKullan";
            this.btnIzinKullan.Size = new System.Drawing.Size(124, 33);
            this.btnIzinKullan.TabIndex = 38;
            this.btnIzinKullan.Text = "İzin Kullan";
            this.btnIzinKullan.UseVisualStyleBackColor = true;
            this.btnIzinKullan.Click += new System.EventHandler(this.btnIzinKullan_Click);
            // 
            // lblPersonelIDAra
            // 
            this.lblPersonelIDAra.AutoSize = true;
            this.lblPersonelIDAra.Location = new System.Drawing.Point(25, 544);
            this.lblPersonelIDAra.Name = "lblPersonelIDAra";
            this.lblPersonelIDAra.Size = new System.Drawing.Size(87, 13);
            this.lblPersonelIDAra.TabIndex = 39;
            this.lblPersonelIDAra.Text = "Personel ID Ara :";
            // 
            // txtPersonelIDAra
            // 
            this.txtPersonelIDAra.Location = new System.Drawing.Point(138, 541);
            this.txtPersonelIDAra.Name = "txtPersonelIDAra";
            this.txtPersonelIDAra.Size = new System.Drawing.Size(192, 20);
            this.txtPersonelIDAra.TabIndex = 40;
            this.txtPersonelIDAra.TextChanged += new System.EventHandler(this.txtPersonelIDAra_TextChanged);
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 641);
            this.Controls.Add(this.txtPersonelIDAra);
            this.Controls.Add(this.lblPersonelIDAra);
            this.Controls.Add(this.btnIzinKullan);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTumIzinleriKullan);
            this.Controls.Add(this.btnPersonelMesailer);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtizinSayisi);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesailer";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtizinSayisi;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Button btnPersonelMesailer;
        private System.Windows.Forms.Button btnTumIzinleriKullan;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnIzinKullan;
        private System.Windows.Forms.Label lblPersonelIDAra;
        private System.Windows.Forms.TextBox txtPersonelIDAra;
    }
}