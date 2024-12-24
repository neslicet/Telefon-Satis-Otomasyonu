namespace TelefonSatisOtomasyonu.Formlar
{
    partial class frmGrafikSiralama
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEnAz = new System.Windows.Forms.Label();
            this.lblEnCok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunID,
            this.Toplam});
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(363, 128);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "Ürün ID";
            this.UrunID.MinimumWidth = 6;
            this.UrunID.Name = "UrunID";
            // 
            // Toplam
            // 
            this.Toplam.DataPropertyName = "Column1";
            this.Toplam.HeaderText = "Toplam Adet";
            this.Toplam.MinimumWidth = 6;
            this.Toplam.Name = "Toplam";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Satış Adetleri";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(367, 162);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblEnAz
            // 
            this.lblEnAz.AutoSize = true;
            this.lblEnAz.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblEnAz.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEnAz.Location = new System.Drawing.Point(201, 335);
            this.lblEnAz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnAz.Name = "lblEnAz";
            this.lblEnAz.Size = new System.Drawing.Size(133, 24);
            this.lblEnAz.TabIndex = 5;
            this.lblEnAz.Text = "En Az Satılan";
            // 
            // lblEnCok
            // 
            this.lblEnCok.AutoSize = true;
            this.lblEnCok.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblEnCok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnCok.Location = new System.Drawing.Point(4, 335);
            this.lblEnCok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnCok.Name = "lblEnCok";
            this.lblEnCok.Size = new System.Drawing.Size(148, 24);
            this.lblEnCok.TabIndex = 6;
            this.lblEnCok.Text = "En Çok Satılan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(201, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "En Az Satılan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "En Çok Satılan";
            // 
            // frmGrafikSiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblEnAz);
            this.Controls.Add(this.lblEnCok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrafikSiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik İşlemleri";
            this.Load += new System.EventHandler(this.frmGrafikSiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblEnAz;
        private System.Windows.Forms.Label lblEnCok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}