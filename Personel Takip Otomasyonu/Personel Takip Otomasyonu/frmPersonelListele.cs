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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }
        
        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            
            Personeller.ComboyaDepartmanGetir(comboBirimler);
            YenileListele();
            
        }

        private void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID");
            lblToplamPersonel.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " Kayıt Listelendi.";



        }
        void Temizle()

        {

            comboBirim.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();


        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Sicil = txtSicil.Text;
            p.Telefon = txtTelefon.Text;
            p.DepartmanID = (int)comboBirim.SelectedValue;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "update personeller set adi='" + p.Adi + "',soyadi='" + p.Soyadi + "',sicil='" + p.Sicil + "',departmanID='" + p.DepartmanID + "',aciklama='" + p.Aciklama + "'" +
                "where personelID='" + p.PersonelID + "'";
            SqlCommand komut = new SqlCommand();
            
            Veritabani.ESG(komut,sorgu);
            //p.Islem = p.PersonelID + " nolu personelin bilgileri güncellendi";
            //p.Aciklama = "Personel Güncelleme";
            //Personeller.PersonelislemEkle(p,k);

            Temizle();
            MessageBox.Show("İşlem Başarılı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            Personeller p = new Personeller();
            p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sorgu2 = "delete from personeller where PersonelID='" + p.PersonelID + "'";
            SqlCommand komut2 = new SqlCommand();
            Veritabani.ESG(komut2, sorgu2);

            //p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //
            //SqlCommand komut = new SqlCommand();
            //Veritabani.ESG(komut, sorgu);
            //string sorgu2 = "update personeller set durumu='Pasif where personelID='" + p.PersonelID + "'";
            //
            //
            //p.Islem = p.PersonelID + " nolu perso";
            //Personeller.PersonelislemEkle(p, k);


            Temizle();
            MessageBox.Show("İşlem Başarılı", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSicil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1,"select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and PersonelID like '%"+txtPersonelIDAra.Text+"%'");
        }

        private void txtPersonelAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Adi like '%" + txtPersonelAdAra.Text + "%'");
        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Soyadi like '%" + txtPersonelSoyadAra.Text + "%'");
        }

        private void txtPersonelSicilAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Sicil like '%" + txtPersonelSicilAra.Text + "%'");
        }



        private void comboBirimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Birim,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Birim='"+comboBirimler.Text+"'");
        }




    }
}
