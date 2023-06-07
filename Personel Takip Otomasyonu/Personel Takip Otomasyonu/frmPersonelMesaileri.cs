using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmPersonelMesaileri : Form
    {
        public frmPersonelMesaileri()
        {
            InitializeComponent();
        }

        private void frmPersonelMesaileri_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewPersoneller, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,d.Birim from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID");
        }

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string PersonelID = dataGridViewPersoneller.CurrentRow.Cells[0].Value.ToString();
            Veritabani.Listele_Ara(dataGridViewMesailer,"select * from Mesailer where PersonelID='"+PersonelID+"'");
            lblKayitSayisi.Text = "Toplam "+(dataGridViewMesailer.Rows.Count - 1)+" kayıt listelendi";
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewPersoneller,"select * from Personeller where Adi like '"+txtAdAra.Text+"'");
            //Veritabani.Listele_Ara(dataGridViewMesailer, "select * from Personeller where Soyadi like '" + txtSoyadAra.Text + "'");
            //Veritabani.Listele_Ara(dataGridViewMesailer, "select * from Departmanlar where Departman like '" + txtBirimAra.Text + "'");
            //Veritabani.Listele_Ara(dataGridViewPersoneller, "select p.PersonelID,p.Adi,p.Soyadi,p.Sicil,p.Telefon,d.Departman,p.Durumu,p.Aciklama from Personeller p, Departmanlar d  where p.DepartmanID = d.DepartmanID and Adi like '%" + txtAdAra.Text + "%'");

        }
    }
}
