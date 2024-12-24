using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TelefonSatisOtomasyonu.Classlar
{
    public class Telefon
    {
        OleDbConnection baglanti = new OleDbConnection(Veritabani.strbaglanti);
        public bool durum;
        public bool MarkaKontrol(TextBox marka)
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from TBLMarka", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["marka"].ToString() == marka.Text || marka.Text == "") durum = false;

            }
            baglanti.Close();
            return durum;

        }
        public bool ModelKontrol(ComboBox marka, TextBox model)
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from TBLModel", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["markaid"].ToString() == marka.SelectedValue.ToString() && dr["model"].ToString() == model.Text || marka.Text == "" || model.Text == "") durum = false;

            }
            baglanti.Close();
            return durum;

        }
        public DataTable tbl = new DataTable();


        public DataTable Listele(DataGridView dgrid, string sorgu)
        {
            tbl.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;
            return tbl;
        }
        ComboBox _marka;
        public DataTable MarkaListele(ComboBox marka, string sorgu)
        {
            DataTable tbl2 = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tbl2);
            marka.ValueMember = "Id";
            marka.DisplayMember = "Marka";
            marka.DataSource = tbl2;
            return tbl2;
        }
        public DataTable ModelListele(ComboBox model, string sorgu)
        {
            DataTable tbl3 = new DataTable();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tbl3);
            model.ValueMember = "Id";
            model.DisplayMember = "Model";
            model.DataSource = tbl3;
            return tbl3;

        }

        public void MarkaGetir(ComboBox marka)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Select * from TBLMarka", baglanti);
            OleDbDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                marka.Items.Add(dr["Marka"].ToString());
            }
            baglanti.Close();
        }

        public bool TelefonKontrol(TextBox txtserino, TextBox txtimeino)
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Urun", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["serino"].ToString() == txtserino.Text || dr["imeino"].ToString() == txtimeino.Text || txtserino.Text == "" || txtimeino.Text == "")
                    durum = false;

            }
            baglanti.Close();
            return durum;

        }
        public void TelefonMarkaAra(DataGridView grid, ComboBox cmbmarka)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from urun where marka='" + cmbmarka.Text + "'", baglanti);
            adtr.Fill(tbl);
            grid.DataSource = tbl;

        }
        public void TelefonAra(DataGridView grid, TextBox txtara)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from urun where serino like '%" + txtara.Text + "%' or imeino like '%" + txtara.Text + "%'", baglanti);
            adtr.Fill(tbl);
            grid.DataSource = tbl;

        }

        public int ESG(OleDbCommand komut, string sorgu)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            try
            {
                sonuc = komut.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally
            {
                baglanti.Close();
            }
            return sonuc;

        }

    }
}
