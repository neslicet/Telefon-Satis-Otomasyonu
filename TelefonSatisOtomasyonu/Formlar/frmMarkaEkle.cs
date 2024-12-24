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
    public partial class frmMarkaEkle : Form
    {
        public frmMarkaEkle()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tel.MarkaKontrol(txtMarka);
            if (tel.durum == true)
            {
                string sorgu2 = "insert into TBLMarka(Marka) values('" + txtMarka.Text + "')";
                OleDbCommand komut2 = new OleDbCommand();
                tel.ESG(komut2, sorgu2);
                tel.Listele(dataGridView1, "select * from TBLMarka");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox) item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Böyle bir marka bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmMarkaEkle_Load(object sender, EventArgs e)
        {
            tel.Listele(dataGridView1, "select * from TBLMarka");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            string sorgu2 = "update TBLMarka set Marka='" + txtMarka.Text + "' where Id=" + txtId.Text + "";
            OleDbCommand komut2 = new OleDbCommand();
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "select * from TBLMarka");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydın silinmesini onaylıyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu2 = "delete from TBLMarka where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                tel.ESG(komut2, sorgu2);
                tel.Listele(dataGridView1, "select * from TBLMarka");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox) item.Text = "";

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
        }
    }
}
