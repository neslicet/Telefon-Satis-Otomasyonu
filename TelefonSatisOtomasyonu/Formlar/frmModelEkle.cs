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
    public partial class frmModelEkle : Form
    {
        public frmModelEkle()
        {
            InitializeComponent();
        }
        Classlar.Telefon tel = new Classlar.Telefon();
        void Yenile()
        {
            string sql = "SELECT TBLModel.Id,TBLModel.MarkaId,TBLMarka.Marka,TBLModel.Model FROM TBLMarka  INNER JOIN TBLModel   ON TBLMarka.Id = TBLModel.MarkaId;";
            tel.MarkaListele(comboMarka, "Select * from TBLMarka");
            tel.Listele(dataGridView1, sql);
            dataGridView1.Columns[1].Visible = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = "";
            }
        }
        private void frmModelEkle_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tel.ModelKontrol(comboMarka, txtModel);
            if (tel.durum == true)
            {
                string sorgu2 = "insert into TBLModel(MarkaId,Model) values (@MarkaId,'" + txtModel.Text + "')";
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Parameters.AddWithValue("@MarkaId", comboMarka.SelectedValue);
                tel.ESG(komut2, sorgu2);
                Yenile();
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt bulunmaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update TBLModel set MarkaId=@MarkaId,Model='" + txtModel.Text + "' where Id=" + txtId.Text + "";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@MarkaId",comboMarka.SelectedValue);
            tel.ESG(komut2, sorgu2);
            tel.Listele(dataGridView1, "select * from TBLMarka");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            Yenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydın silinmesini onaylıyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu2 = "delete from TBLModel where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                tel.ESG(komut2, sorgu2);
                Yenile();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            comboMarka.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();

        }
    }
}
