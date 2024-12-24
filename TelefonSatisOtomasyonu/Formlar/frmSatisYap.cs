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
    public partial class frmSatisYap : Form
    {
        public frmSatisYap()
        {
            InitializeComponent();
        }

        private void frmSatisYap_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriIDAra.Text = "";
            txtSeriNoAra.Text = "";
        }
        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();
        TextBox telefontxt = new TextBox();
        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriIDAra.Text == "")
            {
                foreach (Control item in this.panelMusteri.Controls) if (item is TextBox) item.Text = "";

            }
            else
            {
                OleDbCommand komut2 = new OleDbCommand();
                satis.MusteriIDAra(komut2, txtMusteriIDAra, txtAdiSoyadi, telefontxt, txtEmail);
            }

        }

        private void txtSeriNoAra_TextChanged(object sender, EventArgs e)
        {
            if (txtSeriNoAra.Text == "")
            {
                foreach (Control item in this.panelUrun.Controls) if (item is TextBox) item.Text = "";
                txtMiktari.Text = "1";

            }
            OleDbCommand komut2 = new OleDbCommand();
            satis.SeriNoAra(komut2, txtSeriNoAra, txtUrunID, txtMarka, txtModel, txtImeiNo, txtBirimFiyati, txtMiktari, txtToplamFiyati, txtKDV, txtIslemci, txtIsletimSistemi, txtCozunurluk);
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double toplamfiyat = double.Parse(txtMiktari.Text) * double.Parse(txtBirimFiyati.Text);
                txtToplamFiyati.Text = toplamfiyat.ToString("0.00");
            }
            catch
            {

            }
        }
        private void Yenile()
        {
            satis.Listele(dataGridView1, "select * from Sepet");
            lblKayitSayisi.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
            double tutar = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                tutar += double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString());

            }
            lblToplamTutar.Text = tutar.ToString();

            double geneltutarkdv = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                double toplamfiyati = double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString());
                double kdv = double.Parse(dataGridView1.Rows[i].Cells["KDV"].Value.ToString());
                double kdvtutar = toplamfiyati * kdv / 100;
                geneltutarkdv += kdvtutar;
            }
            lblKDV.Text = geneltutarkdv.ToString("C2");

        }
        public void fiyatSifirla()
        {
            lblToplamTutar.Text = "0";
            txtOdenen.Text = "0";
            txtParaUstu.Text = "0";
            lblKDV.Text = "0";
        }


        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            satis.SepetteVarMi(txtSeriNoAra);
            if (satis.durum == true)
            {
                string sorgu2 = "insert into Sepet(MusteriID,AdiSoyadi,Telefon,Marka,Model,SeriNo,ImeiNo,BirimFiyati,Miktari,ToplamFiyati,KDV,Islemci,IsletimSistemi,UrunID) " +
                    "values(" + txtMusteriIDAra.Text + ",'" + txtAdiSoyadi.Text + "','" + telefontxt.Text + "','"
                      + txtMarka.Text + "','" + txtModel.Text +
                      "','" + txtSeriNoAra.Text + "','" + txtImeiNo.Text + "',@birimfiyati,"
                      + int.Parse(txtMiktari.Text) + ",@toplamfiyati," + int.Parse(txtKDV.Text) + ",'" + txtIslemci.Text + "','" + txtIsletimSistemi.Text + "'," + int.Parse(txtUrunID.Text) + ")";

                OleDbCommand komut2 = new OleDbCommand();
                komut2.Parameters.AddWithValue("@birimfiyati", double.Parse(txtBirimFiyati.Text));
                komut2.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyati.Text));
                satis.SepeteEkle(komut2, sorgu2, txtSeriNoAra);
            }
            else
            {
                string sorgu3 = "update Sepet set Miktari=Miktari+" + int.Parse(txtMiktari.Text) + ",Toplamfiyati=Birimfiyati*(Miktari+" + int.Parse(txtMiktari.Text) + ") Where SeriNo='" + txtSeriNoAra.Text + "'";
                OleDbCommand komut3 = new OleDbCommand();
                satis.ESG(komut3, sorgu3);
                txtSeriNoAra.Text = "";
            }
            Yenile();
        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tutar = 0, odenen;
                tutar = double.Parse(lblToplamTutar.Text);
                odenen = double.Parse(txtOdenen.Text);

                double paraustu = odenen - tutar;
                txtParaUstu.Text = paraustu.ToString("C2");
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string sorgu2 = "delete  from Sepet where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                satis.ESG(komut2, sorgu2);
                Yenile();
            }
            else if (e.ColumnIndex == 1)
            {
                string sorgu2 = "update Sepet set Miktari=Miktari+1 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                satis.ESG(komut2, sorgu2);
                string sorgu3 = "update Sepet set ToplamFiyati=BirimFiyati*Miktari where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut3 = new OleDbCommand();
                satis.ESG(komut3, sorgu3);
                Yenile();
            }
            else if (e.ColumnIndex == 2)
            {
                string sorgu2 = "update Sepet set Miktari=Miktari-1 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut2 = new OleDbCommand();
                satis.ESG(komut2, sorgu2);
                string sorgu3 = "update Sepet set ToplamFiyati=BirimFiyati*Miktari where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "";
                OleDbCommand komut3 = new OleDbCommand();
                satis.ESG(komut3, sorgu3);
                Yenile();
            }
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from Sepet";
            OleDbCommand komut2 = new OleDbCommand();
            satis.ESG(komut2, sorgu2);
            Yenile();
        }

        private void frmSatisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                comboOdemeTuru.SelectedIndex = 0;

            }
            if (e.KeyCode == Keys.F2)
            {
                comboOdemeTuru.SelectedIndex = 1;

            }
            if (e.KeyCode == Keys.F3)
            {
                comboOdemeTuru.SelectedIndex = 0;
            }
            if (e.KeyCode == Keys.F4)
            {
                btnSatisOnay.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnSatisIptal.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                btnMusteriBorcu.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                btnUrunIade.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                btnFiyatGor.PerformClick();
            }
        }

        private void btnSatisOnay_Click(object sender, EventArgs e)
        {
            satis.SatisYap(dataGridView1);
            Yenile();
            txtOdenen.Text = "0";
            txtSeriNoAra.Focus();
        }

        private void comboOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboOdemeTuru.SelectedIndex == 1)
            {
                txtOdenen.Text = lblToplamTutar.Text;
            }
            txtOdenen.Focus();
        }

        private void btnUrunIade_Click(object sender, EventArgs e)
        {
            Formlar.frmUrunIade iade = new frmUrunIade();
            iade.Show();
        }

        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            Formlar.frmFiyatGor fiyat = new frmFiyatGor();
            fiyat.Show();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int height=dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap=new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }
        int satirsayisi = 1;
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(bitmap,0,0);
            //try
            //{
            //    Font font = new Font("Arial", 20);
            //    SolidBrush firca = new SolidBrush(Color.Black);
            //    Pen kalem = new Pen(Color.Black);

            //    e.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " +
            //            "" + DateTime.Now.ToLongTimeString(), font, firca, 50, 25);
            //    e.Graphics.DrawLine(kalem, 50, 65, 770, 65);
            //    e.Graphics.DrawLine(kalem, 50, 1000, 50, 65);

            //    e.Graphics.DrawLine(kalem, 50, 1000, 770, 1000);
            //    e.Graphics.DrawLine(kalem, 770, 1000, 770, 65);
            //    ////////////////////////////////////////////////////
            //    font = new Font("Arial", 20, FontStyle.Bold);
            //    e.Graphics.DrawString("Ürün Listesi", font, firca, 350, 75);
            //    e.Graphics.DrawLine(kalem, 50, 110, 770, 110);

            //    font = new Font("Arial", 15, FontStyle.Bold);
            //    e.Graphics.DrawString("Sıra", font, firca, 60, 118);
            //    e.Graphics.DrawString("Marka", font, firca, 130, 118);
            //    e.Graphics.DrawString("Seri No", font, firca, 240, 118);
            //    e.Graphics.DrawString("Birim fiyat", font, firca, 350, 118);
            //    e.Graphics.DrawString("Miktar", font, firca, 500, 118);
            //    e.Graphics.DrawString("Toplam Fiyat", font, firca, 610, 118);
            //    e.Graphics.DrawLine(kalem, 50, 150, 770, 150);
            //    ////////////////////////////////////////////////////////
            //    e.Graphics.DrawString("Ödenen=" + txtOdenen.Text + "  TL", font, firca, 60, 1025);
            //    e.Graphics.DrawString("Paraüstü=" + txtParaUstu.Text + "  TL", font, firca, 60, 1065);
            //    e.Graphics.DrawString("Genel Toplam=" + lblToplamTutar.Text + "  TL", font, firca, 480, 1065);
            //    /////////////////////////////////////////////////////////
              

            //    font = new Font("Arial", 15);
            //    int y = 160;
            //    int i = 0;
            //    while (i <= dataGridView1.Rows.Count - 2)
            //    {
            //        e.Graphics.DrawString((i + 1) + ".", font, firca, 60, y);
            //        e.Graphics.DrawString(dataGridView1[7, i].Value.ToString(), font, firca, 130, y);
            //        e.Graphics.DrawString(dataGridView1[9, i].Value.ToString(), font, firca, 250, y);
            //        e.Graphics.DrawString(dataGridView1[11, i].Value.ToString(), font, firca, 360, y);
            //        e.Graphics.DrawString(dataGridView1[12, i].Value.ToString(), font, firca, 510, y);
            //        e.Graphics.DrawString(dataGridView1[13, i].Value.ToString(), font, firca, 620, y);
            //        y = y + 25;
            //        i = i + 1;

            //        if (y > 200)
            //        {
            //            e.Graphics.DrawString("Devamı Diğer Sayfada---->", font, firca, 700, y + 50);
            //            y = 50;
            //            break;

            //        }
            //    }
            //    if (i < satirsayisi)
            //    {
            //        e.HasMorePages = true;
            //    }
            //    else
            //    {
            //        e.HasMorePages = false;
            //        i = 0;
            //    }


            //    StringFormat strformat = new StringFormat();
            //    strformat.Alignment = StringAlignment.Far;
            //    return;

            //}
            //catch
            //{
            //    ;

            //}
        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {

            //Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            //uyg.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            //Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
            //    range.Value2 = dataGridView1.Columns[i].HeaderText;
            //}
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Rows.Count; j++)
            //    {
            //        Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
            //        range.Value2 = dataGridView1[i, j].Value;
            //        sayfa.Columns["L:L"].NumberFormat = "0,00";
            //        sayfa.Columns["N:N"].NumberFormat = "0,00";

            //    }
            //}


        }


    }
}
