namespace nursimaakbas221701008bpgorselfinalodevi
{
    partial class stokkontrolu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokkontrolu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtEtken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbRecete = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sayfalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçDışıÜrünKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçYanEtkileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUzanti = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 443);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(85, 45);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(186, 22);
            this.txtBarkod.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(85, 89);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(186, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(85, 130);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(186, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtEtken
            // 
            this.txtEtken.Location = new System.Drawing.Point(445, 42);
            this.txtEtken.Name = "txtEtken";
            this.txtEtken.Size = new System.Drawing.Size(186, 22);
            this.txtEtken.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(289, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Etken Madde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(295, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reçete Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat:";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnYeniKayit.ForeColor = System.Drawing.Color.Black;
            this.btnYeniKayit.Location = new System.Drawing.Point(711, 43);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(167, 25);
            this.btnYeniKayit.TabIndex = 13;
            this.btnYeniKayit.Text = "Yeni Kayıt Ekle";
            this.btnYeniKayit.UseVisualStyleBackColor = false;
            this.btnYeniKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuncel.ForeColor = System.Drawing.Color.Black;
            this.btnGuncel.Location = new System.Drawing.Point(711, 84);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(167, 23);
            this.btnGuncel.TabIndex = 14;
            this.btnGuncel.Text = "Kayıt Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = false;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(711, 130);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(167, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // cmbRecete
            // 
            this.cmbRecete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecete.FormattingEnabled = true;
            this.cmbRecete.Location = new System.Drawing.Point(445, 83);
            this.cmbRecete.Name = "cmbRecete";
            this.cmbRecete.Size = new System.Drawing.Size(186, 24);
            this.cmbRecete.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayfalarToolStripMenuItem,
            this.ilaçBilgileriToolStripMenuItem,
            this.reçeteBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sayfalarToolStripMenuItem
            // 
            this.sayfalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.hastaKayıtKontrolToolStripMenuItem,
            this.ilaçDışıÜrünKontrolToolStripMenuItem,
            this.hastaGirişiToolStripMenuItem,
            this.grafikToolStripMenuItem});
            this.sayfalarToolStripMenuItem.Name = "sayfalarToolStripMenuItem";
            this.sayfalarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sayfalarToolStripMenuItem.Text = "Sayfalar";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.anaSayfaToolStripMenuItem.Text = "Ana sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // hastaKayıtKontrolToolStripMenuItem
            // 
            this.hastaKayıtKontrolToolStripMenuItem.Name = "hastaKayıtKontrolToolStripMenuItem";
            this.hastaKayıtKontrolToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hastaKayıtKontrolToolStripMenuItem.Text = "Hasta Kayıt Kontrol";
            this.hastaKayıtKontrolToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtKontrolToolStripMenuItem_Click);
            // 
            // ilaçDışıÜrünKontrolToolStripMenuItem
            // 
            this.ilaçDışıÜrünKontrolToolStripMenuItem.Name = "ilaçDışıÜrünKontrolToolStripMenuItem";
            this.ilaçDışıÜrünKontrolToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ilaçDışıÜrünKontrolToolStripMenuItem.Text = "İlaç Dışı Ürün Kontrol";
            this.ilaçDışıÜrünKontrolToolStripMenuItem.Click += new System.EventHandler(this.ilaçDışıÜrünKontrolToolStripMenuItem_Click);
            // 
            // hastaGirişiToolStripMenuItem
            // 
            this.hastaGirişiToolStripMenuItem.Name = "hastaGirişiToolStripMenuItem";
            this.hastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hastaGirişiToolStripMenuItem.Text = "Hasta Girişi";
            this.hastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.hastaGirişiToolStripMenuItem_Click);
            // 
            // grafikToolStripMenuItem
            // 
            this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            this.grafikToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.grafikToolStripMenuItem.Text = "Grafik";
            this.grafikToolStripMenuItem.Click += new System.EventHandler(this.grafikToolStripMenuItem_Click);
            // 
            // ilaçBilgileriToolStripMenuItem
            // 
            this.ilaçBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçYanEtkileriToolStripMenuItem});
            this.ilaçBilgileriToolStripMenuItem.Name = "ilaçBilgileriToolStripMenuItem";
            this.ilaçBilgileriToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.ilaçBilgileriToolStripMenuItem.Text = "İlaç bilgileri";
            // 
            // ilaçYanEtkileriToolStripMenuItem
            // 
            this.ilaçYanEtkileriToolStripMenuItem.Name = "ilaçYanEtkileriToolStripMenuItem";
            this.ilaçYanEtkileriToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.ilaçYanEtkileriToolStripMenuItem.Text = "İlaç Yan etkileri";
            this.ilaçYanEtkileriToolStripMenuItem.Click += new System.EventHandler(this.ilaçYanEtkileriToolStripMenuItem_Click);
            // 
            // reçeteBilgileriToolStripMenuItem
            // 
            this.reçeteBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morToolStripMenuItem});
            this.reçeteBilgileriToolStripMenuItem.Name = "reçeteBilgileriToolStripMenuItem";
            this.reçeteBilgileriToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.reçeteBilgileriToolStripMenuItem.Text = "Reçete Bilgileri";
            // 
            // morToolStripMenuItem
            // 
            this.morToolStripMenuItem.Name = "morToolStripMenuItem";
            this.morToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.morToolStripMenuItem.Text = "Reçete Bilgi Sistemi";
            this.morToolStripMenuItem.Click += new System.EventHandler(this.morToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Resim Uzantısı:";
            // 
            // txtUzanti
            // 
            this.txtUzanti.Location = new System.Drawing.Point(445, 127);
            this.txtUzanti.Name = "txtUzanti";
            this.txtUzanti.Size = new System.Drawing.Size(186, 22);
            this.txtUzanti.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stokkontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(890, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUzanti);
            this.Controls.Add(this.cmbRecete);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtEtken);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stokkontrolu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stokkontrolu";
            this.Load += new System.EventHandler(this.stokkontrolu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtEtken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cmbRecete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sayfalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçDışıÜrünKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçYanEtkileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUzanti;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişiToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem grafikToolStripMenuItem;
    }
}