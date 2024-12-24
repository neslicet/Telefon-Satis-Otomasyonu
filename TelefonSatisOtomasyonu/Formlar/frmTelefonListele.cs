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
    public partial class frmTelefonListele : Form
    {
        public frmTelefonListele()
        {
            InitializeComponent();
        }

        private void frmTelefonListele_Load(object sender, EventArgs e)
        {
            tel.MarkaGetir(comboMarkaAra);
            tel.Listele(dataGridView1, "Select * from Urun");
            tel.MarkaListele(comboMarka, "Select * from TBLMarka");
            Hesapla();
        }

        void Hesapla()
        {
            double geneltutar = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double miktari = double.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString());
                double alisfiyati = double.Parse(dataGridView1.Rows[i].Cells["AlisFiyati"].Value.ToString());
                double tutar = miktari * alisfiyati;
                geneltutar += tutar;
            }
            lblToplamMaliyet.Text = "Toplam Maliyet=" + geneltutar.ToString("C2");
            lblToplamKayitSayisi.Text = (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
        }
     
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            comboMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            comboModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txtSeriNo.Text = dataGridView1.CurrentRow.Cells["SeriNo"].Value.ToString();
            txtImeiNo.Text = dataGridView1.CurrentRow.Cells["imeiNo"].Value.ToString();
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
            txtKDV.Text = dataGridView1.CurrentRow.Cells["KDV"].Value.ToString();
            txtIslemci.Text = dataGridView1.CurrentRow.Cells["islemci"].Value.ToString();
            txtIsletimSistemi.Text = dataGridView1.CurrentRow.Cells["isletimSistemi"].Value.ToString();
            txtHafiza.Text = dataGridView1.CurrentRow.Cells["Hafiza"].Value.ToString();
            txtCozunurluk.Text = dataGridView1.CurrentRow.Cells["Cozunurluk"].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells["Renk"].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["Resim"].Value.ToString();
            txtMiktari.Text = dataGridView1.CurrentRow.Cells["Miktari"].Value.ToString();

        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = file.FileName;
        }



        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set UretimTarihi=@uretimtarihi,AlisTarihi=@alistarihi, Marka='" + comboMarka.Text + "',Model='" + comboModel.Text + "',AlisFiyati=@alisfiyati,satisfiyati=@satisfiyati,Miktari=" + int.Parse(txtMiktari.Text) + " where Id=" + txtID.Text + "";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@uretimtarihi", dateUretim.Text);
            komut2.Parameters.AddWithValue("@alistarihi", dateGelis.Text);
            komut2.Parameters.AddWithValue("@alisfiyati", double.Parse(txtSatisFiyati.Text));
            komut2.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatisFiyati.Text));
            
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "Select * from Urun");
            Hesapla();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from urun where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value + "";
            OleDbCommand komut2 = new OleDbCommand();
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "Select * from Urun");
            Hesapla();
        }

        private void txtTelefonMarkaAra_TextChanged(object sender, EventArgs e)
        {
            tel.TelefonAra(dataGridView1, txtSeriNoImei);
        }

        private void txtSeriNoImei_Click(object sender, EventArgs e)
        {
            txtSeriNoImei.Text = "";
        }

        private void btnMiktarEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set Miktari=Miktari+1 Where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
            OleDbCommand komut2 = new OleDbCommand();
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "Select * from Urun");
            Hesapla();
        }
        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            tel.ModelListele(comboModel, "Select * from TBLModel where MarkaId=" + comboMarka.SelectedValue + "");
        }

        private void comboMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            //tel.ModelListele(comboModel, "Select * from TBLModel where MarkaId=" + comboMarka.SelectedValue + "");
        }

        private void comboMarkaAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            tel.TelefonMarkaAra(dataGridView1, comboMarkaAra);
        }

        private void txtSeriNoImei_TextChanged(object sender, EventArgs e)
        {
            tel.TelefonAra(dataGridView1, txtSeriNoImei);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
