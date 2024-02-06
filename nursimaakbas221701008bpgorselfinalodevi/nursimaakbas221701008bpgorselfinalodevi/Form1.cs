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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEczad.Text == "Nursima" && txtSifre.Text == "1713" )
            {

                hastagiris hst = new hastagiris();
                hst.Show();
                this.Hide();
               
            }
            else if(txtEczad.Text == " " && txtSifre.Text == " ")
            {
                MessageBox.Show("Lütfen eczacı adını ve şifreyi girin");
                txtEczad.Focus();
            }
            else
            {
                MessageBox.Show("Eczacı adı veya şifre hatalı");
                txtEczad.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEczad.Text != "Nursima" && txtSifre.Text != "1713")
            {
                MessageBox.Show("Eczacı adı veya şifre hatalı");
                this.Close();
            }
            if (txtEczad.Text == " " && txtSifre.Text == " ")
            {
                MessageBox.Show("Lütfen eczacı adını ve şifreyi girin");
                this.Close();
            }
            else
            {
                stokkontrolu stk = new stokkontrolu();
                stk.Show();
                this.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEczad.Text != "Nursima" && txtSifre.Text != "1713")
            {
                MessageBox.Show("Eczacı adı veya şifre hatalı");
                this.Close();
            }
            if (txtEczad.Text == " " && txtSifre.Text == " ")
            {
                MessageBox.Show("Lütfen eczacı adını ve şifreyi girin");
                this.Close();
            }
            else
            {
                hastakayıtkontrol hstk= new hastakayıtkontrol();
                hstk.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtEczad.Text != "Nursima" && txtSifre.Text != "1713")
            {
                MessageBox.Show("Eczacı adı veya şifre hatalı");
                this.Close();
            }
            if (txtEczad.Text == " " && txtSifre.Text == " ")
            {
                MessageBox.Show("Lütfen eczacı adını ve şifreyi girin");
                this.Close();
            }
            else
            {
                Ilacdisiurunsatisi ilc = new Ilacdisiurunsatisi();
                ilc.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtSifre.PasswordChar == '*')
            {
                txtSifre.PasswordChar = '\0';
            }
            else 
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
