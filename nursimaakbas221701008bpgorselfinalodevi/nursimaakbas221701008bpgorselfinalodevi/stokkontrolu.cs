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
    public partial class stokkontrolu : Form
    {
        public stokkontrolu()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtBarkod.Text = "";
            txtAd.Text = "";
            txtEtken.Text = "";
            txtFiyat.Text = "";


        }
        SqlConnection baglanti3 = new SqlConnection("Data Source=LAPTOP-ISQETAEN; Initial Catalog=Eczane; Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        private void ilaccstokgoster()
        {
            if (baglanti3.State == ConnectionState.Closed)
            {

                baglanti3.Open();
                da = new SqlDataAdapter("Select * from ilacsistemi1", baglanti3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                da = new SqlDataAdapter("Select * from Recete", baglanti3);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                cmbRecete.DataSource = dt2;
                cmbRecete.DisplayMember = "ReceteAd";

            }
            baglanti3.Close();
        }
        private void stokkontrolu_Load(object sender, EventArgs e)
        {
            ilaccstokgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtUzanti.Text= openFileDialog1.FileName; 
            if (txtBarkod.Text == "" || txtAd.Text == "" || txtEtken.Text == "" || txtFiyat.Text == "" || cmbRecete.Text == "")
            {
                MessageBox.Show("Kaydedilecek ilacın bilgilerini giriniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti3.Open();
                SqlCommand komut = new SqlCommand("Insert Into ilacsistemi1 (Barkod,UrunAd,EtkenMadde,Receterengi,Fiyat) Values(@barkod,@urunad,@etkenmadde,@rctreng,@fiyat)", baglanti3);
                komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                komut.Parameters.AddWithValue("@urunad", txtAd.Text);
                komut.Parameters.AddWithValue("@etkenmadde", txtEtken.Text);
                komut.Parameters.AddWithValue("@rctreng", cmbRecete.Text);
                komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                

                komut.ExecuteNonQuery();
                baglanti3.Close();
                ilaccstokgoster();
                temizle();
                toolStripStatusLabel1.Text = "Yeni ilaç kayıdı eklendi ";
            }
            

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text == "" || txtAd.Text == "" || txtEtken.Text == "" || txtFiyat.Text == "" || cmbRecete.Text == ""|| txtUzanti.Text=="")
            {
                MessageBox.Show("Güncellenecek ilaç kayıt bilgisi seçiniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti3.Open();
                SqlCommand komut = new SqlCommand("Update ilacsistemi1 Set UrunAd='" + txtAd.Text.ToString() + "', EtkenMadde='" + txtEtken.Text.ToString() + "', Receterengi='" + cmbRecete.Text.ToString() + "',Fiyat='" + txtFiyat.Text.ToString() + "',Ilacresim='"+txtUzanti.Text.ToString()+"' where Barkod='" + txtBarkod.Text.ToString() + "'", baglanti3);
               
                komut.ExecuteNonQuery();
                baglanti3.Close();
                ilaccstokgoster();
                temizle();
                toolStripStatusLabel1.Text = "Stok ilaç bilgisi güncellendi ";
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEtken.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbRecete.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtUzanti.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                       

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text == "" || txtAd.Text == "" || txtEtken.Text == "" || txtFiyat.Text == "" || cmbRecete.Text == "")
            {
                MessageBox.Show("Silinecek ilacın bilgilerini seçiniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti3.Open();
                SqlCommand komut = new SqlCommand("Delete from ilacsistemi1 where Barkod=@barkod", baglanti3);
                komut.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                komut.ExecuteNonQuery();
                baglanti3.Close();
                ilaccstokgoster();
                temizle();
                toolStripStatusLabel1.Text = "Ilaç stok kaydı silindi ";
            }
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hstgfrm = new Form1();
            hstgfrm.Show();
            this.Hide();
        }

        private void hastaKayıtKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastakayıtkontrol hstk=new hastakayıtkontrol();
            hstk.Show();
            this.Hide();
        }

        private void ilaçDışıÜrünKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilacdisiurunsatisi lcd=new Ilacdisiurunsatisi();
            lcd.Show(); 
            this.Hide();
        }

        private void hastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris hstg= new hastagiris();
            hstg.Show();
            this.Hide();
        }

        private void ilaçYanEtkileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacbilgi lcfrm=new frmIlacbilgi();
            lcfrm.Show();
            this.Hide();
        }

        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi frrect=new frmreceteturbilgi();
            frrect.Show();
            this.Hide();
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2grf grafik=new Form2grf();
            grafik.Show();
            this.Hide();
        }
    }
}
