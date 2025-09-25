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
    public partial class frmBiletOlustur : Form
    {
        public frmBiletOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void frmBiletOlustur_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
            biletNoOlustur();
        }
        void biletNoOlustur()
        {
            // kod oluşturma işlemi gerçekleştireceğiz // random 
            Random rastgele = new Random();
            string karakterler = "1234567899876234567899876523456789876523458998765234567812345678998762345678998765";
            string kod = "";

            // tb...
            // karaketlerin -> 10 ->3,5,10

            for (int i = 1; i < 11; i++) // 11-> 10
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();

        }
        void FilmAdiGetir()
        {
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC ";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                string gelenTarih = oku["TARIH"].ToString();
                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                DateTime bugun = DateTime.Today;

                TimeSpan fark = fTarih - bugun;
                if (fark.TotalDays >= 0)
                {
                    cbFilmAdi.Items.Add(oku["ADI"].ToString());

                }
            }

            connection.Close();
        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //distinct DISTINCT --> veri tabanımızda kayıtlı olan aynı türden veriler arasında sadece bir tanesini getirir. DİKKAT -- > diğer verilerin hiçbirini silmez sadece bir tanesini gösterir

            cbTarıh.Items.Clear();
            string sorgu = "select DISTINCT TARIH from Tbl_Kontrol WHERE FILMADI=@filmAdı";

            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmAdı", cbFilmAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarıh.Items.Add(oku["TARIH"].ToString());

            }
            connection.Close();
        }
        void BiletNoSorgula()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@no ";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@no", txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                KaydetmeMetodu();
            }
            else
            {
                biletNoOlustur();
                connection.Close();
                BiletNoSorgula();
            }
            connection.Close();
        }
        void KaydetmeMetodu()
        {
            string sorgu = "insert into Tbl_Biletler (BKOD, ADSOYAD, TELNO, KOLTUKNO, FILMADI, TARIH, SAAT, SALON, TUR, ISLEMSAATI) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            connection.Close();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand kayıt = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            kayıt.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
            kayıt.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToUpper().ToString());
            kayıt.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
            kayıt.Parameters.AddWithValue("@p4", txtKoltuklar.Text.ToString());
            kayıt.Parameters.AddWithValue("@p5", cbFilmAdi.Text.ToString());
            kayıt.Parameters.AddWithValue("@p6", cbTarıh.Text.ToString());
            kayıt.Parameters.AddWithValue("@p7", lblSeansSeç.Text.ToString());
            kayıt.Parameters.AddWithValue("@p8", cbSalon.Text.ToString());
            kayıt.Parameters.AddWithValue("@p9", cbBiletTürü.Text.ToString());
            kayıt.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
            kayıt.ExecuteNonQuery();
            connection.Close();

            // update --> güncelleme komutu kullanacağız
            string sorgu2 = "UPDATE Tbl_Kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand guncelle = new Microsoft.Data.SqlClient.SqlCommand(sorgu2, connection);
            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara", txtKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString());
            }

            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarıh.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSeç.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("BİLET SATIŞI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
            SalonDurumGeldi();

            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lbBelirlenen.Items.Clear();
            txtKoltuklar.Text = "";


        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBarkod.Text != "" && txtKoltuklar.Text != "" && txtTelNo.Text != "" && cbBiletTürü.Text != "" && cbFilmAdi.Text != "" && cbSalon.Text != "" && cbTarıh.Text != "")
            {
                // kayıt işlemlerimiz bu alanda gerçekleştirilecektir
                BiletNoSorgula();// bilet sorgulama sonucuda varolan numara veritabanında kayıtlı değil ise kayıt işlemi gerçekleitirilip bu metodun içerisinde yapılacaktır.


            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİRŞEKİLDE DOLDURUNUZ");
            }



        }
        void secTiklerimiz()
        {
            txtKoltuklar.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;

            }
            if (txtKoltuklar.Text.Length > 1)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.ForeColor == Color.Black)// arkaplan kırmızı yani dolu
            {
                MessageBox.Show("BU KOLTUK DOLUDUR");
            }
            else
            {
                if (btn.ForeColor == Color.Yellow)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sarkoltuk);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Blue;
                    lbBelirlenen.Items.Add(btn.Text);
                    secTiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.mavikoltuk);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Yellow;
                    lbBelirlenen.Items.Remove(btn.Text);
                    secTiklerimiz();
                }
            }
        }



        private void cbTarıh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // test aşaması için bu butonu kullanmaktayız

            string saatler = "";
            string sorgu = "select DISTINCT SAAT from Tbl_Kontrol WHERE FILMADI=@filmAdı AND TARIH=@tarih";

            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmAdı", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarıh.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.FromArgb(242, 171, 26);
                rnd.FlatStyle = FlatStyle.Flat;
                rnd.CheckedChanged += new EventHandler(SeansSaatleri);
                panelSEANS.Controls.Add(rnd);
            }

            connection.Close();
        }
        private void SeansSaatleri(object sender, EventArgs e)
        {
            //forech döngümüzü kullanacağız.!!!
            foreach (RadioButton item in panelSEANS.Controls)
            {
                if (item.Checked == true)// bu format seçili
                {
                    lblSeansSeç.Text = item.Text;
                    //panelSEANS.Controls.Clear();
                    cbSalon.Items.Clear();
                    string sorgu = "select DISTINCT SALONADI from Tbl_Kontrol WHERE FILMADI=@filmAdı AND TARIH=@tarih AND SAAT=@saat";
                    connection.Open();
                    Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@filmAdı", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarıh.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSeç.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbSalon.Items.Add(oku["SALONADI"].ToString());
                    }

                    connection.Close();
                }
            }
        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalonDurumGeldi();
        }
        void SalonDurumGeldi()
        {
            string sorgu = "select *  from Tbl_Salonlar WHERE SALONADI=@salonadi";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
            }

            connection.Close();
            // SEÇİLİ OLAN KOLTUKLARI VERİ TABANINDAN ÇEKMİŞ OLUYORUZ 
            koltukGetir();
            Doldur();
        }
        void Doldur()
        {
            KoltukPaneli.Controls.Clear();
            int Sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 1; i <= Sayi; i++)
            {
                Button btn = new Button();
                //...............
                if (i <= 10)
                {
              
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 20)
                {
                    btn.Text = "B" + (i-10).ToString();
                    btn.Name = "B" + (i-10).ToString();
                }
                else if (i <= 30)
                {
                    btn.Text = "C" + (i - 20).ToString();
                    btn.Name = "C" + (i - 20).ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "D" + (i - 30).ToString();
                    btn.Name = "D" + (i - 30).ToString();
                }
                else if (i <= 50)
                {
                    btn.Text = "E" + (i - 40).ToString();
                    btn.Name = "E" + (i - 40).ToString();
                }
                else if (i <= 60)
                {
                    btn.Text = "F" + (i - 50).ToString();
                    btn.Name = "F" + (i - 50).ToString();
                }
                else if (i <= 70)
                {
                    btn.Text = "G" + (i - 60).ToString();
                    btn.Name = "G" + (i - 60).ToString();
                }
                else if (i <= 80)
                {
                    btn.Text = "H" + (i - 70).ToString();
                    btn.Name = "H" + (i - 70).ToString();
                }
                else if (i <= 90)
                {
                    btn.Text = "I" + (i - 80).ToString();
                    btn.Name = "I" + (i - 80).ToString();
                }
                else if (i <= 100)
                {
                    btn.Text = "İ" + (i - 90).ToString();
                    btn.Name = "İ" + (i - 90).ToString();
                }


                //...............
                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10);

                btn.ForeColor = Color.Purple;
                btn.Click += Btn_Click;
                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.kırmızıkolutk);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Black;
                    btn.TextAlign = ContentAlignment.MiddleRight;
                    //btn.BackColor = Color.Red;// koltuk seçili ise

                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.mavikoltuk);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Yellow;
                    btn.TextAlign = ContentAlignment.MiddleRight;
                    //btn.BackColor = Color.Blue; // koltuk seçili değil ise

                }

                KoltukPaneli.Controls.Add(btn);
            }
        }
        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "select * from Tbl_Kontrol WHERE FILMADI=@filmAdı AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";

            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmAdı", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarıh.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSeç.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                lblGelenKoltuk.Text += " ," + oku["KOLTUKLAR"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }

            }

            connection.Close();
            koltukAyirma();

            // koltuk numaralrını ayırma 

        }
        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');//hangi karakteri belirtirsek o karakterde ayrıma işlemi yapmaya yarayan komut
                                // forech
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cbBiletTürü.Text = "";
            cbSalon.Text = "";
            txtBarkod.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSeç.Text = "";
            cbSalon.Items.Clear ();
            cbTarıh.Text = "";
            cbTarıh.Items.Clear ();
            cbBiletTürü.Items.Clear ();
            cbBiletTürü.Items.Add("YETİŞKİN");
            cbBiletTürü.Items.Add("ÖĞRENCİ");
            biletNoOlustur();
            panelSEANS.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lbBelirlenen.Items.Clear();
            cbFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            FilmAdiGetir();
            txtAdSoyad.Focus();
           



        }
    }
}

