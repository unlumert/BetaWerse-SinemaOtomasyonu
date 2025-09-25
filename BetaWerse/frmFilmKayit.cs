using Microsoft.Data.SqlClient;
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
    public partial class frmFilmKayit : Form
    {
        public frmFilmKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();



        }
        void verileriSil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Secilenler ", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "5";
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "1";
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "3";
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "4";
        }

        private void rB6_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "6";
        }

        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "7";
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "8";
        }

        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "9";
        }

        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblRaiting.Text = "10";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtFilmDetay.Text.Length;
            int geri = 500 - karakterSayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 50)
            {
                lblKarakter.ForeColor = Color.FromArgb(84, 110, 122);
            }
            if (geri <= 50)
            {
                lblKarakter.ForeColor = Color.Orange;

                if (geri <= 30)
                {
                    lblKarakter.ForeColor = Color.Red;
                }
                //MessageBox.Show(karakterSayisi.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            OyuncuAra();
        }
        void OyuncuAra()
        {

            string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ADSOYAD LIKE @aranan collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();

            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@aranan", "%" + txtOyuncuAra.Text + "%");

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lblO.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }

            connection.Close();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void frmFilmKayit_Load(object sender, EventArgs e)
        {
            lblOyuncuAra.Visible = false;
            lblYonetmenAra.Visible = false;
            YListeGetir();
            OListeGetir();
            bugununTarihi();
            txtFılmAdı.Focus();//imlecimiz
        }
        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;

        }
        // yünetmen listesi

        void YListeGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lblY.Text = oku["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();

        }
        // oyuncu listesi
        void OListeGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OListeAraci arac = new OListeAraci();
                arac.lblO.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        private void lblOyuncuAra_Click(object sender, EventArgs e)
        {

        }

        private void txtOyuncuAra_MouseLeave(object sender, EventArgs e)
        {
            lblOyuncuAra.Visible = false;
        }
        private void txtOyuncuAra_MouseMove(object sender, MouseEventArgs e)
        {
            lblOyuncuAra.Visible = true;
        }




        private void lblOyuncuAra_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lblOyuncuAra_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lblYonetmenAra.Visible = true;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            lblYonetmenAra.Visible = false;
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {
            YonetmenAra();
        }
        void YonetmenAra()
        {


            string sorgu = "SELECT * FROM Tbl_Yonetmenler WHERE ADSOYAD LIKE @aranan collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fYonetmenPaneli.Controls.Clear();
            connection.Open();

            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@aranan", "%" + textBox2.Text + "%");

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YListeAraci arac = new YListeAraci();
                arac.lblY.Text = oku["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }

            connection.Close();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblAksiyon.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(84, 110, 120);
            }

        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblKorku.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblKorku.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }

        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblGerilim.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblGerilim.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            if (lblAsk.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblAsk.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblAsk.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }

        private void lblDram_Click(object sender, EventArgs e)
        {
            if (lblDram.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblDram.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblDram.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }



        private void grBTur_Enter(object sender, EventArgs e)
        {

        }

        private void lblTurkce_Click(object sender, EventArgs e)
        {
            if (lblTurkce.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblTurkce.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblTurkce.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }

        private void lblIngılızce_Click(object sender, EventArgs e)
        {
            if (lblIngılızce.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblIngılızce.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblIngılızce.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }

        private void lblAltyazı_Click(object sender, EventArgs e)
        {
            if (lblAltyazı.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblAltyazı.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblAltyazı.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }



        private void lblKorkuSıddet_Click(object sender, EventArgs e)
        {
            if (lblKorkuSıddet.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblKorkuSıddet.ForeColor = Color.FromArgb(242, 171, 26);
                PbKorku.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblKorkuSıddet.ForeColor = Color.FromArgb(84, 110, 120);
                PbKorku.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }

        private void lblCınsellık_Click(object sender, EventArgs e)
        {
            if (lblCınsellık.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblCınsellık.ForeColor = Color.FromArgb(242, 171, 26);
                PbCınsellık.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblCınsellık.ForeColor = Color.FromArgb(84, 110, 120);
                PbCınsellık.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }

        private void lblOlumsuzIcerık_Click(object sender, EventArgs e)
        {
            if (lblOlumsuzIcerık.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblOlumsuzIcerık.ForeColor = Color.FromArgb(242, 171, 26);
                PbOlumsuz.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblOlumsuzIcerık.ForeColor = Color.FromArgb(84, 110, 120);
                PbOlumsuz.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }

        private void lblGenelIzleyıcı_Click(object sender, EventArgs e)
        {
            if (lblGenelIzleyıcı.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblGenelIzleyıcı.ForeColor = Color.FromArgb(242, 171, 26);
                PbGenel.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblGenelIzleyıcı.ForeColor = Color.FromArgb(84, 110, 120);
                PbGenel.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }

        private void lblArtı7_Click(object sender, EventArgs e)
        {
            if (lblArtı7.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblArtı7.ForeColor = Color.FromArgb(242, 171, 26);
                Pb7.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblArtı7.ForeColor = Color.FromArgb(84, 110, 120);
                Pb7.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }

        private void lblArtı13_Click(object sender, EventArgs e)
        {
            if (lblArtı13.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblArtı13.ForeColor = Color.FromArgb(242, 171, 26);
                Pb13.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\unloock.png";
            }
            else
            {
                lblArtı13.ForeColor = Color.FromArgb(84, 110, 120);
                Pb13.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\lock.png";
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTarıhSec_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }
        string vTarih = "";
        string durum = "";
        void vizyonTarihiHesapla()
        {
            vTarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            DateTime dvTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            //timespan --> var olan iki tarih arasındaki gün,ayiyıl, saat vb gibi konuları, sayısal verileri belirlemeye yarar.

            TimeSpan tSpan = dvTarih - bugunTarihi;

            if (tSpan.TotalDays < 0)
            {
                // iki tarih arasında bulunan fark negatif ise ne olacak.
                MessageBox.Show("GEÇMİŞ TARİHLERE AİT FİLM EKLENMESİ YAPILAMAZ");
                bugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtFılmAdı.Text.ToUpper() + " FİLMİ BU GÜN VİZYONDA");

            }
            else
            {
                durum = "0";
                MessageBox.Show(txtFılmAdı.Text.ToUpper() + " FİLMİ " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONA GİRECEKTİR");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarıh.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }
        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler WHERE TUR = 'YÖNETMEN'";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            //komut.Parameters.AddWithValue("@P1","YÜNETMEN");
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) // if ise burası tek bir seçim yapar o yüzden while döngüsünü kullanmamız gerekiyor
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            connection.Close();
        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler WHERE TUR = 'OYUNCU'";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            //komut.Parameters.AddWithValue("@P1","YÜNETMEN");
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) // if ise burası tek bir seçim yapar o yüzden while döngüsünü kullanmamız gerekiyor
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            connection.Close();
        }
        void TemizlemeMetodu ()
        {
            this.Controls.Clear();
            this.InitializeComponent();

            txtFılmAdı.Focus();
            verileriSil();
            YListeGetir();
            OListeGetir();
            bugununTarihi();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            secilenYonetmen();
            secilenOyuncu();

            Tur();
            ozellik();
            bıcım();

            // insert into deyimini kullanarak verileri veri tabanına kaydetme işlemlerini gerçekleştireceğiz
            // input kontrolü sağlayacağız

            if (txtFılmAdı.Text != "" && txtFilmDetay.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu != "" && vTarih != "" && secilenBıcım != "" && secilenOzellık != "" && secilenTur != "")
            {
                // alanlarımız dolu ise 
                connection.Open();
                string sorgu = "insert into Tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@p1", txtFılmAdı.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenOzellık.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellık.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellık);
                }
                if (secilenBıcım.Length > 2) // yapılan seçim ve seçim uzunluğu
                {
                    komut.Parameters.AddWithValue("@p4", secilenBıcım.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBıcım);
                }
                if (yonetmen.Length > 2) // yapılan seçim ve seçim uzunluğu
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                if (oyuncu.Length > 2) // yapılan seçim ve seçim uzunluğu
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }


                komut.Parameters.AddWithValue("@p7", txtFilmDetay.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", lblRaiting.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE EKLENDİ");
                TemizlemeMetodu();

            }
            else
            {
                // alanlarımız boş ise
                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ!");


            }

            // geçiçi alanlarımız = daha sonradan değiştireceğiz




        }
        string secilenTur = "";
        string secilenOzellık = "";
        string secilenBıcım = "";
        void Tur()
        {

            foreach (Control arac in grBTur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 120))
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilenTur += " +" + arac.Text.ToString();
                    }
                }
            }

        }
        void ozellik()
        {

            foreach (Control arac in GRBozellık.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 120))
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilenOzellık += " +" + arac.Text.ToString();
                    }
                }
            }

        }
        void bıcım()
        {

            foreach (Control arac in GRBbıcım.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 120))
                    {

                    }
                    else
                    {
                        //seçilmiş ise
                        secilenBıcım += " +" + arac.Text.ToString();
                    }
                }
            }

        }

        private void lblKomedı_Click(object sender, EventArgs e)
        {
            if (lblKomedı.ForeColor == Color.FromArgb(84, 110, 120))
            {
                lblKomedı.ForeColor = Color.FromArgb(242, 171, 26);
            }
            else
            {
                lblKomedı.ForeColor = Color.FromArgb(84, 110, 120);
            }
        }
    
    }
}
