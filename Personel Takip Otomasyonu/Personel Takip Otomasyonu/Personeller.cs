using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Personeller
    {

        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Sicil;
        private string _Telefon;
        private int _DepartmanID;
        private string __Aciklama;
        private string _Islem;


        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Sicil { get => _Sicil; set => _Sicil = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Aciklama { get => __Aciklama; set => __Aciklama = value; }
        public string Islem { get => _Islem; set => _Islem = value; }





        public static SqlDataReader PersonelAdSoyadGetir(TextBox txtPersonelID, TextBox txtAdSoyad)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personeller where PersonelID='" + txtPersonelID.Text + "'",Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr[1] + " " + dr[2];
            }

            Veritabani.baglanti.Close();
            return dr;


        }
        



        public static SqlDataReader ComboyaPersonelGetir(ComboBox cmb)
        {

            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr[1] + " " + dr[2] + " -" + dr[0] );

            }
            Veritabani.baglanti.Close();
            return dr;

        }

        public static SqlDataReader ComboSecilirsePersonelIdGetir(ComboBox combo,Label lbl_PersonelID)
        {

            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (combo.SelectedItem.ToString()== dr[1] + " " + dr[2] + " -" + dr[0])
                {
                    lbl_PersonelID.Text = dr[0].ToString();
                }
            }
            Veritabani.baglanti.Close();
            return dr;
        }
       

        public static int PersonelIDSonKayit(int PersonelID)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select ident_current('Personeller')", Veritabani.baglanti);
            int id = int.Parse(komut.ExecuteScalar().ToString());
            Veritabani.baglanti.Close();
            PersonelID = id;
            return id;



        }


        public static void PersonelislemEkle(Personeller p, Kullanicilar k)
        {

            k.KullaniciID = Kullanicilar.kid;
            string sql = "insert into Personelislemleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih )";
            SqlCommand komut = new SqlCommand();
            //komut.Parameters.Add("@Tarih",SqlDbType.Date).Value=p.Tarih;
            Veritabani.ESG(komut, sql);



        }

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Departmanlar",Veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";
            combo.DisplayMember = "Birim";
            Veritabani.baglanti.Close();
            return tbl;

        }
        public static DataTable ComboyaDepartmanGetir2(ComboBox combo2)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Departmanlar", Veritabani.baglanti);
            adtr.Fill(tbl);
            combo2.DataSource = tbl;
            combo2.ValueMember = "Birim";
            combo2.DisplayMember = "Birim";
            Veritabani.baglanti.Close();
            return tbl;

        }

    }
}
