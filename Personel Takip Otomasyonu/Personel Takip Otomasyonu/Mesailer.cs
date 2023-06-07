using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Takip_Otomasyonu
{
    class Mesailer
    {
        #region Mesai Kapsülleme
        private int _MesaiID;
        private string Baslangic_Saati;
        private string _Bitis_Saati;
        private string _IzinSayisi;
        private string _IzinKullanmaDurumu;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Adi;
        private string _Soyadi;
       

        public int MesaiID { get => _MesaiID; set => _MesaiID = value; }       
        public string Bitis_Saati { get => _Bitis_Saati; set => _Bitis_Saati = value; }
        public string IzinSayisi { get => _IzinSayisi; set => _IzinSayisi = value; }
        public string IzinKullanmaDurumu { get => _IzinKullanmaDurumu; set => _IzinKullanmaDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Baslangic_Saati1 { get => Baslangic_Saati; set => Baslangic_Saati = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        #endregion



    }


}
