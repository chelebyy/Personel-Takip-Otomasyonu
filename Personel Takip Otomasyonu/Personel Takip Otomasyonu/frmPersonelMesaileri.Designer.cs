namespace Personel_Takip_Otomasyonu
{
    partial class frmPersonelMesaileri
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
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesailer = new System.Windows.Forms.DataGridView();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.txtSoyadAra = new System.Windows.Forms.TextBox();
            this.txtBirimAra = new System.Windows.Forms.TextBox();
            this.comboBirimAra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(561, 635);
            this.dataGridViewPersoneller.TabIndex = 0;
            this.dataGridViewPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellClick);
            // 
            // dataGridViewMesailer
            // 
            this.dataGridViewMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesailer.Location = new System.Drawing.Point(567, 0);
            this.dataGridViewMesailer.Name = "dataGridViewMesailer";
            this.dataGridViewMesailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesailer.Size = new System.Drawing.Size(685, 496);
            this.dataGridViewMesailer.TabIndex = 1;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(772, 528);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(1103, 516);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(119, 13);
            this.lblKayitSayisi.TabIndex = 2;
            this.lblKayitSayisi.Text = "Toplam 25 kayıt eklendi";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(584, 528);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(567, 544);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(140, 20);
            this.txtAdAra.TabIndex = 4;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(940, 528);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(29, 13);
            this.lblBirim.TabIndex = 2;
            this.lblBirim.Text = "Birim";
            // 
            // txtSoyadAra
            // 
            this.txtSoyadAra.Location = new System.Drawing.Point(726, 544);
            this.txtSoyadAra.Name = "txtSoyadAra";
            this.txtSoyadAra.Size = new System.Drawing.Size(147, 20);
            this.txtSoyadAra.TabIndex = 4;
            // 
            // txtBirimAra
            // 
            this.txtBirimAra.Location = new System.Drawing.Point(879, 544);
            this.txtBirimAra.Name = "txtBirimAra";
            this.txtBirimAra.Size = new System.Drawing.Size(168, 20);
            this.txtBirimAra.TabIndex = 4;
            // 
            // comboBirimAra
            // 
            this.comboBirimAra.FormattingEnabled = true;
            this.comboBirimAra.Location = new System.Drawing.Point(879, 580);
            this.comboBirimAra.Name = "comboBirimAra";
            this.comboBirimAra.Size = new System.Drawing.Size(168, 21);
            this.comboBirimAra.TabIndex = 5;
            // 
            // frmPersonelMesaileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.comboBirimAra);
            this.Controls.Add(this.txtBirimAra);
            this.Controls.Add(this.txtSoyadAra);
            this.Controls.Add(this.txtAdAra);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.dataGridViewMesailer);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Name = "frmPersonelMesaileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Mesaileri";
            this.Load += new System.EventHandler(this.frmPersonelMesaileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.DataGridView dataGridViewMesailer;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.TextBox txtSoyadAra;
        private System.Windows.Forms.TextBox txtBirimAra;
        private System.Windows.Forms.ComboBox comboBirimAra;
    }
}