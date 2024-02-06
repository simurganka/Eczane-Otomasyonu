namespace nursimaakbas221701008bpgorselfinalodevi
{
    partial class Form2grf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2grf));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sayfalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçDışıÜrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "Satış";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Satış";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Satış";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(931, 505);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Satis";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sayfalarToolStripMenuItem
            // 
            this.sayfalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.hastaGirişToolStripMenuItem,
            this.ilaçStokToolStripMenuItem,
            this.ilaçDışıÜrünToolStripMenuItem,
            this.ilaçBilgiToolStripMenuItem,
            this.reçeteBilgiToolStripMenuItem,
            this.hastaKayıtKontrolToolStripMenuItem});
            this.sayfalarToolStripMenuItem.Name = "sayfalarToolStripMenuItem";
            this.sayfalarToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.sayfalarToolStripMenuItem.Text = "Sayfalar";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // hastaGirişToolStripMenuItem
            // 
            this.hastaGirişToolStripMenuItem.Name = "hastaGirişToolStripMenuItem";
            this.hastaGirişToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.hastaGirişToolStripMenuItem.Text = "Hasta Giriş";
            this.hastaGirişToolStripMenuItem.Click += new System.EventHandler(this.hastaGirişToolStripMenuItem_Click);
            // 
            // ilaçStokToolStripMenuItem
            // 
            this.ilaçStokToolStripMenuItem.Name = "ilaçStokToolStripMenuItem";
            this.ilaçStokToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ilaçStokToolStripMenuItem.Text = "İlaç Stok";
            this.ilaçStokToolStripMenuItem.Click += new System.EventHandler(this.ilaçStokToolStripMenuItem_Click);
            // 
            // ilaçDışıÜrünToolStripMenuItem
            // 
            this.ilaçDışıÜrünToolStripMenuItem.Name = "ilaçDışıÜrünToolStripMenuItem";
            this.ilaçDışıÜrünToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ilaçDışıÜrünToolStripMenuItem.Text = "İlaç Dışı Ürün";
            this.ilaçDışıÜrünToolStripMenuItem.Click += new System.EventHandler(this.ilaçDışıÜrünToolStripMenuItem_Click);
            // 
            // ilaçBilgiToolStripMenuItem
            // 
            this.ilaçBilgiToolStripMenuItem.Name = "ilaçBilgiToolStripMenuItem";
            this.ilaçBilgiToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.ilaçBilgiToolStripMenuItem.Text = "İlaç Bilgi";
            this.ilaçBilgiToolStripMenuItem.Click += new System.EventHandler(this.ilaçBilgiToolStripMenuItem_Click);
            // 
            // reçeteBilgiToolStripMenuItem
            // 
            this.reçeteBilgiToolStripMenuItem.Name = "reçeteBilgiToolStripMenuItem";
            this.reçeteBilgiToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.reçeteBilgiToolStripMenuItem.Text = "Reçete Bilgi";
            this.reçeteBilgiToolStripMenuItem.Click += new System.EventHandler(this.reçeteBilgiToolStripMenuItem_Click);
            // 
            // hastaKayıtKontrolToolStripMenuItem
            // 
            this.hastaKayıtKontrolToolStripMenuItem.Name = "hastaKayıtKontrolToolStripMenuItem";
            this.hastaKayıtKontrolToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.hastaKayıtKontrolToolStripMenuItem.Text = "Hasta Kayıt Kontrol";
            this.hastaKayıtKontrolToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtKontrolToolStripMenuItem_Click);
            // 
            // Form2grf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2grf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Grafiği";
            this.Load += new System.EventHandler(this.Form2grf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sayfalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçDışıÜrünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtKontrolToolStripMenuItem;
    }
}