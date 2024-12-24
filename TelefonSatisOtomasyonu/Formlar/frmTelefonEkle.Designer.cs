namespace TelefonSatisOtomasyonu.Formlar
{
    partial class frmTelefonEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonEkle));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtCozunurluk = new System.Windows.Forms.TextBox();
            this.txtHafiza = new System.Windows.Forms.TextBox();
            this.txtIslemci = new System.Windows.Forms.TextBox();
            this.txtIsletimSistemi = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "telefonekle2.jpg");
            this.ımageList1.Images.SetKeyName(1, "ekle.jpg");
            this.ımageList1.Images.SetKeyName(2, "iptal4.jpg");
            this.ımageList1.Images.SetKeyName(3, "ResimSec.jpg");
            this.ımageList1.Images.SetKeyName(4, "telefonekle.jpg");
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(91, 189);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(126, 20);
            this.txtMiktari.TabIndex = 45;
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.White;
            this.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimSec.ImageKey = "ResimSec.jpg";
            this.btnResimSec.ImageList = this.ımageList1;
            this.btnResimSec.Location = new System.Drawing.Point(230, 119);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(100, 37);
            this.btnResimSec.TabIndex = 44;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(230, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.White;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "iptal4.jpg";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(153, 349);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(63, 37);
            this.btnIptal.TabIndex = 42;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "telefonekle.jpg";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(91, 349);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 37);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Renk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Hafıza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "İşletim Sistemi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Miktarı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "KDV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Çözünürlük";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Geliş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "İşlemci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Üretim Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Imei No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marka";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(91, 323);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(126, 20);
            this.txtRenk.TabIndex = 25;
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(91, 300);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(126, 20);
            this.txtCozunurluk.TabIndex = 24;
            // 
            // txtHafiza
            // 
            this.txtHafiza.Location = new System.Drawing.Point(91, 278);
            this.txtHafiza.Name = "txtHafiza";
            this.txtHafiza.Size = new System.Drawing.Size(126, 20);
            this.txtHafiza.TabIndex = 23;
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(91, 234);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(126, 20);
            this.txtIslemci.TabIndex = 22;
            // 
            // txtIsletimSistemi
            // 
            this.txtIsletimSistemi.Location = new System.Drawing.Point(91, 256);
            this.txtIsletimSistemi.Name = "txtIsletimSistemi";
            this.txtIsletimSistemi.Size = new System.Drawing.Size(126, 20);
            this.txtIsletimSistemi.TabIndex = 21;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(91, 212);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(126, 20);
            this.txtKDV.TabIndex = 20;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(91, 167);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(126, 20);
            this.txtSatisFiyati.TabIndex = 19;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(91, 144);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(126, 20);
            this.txtAlisFiyati.TabIndex = 18;
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(91, 122);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(126, 20);
            this.dateGelis.TabIndex = 17;
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(91, 100);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(126, 20);
            this.dateUretim.TabIndex = 16;
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(91, 78);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(126, 20);
            this.txtImeiNo.TabIndex = 15;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(91, 56);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(126, 20);
            this.txtSeriNo.TabIndex = 14;
            // 
            // comboModel
            // 
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(91, 33);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(126, 21);
            this.comboModel.TabIndex = 13;
            this.comboModel.ValueMember = "Id";
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(91, 11);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(126, 21);
            this.comboMarka.TabIndex = 12;
            this.comboMarka.ValueMember = "Id";
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // frmTelefonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 399);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtCozunurluk);
            this.Controls.Add(this.txtHafiza);
            this.Controls.Add(this.txtIslemci);
            this.Controls.Add(this.txtIsletimSistemi);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.dateGelis);
            this.Controls.Add(this.dateUretim);
            this.Controls.Add(this.txtImeiNo);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboMarka);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTelefonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmTelefonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtCozunurluk;
        private System.Windows.Forms.TextBox txtHafiza;
        private System.Windows.Forms.TextBox txtIslemci;
        private System.Windows.Forms.TextBox txtIsletimSistemi;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.ComboBox comboMarka;
    }
}