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
    public partial class frmKullaniciListele : Form
    {
        public frmKullaniciListele()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        private void frmKullaniciListele_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            tel.Listele(dataGridView1, "Select * from Kullanici");
        }

        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            string sql = "Update Kullanici set AdiSoyadi='" + txtAdiSoyadi.Text + "',TelNo='" + txtTelefonNo.Text + "'," +
                "Adres='" + txtAdres.Text + "',Email='" + txtEmail.Text + "',KullaniciAdi='" + txtKullaniciAdi.Text + "'," +
                "Gorevi='" + txtGorevi.Text + "' Where Id=" + txtId.Text + "";
            OleDbCommand komut = new OleDbCommand();
            tel.ESG(komut, sql);
            Temizle();
            Listele();
        }
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydın silinmesini onaylıyor musunuz?","Silme Uyarısı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string sql = "Delete * from Kullanici Where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut = new OleDbCommand();
                tel.ESG(komut, sql);
                Temizle();
                Listele();
            }
          
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtAdiSoyadi.Text = dataGridView1.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            txtTelefonNo.Text = dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            txtGorevi.Text = dataGridView1.CurrentRow.Cells["Gorevi"].Value.ToString();
        }


    }
}
