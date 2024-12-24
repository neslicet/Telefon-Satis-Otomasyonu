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
using TelefonSatisOtomasyonu.Classlar;

namespace TelefonSatisOtomasyonu.Formlar
{
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }
        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();
        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satis.Listele(dataGridView1, "select * from Satis");
        }

        private void txtUrunIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunIDAra.Text == "")
            {
                satis.Listele(dataGridView1, "select * from Satis");
                return;
            }
            satis.Listele(dataGridView1, "select * from Satis where UrunID like '" + txtUrunIDAra.Text + "'");
        }

        private void txtMarkaAra_TextChanged(object sender, EventArgs e)
        {
            satis.Listele(dataGridView1, "select * from Satis where Marka like '%" + txtMarkaAra.Text + "%'");
        }

        private void dateGunluk_ValueChanged(object sender, EventArgs e)
        {
            GunlukFiltrele();
        }


        private void btnAyGetir_Click(object sender, EventArgs e)
        {
            satis.Listele(dataGridView1, "select * from Satis where month(Tarih)='" + txtAy.Text + "' and year(Tarih)='" + txtYil.Text + "' ");

        }

        private void btnYilGetir_Click(object sender, EventArgs e)
        {
            satis.Listele(dataGridView1, "select * from Satis where year(Tarih)='" + txtYil2.Text + "'");
        }


        private void btnAylik_Click(object sender, EventArgs e)
        {
            satis.Listele(dataGridView1, "select * from Satis where Tarih between Date() and Date()-30");

        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            //Between Date() and Date()-6
            satis.Listele(dataGridView1, "select * from Satis where Tarih between Date() and Date()-6");

        }
        OleDbConnection baglanti = new OleDbConnection(Veritabani.strbaglanti);
        DataTable dt = new DataTable();
        void GunlukFiltrele()
        {
            dt.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Satis Where Tarih=@Tarih", baglanti);
            adtr.SelectCommand.Parameters.AddWithValue("@Tarih", dateGunluk.Value.ToShortDateString());
           
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void ikiTarihArasiFiltrele()
        {
            dt.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from Satis Where Tarih between @Tarih1 and @Tarih2", baglanti);
            adtr.SelectCommand.Parameters.AddWithValue("@Tarih1", dateBaslangic.Value.ToShortDateString());
            adtr.SelectCommand.Parameters.AddWithValue("@Tarih2", dateBitis.Value.ToShortDateString());
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btnikiTarihArasi_Click(object sender, EventArgs e)
        {
            ikiTarihArasiFiltrele();
        }


    }
}
