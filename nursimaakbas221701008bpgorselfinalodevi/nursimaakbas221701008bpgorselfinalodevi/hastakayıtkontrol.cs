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
    public partial class hastakayıtkontrol : Form
    {
        public string ilacId;
        private hastagiris hastakayit;
        public hastakayıtkontrol()
        {
            InitializeComponent();
            
        }
        public void temizle()
        {
            mtxttc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mtxttarih.Text = "";
            txtldıd.Text = "";
        }
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-ISQETAEN; Initial Catalog=Eczane; Integrated Security=True");
        SqlCommand komut2;
        SqlDataAdapter da;
        private void hastakayitgoster()
        {
            if (baglanti2.State == ConnectionState.Closed)
            {
                baglanti2.Open();
                da = new SqlDataAdapter("Select * from Hastakayit", baglanti2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                da = new SqlDataAdapter("Select* from Sigorta1", baglanti2);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                cmbsigorta.DataSource = dt2;
                cmbsigorta.DisplayMember = "Sigorta";
                da = new SqlDataAdapter("Select* from iller2", baglanti2);
                DataTable dt3 = new DataTable();
                da.Fill(dt3);
                cmbil.DataSource = dt3;
                cmbil.DisplayMember = "il";

            }
            baglanti2.Close();
        }
        private void hastakayıtkontrol_Load(object sender, EventArgs e)
        {
            hastakayitgoster();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mtxttc.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cmbsigorta.Text == "" || mtxttarih.Text == ""|| cmbil.Text == ""|| txtldıd.Text == "")
            {
                MessageBox.Show("Güncellencek Hasta bilgilerini seçiniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti2.Open();
                SqlCommand komut2 = new SqlCommand("Update Hastakayit Set Ad='" + txtAd.Text.ToString() + "', Soyad='" + txtSoyad.Text.ToString() + "', Sigorta='" + cmbsigorta.Text.ToString() + "',DogumTarihi='" + mtxttarih.Text.ToString() + "', il='"+cmbil.Text.ToString()+"',IlacID='"+txtldıd.Text.ToString()+"' where TC='" + mtxttc.Text.ToString() + "'", baglanti2);
                komut2.ExecuteNonQuery();
                baglanti2.Close();
                hastakayitgoster();
                temizle();
                toolStripStatusLabel1.Text = "Hasta Kayıt Bilgileri Güncellendi";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtxttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbsigorta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtxttarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbil.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtldıd.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (mtxttc.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cmbsigorta.Text == "" || mtxttarih.Text == "" || cmbil.Text == "" || txtldıd.Text == "")
            {
                MessageBox.Show("Silinecek Hasta bilgilerini giriniz", "Hatalı Giriş", MessageBoxButtons.OK);
            }
            else
            {
                baglanti2.Open();
                SqlCommand komut = new SqlCommand("Delete from Hastakayit where TC=@tc", baglanti2);
                komut.Parameters.AddWithValue("@tc", mtxttc.Text);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                hastakayitgoster();
                temizle();
                toolStripStatusLabel1.Text = "Hasta Kayıt Bilgileri Kalıcı olarak silindi";

            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hstfrm = new Form1();
            hstfrm.Show();
            this.Hide();

        }

        private void ilaçStokBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkontrolu stk= new stokkontrolu();
            stk.Show();
            this.Hide();
        }

        private void ilaçDışıÜrünSatışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilacdisiurunsatisi lcd= new Ilacdisiurunsatisi();
            lcd.Show();
            this.Hide();
        }

        private void ilaçBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIlacbilgi frmlc= new frmIlacbilgi();
            frmlc.Show();
            this.Hide();
        }

        private void hastaGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastagiris hstg= new hastagiris();
            hstg.Show();
            this.Hide();
        }

        private void reçeteBİlgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreceteturbilgi frrcet= new frmreceteturbilgi();
            frrcet.Show();
            this.Hide();
        }

        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2grf grf = new Form2grf();
            grf.Show();
            this.Hide();
        }
    }
}
