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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaPersonelGetir(comboPersonelAdSoyad);
        }

        Label lbl;
        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            Personeller.ComboSecilirsePersonelIdGetir(comboPersonelAdSoyad,lbl);
            MessageBox.Show(lbl.Text);


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            
            Personeller p = new Personeller();
            Mesailer m = new Mesailer();
            p.PersonelID = int.Parse(lbl.Text);
                  
            m.Baslangic_Saati1 = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
            m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
            m.IzinSayisi = txtizinSayisi.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;
            string sql = "insert into Mesailer(PersonelID,BaslangicSaati,BitisSaati,IzinSayisi,Aciklama)values('"+p.PersonelID+ "','" + m.Baslangic_Saati1 + "','" + m.Bitis_Saati + "','" + m.IzinSayisi + "','" + m.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            //komut.Parameters.Add("Tarih", SqlDbType.Date).Value = m.Tarih;
          
            Veritabani.ESG(komut,sql);
            MessageBox.Show("Mesai Bilgileri Eklendi", "Mesailer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
