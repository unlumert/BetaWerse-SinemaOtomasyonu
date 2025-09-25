using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BetaWerse
{
    public partial class FrmYonetmenKayit : Form
    {
        public FrmYonetmenKayit()
        {
            InitializeComponent();
        }
        // cconnectionstring
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenKayit_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }


        public string resimYolu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All FİLES | *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Resim seçme işlemini bu alanda veya bu kısımda gerçekleştireceğiz
                pPResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rBKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }
        public string cinsiyet = "0";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yasHesaplama();
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimYolu != "")
            {
                string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                // ToUpper() dediğimiz komutumuz var olan karakterlerin tüün BÜYÜK HARFE çevirmeye yarayam komudumuzdur
                // muharrem --> MUHARREM
                // insert, update, delete, select
                connection.Open();
                Microsoft.Data.SqlClient.SqlCommand kayit = new Microsoft.Data.SqlClient.SqlCommand("insert into Tbl_Yonetmenler (ADSOYAD,CINSIYET,YAŞ,BİYOGRAFİ,RESİM) VALUES (@p1,@p2,@p3,@p4,@p5)", connection);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", txtBiyografi.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("YÖNETMEN KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
                //ARAÇ TEMİZLEME KOMUDU YAZMAMIZ GEREKECEK
                aracTemizle();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİRŞEKİLDE DOLDURUNUZ!");
            }

        }
        void aracTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            nGun.Value = 4;
            nAy.Value = 4;
            nYil.Value = 2005;
            rBErkek.Checked = true;
            rBKadın.Checked = false;
            lblKarakter.Text = "300";
            cinsiyet = "0";
            bYas = "00";
            pPResim.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\Topluluk\icons\noim.png";
            txtAd.Focus();
        }
        public string bYas = "0";
        void yasHesaplama()
        {
            string dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            //MessageBox.Show(dogum);
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            //MessageBox.Show(dogumTarihi.ToShortDateString());
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - dogumTarihi.Year;

            //  if (yas < 0)
            //  {
            // MessageBox.Show("Yaşınız negatif olamaz");
            // }
            //  else if (yas < 18)
            //  {
            //      MessageBox.Show("Yaşınız 18'den küçüktür");
            //  }
            //     else
            //     {
            //MessageBox.Show(yas.ToString());
            //  }
            bYas = yas.ToString();

        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtBiyografi.Text.Length;
            int geri = 300 - karakterSayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 20)
            {
                lblKarakter.ForeColor = Color.FromArgb(84, 110, 122);
            }
            if (geri <= 20)
            {
                lblKarakter.ForeColor = Color.Orange;

                if (geri <= 10)
                {
                    lblKarakter.ForeColor = Color.Red;
                }
                //MessageBox.Show(karakterSayisi.ToString());

            }
        }

        private void FrmYonetmenKayit_Load_1(object sender, EventArgs e)
        {

        }

        private void lblKarakter_Click(object sender, EventArgs e)
        {

        }
    }
}

