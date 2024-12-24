using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisOtomasyonu.Formlar
{
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }
        Classlar.Kullanici k = new Classlar.Kullanici();

        private void frmYeniKullanici_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            k.YeniKullanici(txtAdiSoyadi.Text, txtTelefonNo.Text, txtAdres.Text, txtEmail.Text, txtKullaniciAdi.Text, txtSifre.Text, txtSifreTekrar.Text, txtGorevi.Text, pictureBoxResim.ImageLocation);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            pictureBoxResim.ImageLocation = file.FileName;
        }
    }
}
