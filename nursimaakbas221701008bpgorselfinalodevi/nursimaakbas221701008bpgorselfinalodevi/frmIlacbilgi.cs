using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nursimaakbas221701008bpgorselfinalodevi
{
    public partial class frmIlacbilgi : Form
    {
        public frmIlacbilgi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sayfalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hs1= new Form1();
            hs1.Show();
            this.Hide();
        }

        private void ilaçStokBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu stk=new stokkontrolu();
            stk.Show();
            this.Hide();
        }

        private void hastaKayıtBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastakayıtkontrol hstk= new hastakayıtkontrol();
            hstk.Show();
            this.Hide();
        }

        private void ilaçDışıÜrünBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilacdisiurunsatisi lcd=new Ilacdisiurunsatisi();
            lcd.Show();
           this.Hide();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris hstk= new hastagiris();
            hstk.Show();
            this.Hide();
        }

        private void reçeteBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi frr= new frmreceteturbilgi();
            frr.Show();
            this.Hide();
        }

        private void frmIlacbilgi_Load(object sender, EventArgs e)
        {
          
            axAcroPDF1.LoadFile("C:\\Users\\NURSİMA AKBAŞ\\Downloads\\İlaç ve ilaçla ilgili genel kavramlar.pdf");

        }

        private void tabPage2_Click(object sender, EventArgs e)
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
