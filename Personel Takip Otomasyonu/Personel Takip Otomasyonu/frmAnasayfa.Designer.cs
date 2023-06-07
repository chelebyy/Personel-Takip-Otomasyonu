namespace Personel_Takip_Otomasyonu
{
    partial class frmAnasayfa
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
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.Location = new System.Drawing.Point(27, 27);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(97, 57);
            this.btnDepartmanlar.TabIndex = 0;
            this.btnDepartmanlar.Text = "Birimler";
            this.btnDepartmanlar.UseVisualStyleBackColor = true;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(130, 27);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(97, 57);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(233, 27);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(102, 57);
            this.btnPersonelListele.TabIndex = 2;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.Location = new System.Drawing.Point(341, 27);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(102, 57);
            this.btnMesaiEkle.TabIndex = 3;
            this.btnMesaiEkle.Text = "MesaiEkle";
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.Location = new System.Drawing.Point(449, 27);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(102, 57);
            this.btnMesailer.TabIndex = 4;
            this.btnMesailer.Text = "Mesailer";
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 142);
            this.Controls.Add(this.btnMesailer);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnDepartmanlar);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnMesailer;
    }
}

