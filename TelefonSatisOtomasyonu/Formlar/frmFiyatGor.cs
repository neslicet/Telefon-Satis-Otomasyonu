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
    public partial class frmFiyatGor : Form
    {
        public frmFiyatGor()
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
    }
}
