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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelSayfalar.Controls.Add(frm);
            frm.Show();

        }
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
        //    frmKullaniciGirisi frm=new frmKullaniciGirisi();
        //    frm.Show();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeni = new frmYeniKullanici();
            // FormGetir(yeni);
            yeni.ShowDialog();

        }

        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonEkle telekle = new Formlar.frmTelefonEkle();
            // FormGetir(telekle);
            telekle.ShowDialog();
        }

        private void btnTelefonListele_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonListele telliste = new Formlar.frmTelefonListele();
            FormGetir(telliste);
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMarkaEkle ekle = new Formlar.frmMarkaEkle();
            ekle.ShowDialog();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmModelEkle ekle = new Formlar.frmModelEkle();
            ekle.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) Application.Exit();
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            Formlar.frmKullaniciListele liste = new Formlar.frmKullaniciListele();
            FormGetir(liste);
        }

        private void UrunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonEkle telekle = new Formlar.frmTelefonEkle();
            //FormGetir(telekle);
            telekle.ShowDialog();

        }

        private void UrunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmTelefonListele liste = new Formlar.frmTelefonListele();
            FormGetir(liste);
        }

        private void KullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeni = new frmYeniKullanici();
            //  FormGetir(yeni);
            yeni.ShowDialog();

        }

        private void KullaniciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmKullaniciListele liste = new Formlar.frmKullaniciListele();
            FormGetir(liste);
        }

        private void MusteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriEkle ekle = new Formlar.frmMusteriEkle();
            // FormGetir(ekle);
            ekle.ShowDialog();

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriEkle ekle = new Formlar.frmMusteriEkle();
            // FormGetir(ekle);
            ekle.ShowDialog();

        }

        private void MusteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele listele = new Formlar.frmMusteriListele();
            FormGetir(listele);
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele listele = new Formlar.frmMusteriListele();
            FormGetir(listele);
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisYap satis = new Formlar.frmSatisYap();
            FormGetir(satis);
        }

        private void btnYapilanSatislar_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisListele listele = new Formlar.frmSatisListele();
            FormGetir(listele);
        }

        private void btnGrafik_Siralama_Click(object sender, EventArgs e)
        {
            Formlar.frmGrafikSiralama grph = new Formlar.frmGrafikSiralama();
            FormGetir(grph);
        }

        private void MarkaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmMarkaEkle ekle = new Formlar.frmMarkaEkle();
            ekle.ShowDialog();
        }

        private void ModelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmModelEkle ekle = new Formlar.frmModelEkle();
            ekle.ShowDialog();
        }

        private void SatisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisYap satis = new Formlar.frmSatisYap();
            FormGetir(satis);
        }

        private void YapilanSatislarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisListele listele = new Formlar.frmSatisListele();
            FormGetir(listele);
        }


        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) Application.Exit();
        }

      
    }
}
