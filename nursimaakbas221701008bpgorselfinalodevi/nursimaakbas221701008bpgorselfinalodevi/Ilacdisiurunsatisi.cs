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
    public partial class Ilacdisiurunsatisi : Form
    {
        public Ilacdisiurunsatisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-ISQETAEN; Initial Catalog=Eczane; Integrated Security=True");
        SqlCommand komut2;
        SqlDataAdapter da;
        private void ilacdisiurungoster()
        {
            if (baglanti2.State == ConnectionState.Closed)
            {
               
                baglanti2.Open();
                da = new SqlDataAdapter("Select * from Satılanurunler", baglanti2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                da = new SqlDataAdapter("Select * from Ilacdisiurun", baglanti2);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                dataGridView2.DataSource = dt2; 

            }
            baglanti2.Close();
        }
        
        private void ilacdisiurunsatisigoster()
        {  
            if(baglanti2.State==ConnectionState.Closed)
            {
                baglanti2.Open();
                da = new SqlDataAdapter("Select *from Satılanurunler", baglanti2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            baglanti2 .Close();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Ilacdisiurunsatisi_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "İlaç Dışı Ürün Satışı";
            tabPage2.Text = "İlaç Dışı Satış Listesi";
            ilacdisiurungoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" ||  txtFiyat.Text == ""||radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Ürün bilgilerini giriniz", "Uyarı");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    toolStripStatusLabel1.Text = txtFiyat.Text.ToString() + "Ödenecek ücret"+"(Nakit ödeme)";
                }
                else
                {
                    toolStripStatusLabel1.Text = txtFiyat.Text.ToString() + "Ödenecek ücret"+"(Kartlı ödeme)";
                }

                baglanti2.Open();
                SqlCommand komut = new SqlCommand("Insert Into Satılanurunler (UrunAD,UrunFiyat) Values(@ad,@fiyat)", baglanti2);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
             

                komut.ExecuteNonQuery();
                baglanti2.Close();
                ilacdisiurunsatisigoster();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtFiyat.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtUrunad.Text == "" || txtUrunfiyat.Text == "" )
            {
                MessageBox.Show("Güncellencek ürün bilgilerini seçiniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti2.Open();
                SqlCommand komut2 = new SqlCommand("Update Satılanurunler Set  UrunFiyat='" + txtUrunfiyat.Text.ToString() + "',UrunAD='" + txtUrunad.Text.ToString() + "' where UrunID='"+txtSatisıd.Text.ToString()+"' ", baglanti2);
                komut2.ExecuteNonQuery();
                baglanti2.Close();
                ilacdisiurunsatisigoster();
                
                toolStripStatusLabel1.Text = "Ürün Kayıt Bilgileri Güncellendi";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtUrunad.Text == "" || txtUrunfiyat.Text == "" )
            {
                MessageBox.Show("Silinecek ürün bilgilerini giriniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti2.Open();
                SqlCommand komut = new SqlCommand("Delete from Satılanurunler where UrunID=@ıd", baglanti2);
                komut.Parameters.AddWithValue("@ıd",txtSatisıd.Text);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                ilacdisiurunsatisigoster();
                toolStripStatusLabel1.Text = "Ürün Kayıt Bilgileri Kalıcı olarak silindi";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUrunad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunfiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hstfrm=new Form1();
            hstfrm.Show();
            this.Hide();
        }

        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastakayıtkontrol hstk= new hastakayıtkontrol();
            hstk.Show();
            this.Hide();
        }

        private void ilaçStokKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu skt= new stokkontrolu();
            skt.Show();
            this.Hide();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris stg= new hastagiris();
            stg.Show();
            this.Hide();
        }

        private void ilaçBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacbilgi frmlc= new frmIlacbilgi();
            frmlc.Show();
            this.Hide();
        }

        private void reçeteBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi frmrect= new frmreceteturbilgi();
            frmrect.Show();
            this.Hide();
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2grf grafik= new Form2grf();
            grafik.Show();
            this.Hide();
        }
    }
}
