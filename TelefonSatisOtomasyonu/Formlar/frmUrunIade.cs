using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisOtomasyonu.Formlar
{
    public partial class frmUrunIade : Form
    {
        public frmUrunIade()
        {
            InitializeComponent();
        }
        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();
        private void txtSeriNoAra_TextChanged(object sender, EventArgs e)
        {
            if (txtSeriNoAra.Text == "")
            {
                foreach (Control item in Controls) if (item is TextBox) item.Text = ""; txtMiktari.Text = "1";
            }

            OleDbCommand komut2 = new OleDbCommand();
            satis.FiyatGor_UrunIade(komut2, txtSeriNoAra, txtUrunID, txtMarka, txtImeiNo, txtBirimFiyati, txtMiktari, txtToplamFiyati);

        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtBirimFiyati.Text) * double.Parse(txtMiktari.Text)).ToString("0.00");
            }
            catch
            {

            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update Urun set Miktari=Miktari+" + int.Parse(txtMiktari.Text) + " where SeriNo='" + txtSeriNoAra.Text + "'";
            OleDbCommand komut2 = new OleDbCommand();
            satis.ESG(komut2, sorgu2);

            string sorgu3 = "insert into Satis(MusteriID,AdiSoyadi,Telefon,UrunID,Marka,Model,SeriNo,ImeiNo,BirimFiyati,Miktari,ToplamFiyati,KDV,islemci,isletimsistemi,SepetID,Tarih,Saat) " +
                " values(-1,'Genel','Bilinmiyor'," + txtUrunID.Text + ",'" + txtMarka.Text + "','Belirtilmedi','" + txtSeriNoAra.Text + "'" +
                ",'" + txtImeiNo.Text + "',@birimfiyati,@miktari,@toplamfiyati,20,'Belirtilmedi'" +
                ",'Belirtilmedi',-1,@tarih,@saat)";
            OleDbCommand komut3 = new OleDbCommand();
            komut3.Parameters.AddWithValue("@birimfiyati", double.Parse(txtBirimFiyati.Text));
            komut3.Parameters.AddWithValue("@miktari", -int.Parse(txtMiktari.Text));

            komut3.Parameters.AddWithValue("@toplamfiyati", -double.Parse(txtToplamFiyati.Text));
            komut3.Parameters.AddWithValue("@tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
            komut3.Parameters.AddWithValue("@saat", DateTime.Parse(DateTime.Now.ToString()));
            satis.ESG(komut3, sorgu3);
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; txtMiktari.Text = "1";

        }
        private void frmUrunIade_Load(object sender, EventArgs e)
        {

        }
    }
}
