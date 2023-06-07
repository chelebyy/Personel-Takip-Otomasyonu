namespace Personel_Takip_Otomasyonu
{
    partial class frmMesaiEkle
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
            this.comboPersonelAdSoyad = new System.Windows.Forms.ComboBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.txtizinSayisi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "İzin Sayısı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Açıklama :";
            // 
            // comboPersonelAdSoyad
            // 
            this.comboPersonelAdSoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPersonelAdSoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPersonelAdSoyad.FormattingEnabled = true;
            this.comboPersonelAdSoyad.Location = new System.Drawing.Point(115, 38);
            this.comboPersonelAdSoyad.Name = "comboPersonelAdSoyad";
            this.comboPersonelAdSoyad.Size = new System.Drawing.Size(198, 21);
            this.comboPersonelAdSoyad.TabIndex = 8;
            this.comboPersonelAdSoyad.SelectedIndexChanged += new System.EventHandler(this.comboPersonelAdSoyad_SelectedIndexChanged);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(115, 75);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(92, 20);
            this.dateTimeBaslangic.TabIndex = 9;
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(213, 76);
            this.maskedtxtBaslangic.Mask = "90:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBaslangic.TabIndex = 10;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(213, 112);
            this.maskedtxtBitis.Mask = "90:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBitis.TabIndex = 12;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(115, 112);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(92, 20);
            this.dateTimeBitis.TabIndex = 11;
            // 
            // txtizinSayisi
            // 
            this.txtizinSayisi.Location = new System.Drawing.Point(115, 150);
            this.txtizinSayisi.Name = "txtizinSayisi";
            this.txtizinSayisi.Size = new System.Drawing.Size(198, 20);
            this.txtizinSayisi.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(115, 187);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(198, 83);
            this.txtAciklama.TabIndex = 15;
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiEkle.Location = new System.Drawing.Point(156, 305);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMesaiEkle.TabIndex = 16;
            this.btnMesaiEkle.Text = "Ekle";
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Location = new System.Drawing.Point(238, 305);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 409);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtizinSayisi);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboPersonelAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekle";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPersonelAdSoyad;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.TextBox txtizinSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnCikis;
    }
}