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
    public partial class frmTelefonEkle : Form
    {
        public frmTelefonEkle()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void frmTelefonEkle_Load(object sender, EventArgs e)
        {
            tel.MarkaListele(comboMarka, "Select * from TBLMarka");
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tel.TelefonKontrol(txtSeriNo, txtImeiNo);
            if (tel.durum == true)
            {
                string sorgu2 = "insert into Urun(Marka,Model,SeriNo,imeiNo,UretimTarihi,AlisTarihi,AlisFiyati,SatisFiyati,KDV,islemci,isletimSistemi,Hafiza,Cozunurluk,Renk,Resim,Miktari) " +
                    " values('" + comboMarka.Text + "','" + comboModel.Text + "','" + txtSeriNo.Text + "','"
                + txtImeiNo.Text + "',@uretimtarihi,@alistarihi,@alisfiyati,@satisfiyati,@KDV,'" + txtIslemci.Text + "','" + txtIsletimSistemi.Text + "','" + txtHafiza.Text + "','" + txtCozunurluk.Text +
                "','" + txtRenk.Text + "','" + pictureBox1.ImageLocation + "',@Miktari)";
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Parameters.AddWithValue("@uretimtarihi",dateUretim.Text);
                komut2.Parameters.AddWithValue("@alistarihi", dateGelis.Text);
                komut2.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlisFiyati.Text));
                komut2.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
                komut2.Parameters.AddWithValue("@KDV", txtKDV.Text);
                komut2.Parameters.AddWithValue("@Miktari", txtMiktari.Text);
                tel.ESG(komut2, sorgu2);
            }
            else
            {
                MessageBox.Show("İmeino ve/veya serino eşit olamaz.!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            tel.ModelListele(comboModel, "Select * from TBLModel Where MarkaId=" + comboMarka.SelectedValue + "");
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
