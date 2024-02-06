using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nursimaakbas221701008bpgorselfinalodevi
{
    public partial class Form2grf : Form
    {
        public Form2grf()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ISQETAEN; Initial Catalog=Eczane; Integrated Security=True");

        private void Form2grf_Load(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    baglanti.Open();
            SqlCommand komut = new SqlCommand("Select UrunAd,Fiyat From ilacsistemi1",baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Satış"].Points.AddXY(reader[0].ToString(), reader[1].ToString());
            }
            baglanti.Close();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1();
            frm.Show();
            this.Hide();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris hst= new hastagiris();
            hst.Show();
            this.Hide();
        }

        private void ilaçStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu stk= new stokkontrolu();
            stk.Show();
            this.Hide();
        }

        private void ilaçDışıÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Ilacdisiurunsatisi lcd= new Ilacdisiurunsatisi();
            lcd.Show();
            this.Hide();
        }

        private void ilaçBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacbilgi lcb= new frmIlacbilgi();
            lcb.Show();
            this.Hide();
        }

        private void reçeteBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi rct= new frmreceteturbilgi();
            rct.Show();
            this.Hide();
        }

        private void hastaKayıtKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastakayıtkontrol hsg=new hastakayıtkontrol();
            hsg.Show();
            this.Hide();
        }
    }
}
