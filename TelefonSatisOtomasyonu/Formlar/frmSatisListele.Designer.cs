namespace TelefonSatisOtomasyonu.Formlar
{
    partial class frmSatisListele
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
            this.btnikiTarihArasi = new System.Windows.Forms.Button();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.btnAyGetir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateGunluk = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnYilGetir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYil2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkaAra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtUrunIDAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAylik = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnikiTarihArasi
            // 
            this.btnikiTarihArasi.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnikiTarihArasi.Location = new System.Drawing.Point(8, 71);
            this.btnikiTarihArasi.Name = "btnikiTarihArasi";
            this.btnikiTarihArasi.Size = new System.Drawing.Size(111, 34);
            this.btnikiTarihArasi.TabIndex = 2;
            this.btnikiTarihArasi.Text = "İki Tarih Arası";
            this.btnikiTarihArasi.UseVisualStyleBackColor = true;
            this.btnikiTarihArasi.Click += new System.EventHandler(this.btnikiTarihArasi_Click);
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(9, 9);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(111, 22);
            this.dateBaslangic.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnikiTarihArasi);
            this.panel4.Controls.Add(this.dateBitis);
            this.panel4.Controls.Add(this.dateBaslangic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(499, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 108);
            this.panel4.TabIndex = 2;
            // 
            // dateBitis
            // 
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(8, 41);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(111, 22);
            this.dateBitis.TabIndex = 0;
            // 
            // btnAyGetir
            // 
            this.btnAyGetir.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyGetir.Location = new System.Drawing.Point(34, 71);
            this.btnAyGetir.Name = "btnAyGetir";
            this.btnAyGetir.Size = new System.Drawing.Size(84, 34);
            this.btnAyGetir.TabIndex = 3;
            this.btnAyGetir.Text = "Ay Getir";
            this.btnAyGetir.UseVisualStyleBackColor = true;
            this.btnAyGetir.Click += new System.EventHandler(this.btnAyGetir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ay";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(34, 39);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(86, 22);
            this.txtYil.TabIndex = 0;
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(34, 11);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(86, 22);
            this.txtAy.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAyGetir);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtYil);
            this.panel5.Controls.Add(this.txtAy);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(664, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 108);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Günlük Filtreleme";
            // 
            // dateGunluk
            // 
            this.dateGunluk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGunluk.Location = new System.Drawing.Point(8, 50);
            this.dateGunluk.Name = "dateGunluk";
            this.dateGunluk.Size = new System.Drawing.Size(111, 22);
            this.dateGunluk.TabIndex = 0;
            this.dateGunluk.ValueChanged += new System.EventHandler(this.dateGunluk_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateGunluk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(334, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 108);
            this.panel3.TabIndex = 2;
            // 
            // btnYilGetir
            // 
            this.btnYilGetir.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYilGetir.Location = new System.Drawing.Point(20, 72);
            this.btnYilGetir.Name = "btnYilGetir";
            this.btnYilGetir.Size = new System.Drawing.Size(100, 34);
            this.btnYilGetir.TabIndex = 5;
            this.btnYilGetir.Text = "Yıl Getir";
            this.btnYilGetir.UseVisualStyleBackColor = true;
            this.btnYilGetir.Click += new System.EventHandler(this.btnYilGetir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yıl";
            // 
            // txtYil2
            // 
            this.txtYil2.Location = new System.Drawing.Point(20, 38);
            this.txtYil2.Name = "txtYil2";
            this.txtYil2.Size = new System.Drawing.Size(100, 22);
            this.txtYil2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka Ara";
            // 
            // txtMarkaAra
            // 
            this.txtMarkaAra.Location = new System.Drawing.Point(6, 54);
            this.txtMarkaAra.Name = "txtMarkaAra";
            this.txtMarkaAra.Size = new System.Drawing.Size(100, 22);
            this.txtMarkaAra.TabIndex = 0;
            this.txtMarkaAra.TextChanged += new System.EventHandler(this.txtMarkaAra_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMarkaAra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(169, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 108);
            this.panel2.TabIndex = 2;
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.Location = new System.Drawing.Point(3, 71);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(128, 37);
            this.btnHaftalik.TabIndex = 1;
            this.btnHaftalik.Text = "Bir Hafta Önce";
            this.btnHaftalik.UseVisualStyleBackColor = true;
            this.btnHaftalik.Click += new System.EventHandler(this.btnHaftalik_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHaftalik);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(994, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(166, 108);
            this.panel7.TabIndex = 2;
            // 
            // txtUrunIDAra
            // 
            this.txtUrunIDAra.Location = new System.Drawing.Point(15, 54);
            this.txtUrunIDAra.Name = "txtUrunIDAra";
            this.txtUrunIDAra.Size = new System.Drawing.Size(100, 22);
            this.txtUrunIDAra.TabIndex = 1;
            this.txtUrunIDAra.TextChanged += new System.EventHandler(this.txtUrunIDAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID Ara";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUrunIDAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 108);
            this.panel1.TabIndex = 2;
            // 
            // btnAylik
            // 
            this.btnAylik.Location = new System.Drawing.Point(3, 71);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(109, 34);
            this.btnAylik.TabIndex = 0;
            this.btnAylik.Text = "Bir Ay Önce";
            this.btnAylik.UseVisualStyleBackColor = true;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAylik);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1167, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(155, 108);
            this.panel8.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00378F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1326, 116);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnYilGetir);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtYil2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(829, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(158, 108);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 590);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmSatisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 706);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSatisListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmSatisListele_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnikiTarihArasi;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.Button btnAyGetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateGunluk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnYilGetir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYil2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarkaAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHaftalik;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtUrunIDAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}