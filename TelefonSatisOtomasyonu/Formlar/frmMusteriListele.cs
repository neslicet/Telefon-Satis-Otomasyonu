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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
     
        void KayitSayisi()
        {
            lblToplamKayit.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update Musteri set AdiSoyadi='" + txtAdiSoyadi.Text + "',Telefon='" + maskedTelefon.Text + "',Adres='" + txtAdres.Text + "',Email='" + txtEmail.Text + "' where Id=" + txtID.Text + "";
            OleDbCommand komut2 = new OleDbCommand();
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "select * from Musteri");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = "";

                if (item is MaskedTextBox) item.Text = "";


            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            tel.Listele(dataGridView1, "select * from Musteri where AdiSoyadi like '%" + txtAra.Text + "%'");
            KayitSayisi();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydın silinmesini onaylıyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu2 = "delete from Musteri where Id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                tel.ESG(komut2, sorgu2);
                tel.Listele(dataGridView1, "select * from Musteri");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox) item.Text = "";

                    if (item is MaskedTextBox) item.Text = "";

                }
                KayitSayisi();
            }
        }
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            tel.Listele(dataGridView1, "select * from Musteri");
            txtID.DataBindings.Add("text", tel.tbl, "Id");
            txtAdiSoyadi.DataBindings.Add("text", tel.tbl, "AdiSoyadi");
            maskedTelefon.DataBindings.Add("text", tel.tbl, "Telefon");
            txtAdres.DataBindings.Add("text", tel.tbl, "Adres");
            txtEmail.DataBindings.Add("text", tel.tbl, "Email");
            KayitSayisi();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
