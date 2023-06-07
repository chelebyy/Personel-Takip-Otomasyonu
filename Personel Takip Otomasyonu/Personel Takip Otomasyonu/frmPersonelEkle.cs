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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboBirim);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
        Kullanicilar k = new Kullanicilar();
        Personeller p = new Personeller();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Sicil = txtSicil.Text;
            p.Telefon = txtTelefon.Text;
            p.DepartmanID =(int) comboBirim.SelectedValue;
            p.Aciklama = txtAciklama.Text;
            //k.KullaniciID = Kullanicilar.kid;

            string sorgu = "insert into Personeller(Adi,Soyadi,Sicil,Telefon,DepartmanID,Aciklama) values('"+p.Adi+ "','"+p.Soyadi+"','"+p.Sicil+ "','" + p.Telefon + "','" + p.DepartmanID+"','"+p.Aciklama+"')";

            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sorgu);
            //Personeller.PersonelIDSonKayit(p.PersonelID);
            //p.Islem = p.PersonelID + " nolu yeni personel kaydı oluşturuldu";
            //p.Aciklama = "Yeni personel ekleme";
            //Personeller.PersonelislemEkle(p, k);

            Temizle();
            MessageBox.Show("İşlem Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




