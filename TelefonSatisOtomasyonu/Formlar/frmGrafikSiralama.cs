using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisOtomasyonu.Formlar
{
    public partial class frmGrafikSiralama : Form
    {
        public frmGrafikSiralama()
        {
            InitializeComponent();
        }
        Classlar.Grafik grph = new Classlar.Grafik();
        private void frmGrafikSiralama_Load(object sender, EventArgs e)
        {
            grph.Grafik_Siralama(dataGridView1, chart1, lblEnAz, lblEnCok);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
