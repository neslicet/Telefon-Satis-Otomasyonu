using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisOtomasyonu.Formlar
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into Musteri(AdiSoyadi,Telefon,Adres,Email) values('" + txtAdiSoyadi.Text + "','" + maskedTelefon.Text + "','" + txtAdres.Text + "','" + txtEmail.Text + "')";
            OleDbCommand komut2 = new OleDbCommand();
            tel.ESG(komut2, sorgu2);
        }
        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
