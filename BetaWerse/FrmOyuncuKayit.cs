using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaWerse
{
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimYolu = "";
        private void btnResimYukle_Click(object sender, EventArgs e)
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
        public string cinsiyet = "0";
        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {

            cinsiyet = "0";

        }

        private void rBKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
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
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - dogumTarihi.Year;


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
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yasHesaplama();
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimYolu != "")
            {
                string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                connection.Open();
                Microsoft.Data.SqlClient.SqlCommand kayit = new Microsoft.Data.SqlClient.SqlCommand("insert into Tbl_Oyuncular (ADSOYAD,CINSIYET,YAŞ,BİYOGRAFİ,RESİM) VALUES (@p1,@p2,@p3,@p4,@p5)", connection);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", txtBiyografi.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
                //ARAÇ TEMİZLEME KOMUDU YAZMAMIZ GEREKECEK
                aracTemizle();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİRŞEKİLDE DOLDURUNUZ!");
            }
        }

        private void FrmOyuncuKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
