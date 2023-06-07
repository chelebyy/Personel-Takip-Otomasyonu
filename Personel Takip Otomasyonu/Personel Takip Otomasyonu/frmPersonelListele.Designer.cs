namespace Personel_Takip_Otomasyonu
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.txtPersonelIDAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAdAra = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyadAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSicilAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSicil = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBirim = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.comboBirimler = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelIDAra
            // 
            this.txtPersonelIDAra.Location = new System.Drawing.Point(15, 25);
            this.txtPersonelIDAra.Name = "txtPersonelIDAra";
            this.txtPersonelIDAra.Size = new System.Drawing.Size(134, 20);
            this.txtPersonelIDAra.TabIndex = 0;
            this.txtPersonelIDAra.TextChanged += new System.EventHandler(this.txtPersonelIDAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PERSONEL ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AD:";
            // 
            // txtPersonelAdAra
            // 
            this.txtPersonelAdAra.Location = new System.Drawing.Point(174, 25);
            this.txtPersonelAdAra.Name = "txtPersonelAdAra";
            this.txtPersonelAdAra.Size = new System.Drawing.Size(134, 20);
            this.txtPersonelAdAra.TabIndex = 6;
            this.txtPersonelAdAra.TextChanged += new System.EventHandler(this.txtPersonelAdAra_TextChanged);
            // 
            // txtPersonelSoyadAra
            // 
            this.txtPersonelSoyadAra.Location = new System.Drawing.Point(333, 25);
            this.txtPersonelSoyadAra.Name = "txtPersonelSoyadAra";
            this.txtPersonelSoyadAra.Size = new System.Drawing.Size(134, 20);
            this.txtPersonelSoyadAra.TabIndex = 7;
            this.txtPersonelSoyadAra.TextChanged += new System.EventHandler(this.txtPersonelSoyadAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SİCİL:";
            // 
            // txtPersonelSicilAra
            // 
            this.txtPersonelSicilAra.Location = new System.Drawing.Point(492, 25);
            this.txtPersonelSicilAra.Name = "txtPersonelSicilAra";
            this.txtPersonelSicilAra.Size = new System.Drawing.Size(134, 20);
            this.txtPersonelSicilAra.TabIndex = 10;
            this.txtPersonelSicilAra.TextChanged += new System.EventHandler(this.txtPersonelSicilAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 329);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sicil :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Personel Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel Adı :";
            // 
            // txtSicil
            // 
            this.txtSicil.Location = new System.Drawing.Point(106, 475);
            this.txtSicil.Name = "txtSicil";
            this.txtSicil.Size = new System.Drawing.Size(182, 20);
            this.txtSicil.TabIndex = 12;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(106, 450);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(182, 20);
            this.txtSoyadi.TabIndex = 13;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(106, 425);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(182, 20);
            this.txtAdi.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Açıklama :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Birimi :";
            // 
            // comboBirim
            // 
            this.comboBirim.FormattingEnabled = true;
            this.comboBirim.Location = new System.Drawing.Point(375, 423);
            this.comboBirim.Name = "comboBirim";
            this.comboBirim.Size = new System.Drawing.Size(182, 21);
            this.comboBirim.TabIndex = 19;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(375, 450);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(181, 49);
            this.txtAciklama.TabIndex = 18;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 2;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(744, 453);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 46);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "diskette.png");
            this.ımageList1.Images.SetKeyName(2, "logout.png");
            this.ımageList1.Images.SetKeyName(3, "refresh.png");
            this.ımageList1.Images.SetKeyName(4, "trash.png");
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Location = new System.Drawing.Point(640, 420);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(148, 13);
            this.lblToplamPersonel.TabIndex = 24;
            this.lblToplamPersonel.Text = "Toplam 85 Personel Listelendi";
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 4;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(667, 453);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 46);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 3;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(575, 453);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 46);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Personel ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(106, 399);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(182, 20);
            this.txtPersonelID.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Telefon :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(374, 397);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(182, 20);
            this.txtTelefon.TabIndex = 29;
            // 
            // comboBirimler
            // 
            this.comboBirimler.FormattingEnabled = true;
            this.comboBirimler.Location = new System.Drawing.Point(680, 24);
            this.comboBirimler.Name = "comboBirimler";
            this.comboBirimler.Size = new System.Drawing.Size(121, 21);
            this.comboBirimler.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(725, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Birim";
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1402, 511);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBirimler);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblToplamPersonel);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBirim);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSicil);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPersonelSicilAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelSoyadAra);
            this.Controls.Add(this.txtPersonelAdAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelIDAra);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listeleme, Arama, Silme ve Güncelleme";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelIDAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAdAra;
        private System.Windows.Forms.TextBox txtPersonelSoyadAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSicilAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSicil;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBirim;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox comboBirimler;
        private System.Windows.Forms.Label label12;
    }
}