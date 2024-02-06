using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nursimaakbas221701008bpgorselfinalodevi
{
    public partial class frmreceteturbilgi : Form
    {
        public frmreceteturbilgi()
        {
            InitializeComponent();
        }

        private void frmreceteturbilgi_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Beyaz Reçete";
            tabPage2.Text = "Yeşil Reçete";
            tabPage3.Text = "Kırmızı Reçete";
            tabPage4.Text = "Turuncu Reçete";
            tabPage5.Text = "Mor Reçete";
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hsf = new Form1();
            hsf.Show();
            this.Hide();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris hsg = new hastagiris();
            hsg.Show();
            this.Hide();
        }

        private void ilaçStokKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu stk=new stokkontrolu();
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
            frmIlacbilgi fblg =new frmIlacbilgi();
            fblg.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2grf grf= new Form2grf();
            grf.Show();
            this.Hide();
        }
    }
}
