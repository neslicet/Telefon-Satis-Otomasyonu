using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;

namespace TelefonSatisOtomasyonu.Classlar
{
    public class Grafik
    {
        OleDbConnection baglanti = new OleDbConnection(Veritabani.strbaglanti);
        DataSet dset = new DataSet();

        public void Grafik_Siralama(DataGridView dgrid, Chart chart, Label lblAz, Label lblCok)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select urunID,sum(Miktari) from satis group by GROUPING sets(UrunID) order by sum(Miktari) desc", baglanti);
            adtr.Fill(dset, "satis");
            dgrid.DataSource = dset.Tables["satis"];
            baglanti.Close();
            lblAz.Text = "";
            lblCok.Text = "";
            lblAz.Text = "Ürün ID=" + dgrid.Rows[dgrid.Rows.Count - 2].Cells[0].Value + " \ntoplamda " + dgrid.Rows[dgrid.Rows.Count - 2].Cells[1].Value + " tane satıldı";
            lblCok.Text = "Ürün ID=" + dgrid.Rows[0].Cells[0].Value + " \ntoplamda " + dgrid.Rows[0].Cells[1].Value + " tane satıldı";
            for (int i = 0; i < dgrid.Rows.Count - 1; i++)
            {
                chart.Series["Satış Adetleri"].Points.AddXY(dgrid.Rows[i].Cells[0].Value.ToString(), dgrid.Rows[i].Cells[1].Value.ToString());
            }
        }
    }
}
