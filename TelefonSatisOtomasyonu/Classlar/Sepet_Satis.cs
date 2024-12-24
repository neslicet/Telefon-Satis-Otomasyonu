using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisOtomasyonu.Classlar
{
    public class Sepet_Satis
    {
        OleDbConnection baglanti = new OleDbConnection(Veritabani.strbaglanti);
        public bool durum;
        public void SepetteVarMi(TextBox serino)
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sepet", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["serino"].ToString() == serino.Text) durum = false;
            }
            baglanti.Close();
        }

        public OleDbDataReader FiyatGor_UrunIade(OleDbCommand komut, TextBox serino, TextBox urunid, TextBox marka, TextBox imeino, TextBox birimfiyati
           , TextBox miktari, TextBox toplamfiyati)
        {
            string sorgu = "select * from urun where serino='" + serino.Text + "'";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                urunid.Text = dr["Id"].ToString();
                marka.Text = dr["Marka"].ToString();
                imeino.Text = dr["imeino"].ToString();
                birimfiyati.Text = dr["SatisFiyati"].ToString();

                double miktar = double.Parse(miktari.Text);
                double birimfiyat = double.Parse(birimfiyati.Text);
                double toplamfiyat = miktar * birimfiyat;
                toplamfiyati.Text = toplamfiyat.ToString("0.00");

            }
            baglanti.Close();
            return dr;
        }

        public OleDbDataReader MusteriIDAra(OleDbCommand komut, TextBox musteriid, TextBox adisoyadi, TextBox telefon, TextBox email)
        {
            string sorgu = "select * from Musteri where Id=" + musteriid.Text + "";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adisoyadi.Text = dr["AdiSoyadi"].ToString();
                telefon.Text = dr["Telefon"].ToString();
                email.Text = dr["Email"].ToString();
            }
            baglanti.Close();
            return dr;
        }

        public OleDbDataReader SeriNoAra(OleDbCommand komut, TextBox serino, TextBox urunid, TextBox marka, TextBox model, TextBox imeino, TextBox birimfiyati
        , TextBox miktari, TextBox toplamfiyati, TextBox kdv, TextBox islemci, TextBox isletimsistemi, TextBox cozunurluk)
        {
            string sorgu = "select * from Urun where SeriNo='" + serino.Text + "'";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                urunid.Text = dr["Id"].ToString();
                marka.Text = dr["Marka"].ToString();
                model.Text = dr["Model"].ToString();
                imeino.Text = dr["imeino"].ToString();
                birimfiyati.Text = dr["SatisFiyati"].ToString();
                kdv.Text = dr["KDV"].ToString();
                islemci.Text = dr["islemci"].ToString();
                isletimsistemi.Text = dr["isletimsistemi"].ToString();
                cozunurluk.Text = dr["Cozunurluk"].ToString();
                double miktar = double.Parse(miktari.Text);
                double birimfiyat = double.Parse(birimfiyati.Text);
                double toplamfiyat = miktar * birimfiyat;
                toplamfiyati.Text = toplamfiyat.ToString("0.00");

            }
            baglanti.Close();
            return dr;
        }

        public DataTable Listele(DataGridView dgrid, string sorgu)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;
            return tbl;
        }


        public int SepeteEkle(OleDbCommand komut, string sorgu, TextBox txtserino)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            try
            {
                sonuc = komut.ExecuteNonQuery();
                txtserino.Text = "";
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
                txtserino.Focus();
            }
            return sonuc;

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


        public void SatisYap(DataGridView dgrid)
        {
            try
            {
                for (int i = 0; i < dgrid.Rows.Count - 1; i++)
                {
                    int MusteriID = int.Parse(dgrid.Rows[i].Cells["MusteriId"].Value.ToString());
                    string AdiSoyadi = dgrid.Rows[i].Cells["AdiSoyadi"].Value.ToString();
                    string Telefon = dgrid.Rows[i].Cells["Telefon"].Value.ToString();
                    int UrunID = int.Parse(dgrid.Rows[i].Cells["UrunID"].Value.ToString());
                    string Marka = dgrid.Rows[i].Cells["Marka"].Value.ToString();
                    string Model = dgrid.Rows[i].Cells["Model"].Value.ToString();
                    string SeriNo = dgrid.Rows[i].Cells["SeriNo"].Value.ToString();
                    string ImeiNo = dgrid.Rows[i].Cells["ImeiNo"].Value.ToString();
                    double BirimFiyati = double.Parse(dgrid.Rows[i].Cells["BirimFiyati"].Value.ToString());
                    int Miktari = int.Parse(dgrid.Rows[i].Cells["Miktari"].Value.ToString());
                    double ToplamFiyati = double.Parse(dgrid.Rows[i].Cells["ToplamFiyati"].Value.ToString());
                    int KDV = int.Parse(dgrid.Rows[i].Cells["KDV"].Value.ToString());
                    string Islemci = dgrid.Rows[i].Cells["Islemci"].Value.ToString();
                    string IsletimSistemi = dgrid.Rows[i].Cells["IsletimSistemi"].Value.ToString();
                    int SepetID = int.Parse(dgrid.Rows[i].Cells["Id"].Value.ToString());

                    string sorgu = "insert into Satis(MusteriID,AdiSoyadi,Telefon,UrunID,Marka,Model,SeriNo,ImeiNo,BirimFiyati,Miktari,ToplamFiyati,KDV,islemci,isletimsistemi,SepetID,Tarih,Saat) " +
                        " values(" + MusteriID + ",'" + AdiSoyadi + "','" + Telefon + "'," + UrunID
                        + ",'" + Marka + "','" + Model + "','" + SeriNo + "','" + ImeiNo + "',@birimfiyati,'"
                        + Miktari + "',@toplamfiyati,'" + KDV + "','" + Islemci + "','" + IsletimSistemi + "'," + SepetID + ", @tarih,@saat)";
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@birimfiyati", BirimFiyati);
                    komut.Parameters.AddWithValue("@toplamfiyati", ToplamFiyati);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
                    komut.Parameters.AddWithValue("@saat", DateTime.Parse(DateTime.Now.ToString()));

                    if (baglanti.State == System.Data.ConnectionState.Closed)
                        baglanti.Open();
                    komut.ExecuteNonQuery();
                    OleDbCommand komut3 = new OleDbCommand("update urun set Miktari=Miktari-" + Miktari + " where Id=" + UrunID + "", baglanti);
                    komut3.ExecuteNonQuery();

                }
                OleDbCommand komut2 = new OleDbCommand("delete * from Sepet", baglanti);
                komut2.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata=" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
