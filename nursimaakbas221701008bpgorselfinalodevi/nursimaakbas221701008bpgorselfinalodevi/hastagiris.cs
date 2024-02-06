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
    public partial class hastagiris : Form
    {
        
        public hastagiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ISQETAEN; Initial Catalog=Eczane; Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void verilerigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                da = new SqlDataAdapter("Select * from Sigorta1", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSigorta.DataSource = dt;
                cmbSigorta.DisplayMember= "Sigorta";
                da = new SqlDataAdapter("Select* from iller2", baglanti);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                cmbil.DataSource = dt2;
                cmbil.DisplayMember = "il";
                da = new SqlDataAdapter("Select * from ilacsistemi1", baglanti);
                DataTable dt3= new DataTable();
                da.Fill(dt3);
                dataGridView1.DataSource = dt3;


            }
            baglanti.Close();
        }
       

        private void kayıtOluşturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            stokkontrolu stk = new stokkontrolu();
            stk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1(); 
            frm.Show();
            this.Hide();
        }

        private void hastagiris_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnYenikyt_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked==false)
            {
                MessageBox.Show("Ödeme türü seçiniz","Uyarı");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Nakit ödeme","Bilgi");
                }
                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Kartlı ödeme ","Bilgi");
                }
                else 
                {
                    MessageBox.Show("Ödeme alınmayacak","Bilgi");
                }
                int ilacFiyat;


                if (txtAd.Text == "" || txtSoyad.Text == "" || mtxtTc.Text == "" || txtlcfiyat.Text == "" || txtlcıd.Text == "")
                {
                    MessageBox.Show("giriş Bilgilerini Kontrol Ediniz.", "Hatalı Giriş", MessageBoxButtons.OK);
                }
                else
                {
                    ilacFiyat = Convert.ToInt32(txtlcfiyat.Text);



                    if (cmbSigorta.SelectedIndex == 0)
                    {
                        ilacFiyat = ilacFiyat / 20;
                        MessageBox.Show("İlaç Fiyatı (Bağ-kurlu hasta için): " + ilacFiyat.ToString());
                    }
                    else if (cmbSigorta.SelectedIndex == 1)
                    {
                        ilacFiyat = ilacFiyat /30;
                        MessageBox.Show("İlaç Fiyatı (Emekli hasta için): " + ilacFiyat.ToString());
                    }
                    else if (cmbSigorta.SelectedIndex == 2)
                    {
                        ilacFiyat = ilacFiyat - 100;
                        MessageBox.Show("İlaç Fiyatı (SSKlı hasta için): " + ilacFiyat.ToString());
                    }
                    else if (cmbSigorta.SelectedIndex == 3)
                    {
                        // Yeşil kartlı veya diğer durumlar için varsayılan olarak 0.2 ile çarpıyoruz
                        ilacFiyat = ilacFiyat -150;
                        MessageBox.Show("İlaç Fiyatı (Yeşil kartlı veya diğer durumlar için): " + ilacFiyat.ToString());
                    }


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert Into Hastakayit (TC,AD,Soyad,Sigorta,DogumTarihi,il,IlacID) Values(@tc,@ad,@soyad,@sigorta,@dogumtarihi,@il,@ilacID)", baglanti);
                    komut.Parameters.AddWithValue("@tc", mtxtTc.Text);
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@sigorta", cmbSigorta.Text);
                    komut.Parameters.AddWithValue("@dogumtarihi", mtbtTarih.Text);
                    komut.Parameters.AddWithValue("@il", cmbil.Text);
                    komut.Parameters.AddWithValue("@ilacID", txtlcıd.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                   
                    verilerigoster();


                    hastakayıtkontrol hst = new hastakayıtkontrol();
                    hst.ilacId=txtlcıd.Text;
                    hst.Show();
                }
            }
           

           
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            mtxtTc.Text = "";
            mtbtTarih.Text = "";
            txtlcıd.Text = "";
            txtlcfiyat.Text = "";
        }

        private void btnKayitonay_Click(object sender, EventArgs e)
        {
            
        }

        private void kayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastakayıtkontrol hstk = new hastakayıtkontrol();
            hstk.Show();
            this.Hide();
        }

        private void ilaçStoklarınıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu stk=new stokkontrolu();
            stk.Show();
            this.Hide();
        }

        private void ilaçDışıÜrünStoklarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilacdisiurunsatisi lcds = new Ilacdisiurunsatisi();
            lcds.Show();
            this.Hide();
        }

        private void ilaçBilgileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacbilgi frmlc= new frmIlacbilgi();
            frmlc.Show();
            this.Hide();
        }

        private void reçeteBilgileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi rctfrm= new frmreceteturbilgi();
            rctfrm.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            baglanti.Open();
            SqlCommand komut1=new SqlCommand("Select IlacID, Ilacresim from  ilacsistemi1 where IlacID=@ilacıd",baglanti);
            komut1.Parameters.AddWithValue("@ilacıd", txtlcıd.Text);
            SqlDataReader rdr = komut1.ExecuteReader();
            if (rdr.Read())
            {
                pictureBox1.ImageLocation= rdr[1].ToString();
            }
           
            baglanti.Close();
            
            
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2grf grafik = new Form2grf();
            grafik.Show();
            this.Hide();
        }
    }
}
