using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1,"select * from Mesailer");
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Personeller.PersonelAdSoyadGetir(txtPersonelID,txtAdiSoyadi);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["IzinKullanmaDurumu"].Value.ToString()=="Kullanmadı")
            {

            
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();           
            txtizinSayisi.Text = dataGridView1.CurrentRow.Cells["IzinSayisi"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

            string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
            string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
            dateTimeBaslangic.Text = baslangic.Substring(0,10);
            maskedtxtBaslangic.Text = baslangic.Substring(11);
            dateTimeBitis.Text = bitis.Substring(0, 10);
            maskedtxtBitis.Text = bitis.Substring(11);

            }





        }

        private void btnPersonelMesailer_Click(object sender, EventArgs e)
        {
            frmPersonelMesaileri frm = new frmPersonelMesaileri();
            frm.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }

            }
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
        }

        private void btnTumIzinleriKullan_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.IzinKullanmaDurumu = "Kullanıldı";

            string sql = "update Mesailer set IzinKullanmaDurumu='"+m.IzinKullanmaDurumu+"' where IzinKullanmaDurumu='Kullanmadı'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sql);
            MessageBox.Show("Kullanılmayan Tüm İzinler Kullanıldı", "İzin Kullanma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            Veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        private void btnIzinKullan_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.IzinKullanmaDurumu = "Kullanıldı";
            //m.MesaiID = int.Parse(txtMesaiID.Text);
            string sql = "update Mesailer set IzinKullanmaDurumu='" + m.IzinKullanmaDurumu + "'  where IzinKullanmaDurumu='Kullanmadı'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sql);
            MessageBox.Show("İzin Kullanıldı", "İzin Kullanma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            Veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            m.MesaiID = int.Parse(txtMesaiID.Text);


            if (MessageBox.Show("Bu Kayıt Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                

                string sql = "delete from Mesailer where MesaiID=" + m.MesaiID + "";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            MessageBox.Show(m.MesaiID + " Nolu Mesai Kaydı Silindi", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnTemizle.PerformClick();
            Veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Personeller p = new Personeller();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            m.MesaiID = int.Parse(txtMesaiID.Text);
            m.Baslangic_Saati1 = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
            m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
            m.IzinSayisi = txtizinSayisi.Text;
            m.Aciklama = txtAciklama.Text;
            string sql = "update Mesailer  set PersonelID='" + p.PersonelID + "',BaslangicSaati='" + m.Baslangic_Saati1 + "',BitisSaati='" + m.Bitis_Saati + "',IzinSayisi='" + m.IzinSayisi + "',Aciklama='" + m.Aciklama + "' where MesaiID='"+m.MesaiID+"'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sql);
            MessageBox.Show(m.MesaiID + " Nolu Kayıt Güncellendi", "Mesai Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
            Veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        private void txtMesaiID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Departman,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Adi like '%" + txtPersonelIDAra.Text + "%'");
            //Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Departman,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and PersonelID like '%" + txtPersonelIDAra.Text + "%'");
        }
    }

       
    }

