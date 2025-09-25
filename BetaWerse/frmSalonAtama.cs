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
    public partial class frmSalonAtama : Form
    {
        public frmSalonAtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand("SELECT * FROM Tbl_Salonlar ORDER BY SALONADI ASC ", connection);
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void frmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
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
        void SalonAdiGetir()
        {
            string sorgu = "select * from Tbl_Salonlar ORDER BY SALONADI ASC ";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                cbSalon.Items.Add(oku["SALONADI"].ToString());

            }

            connection.Close();
        }

        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (btnOlustur.Text == "TAMAMLA")
            {
                string sorgu = "select DISTINCT SAAT from Tbl_Kontrol WHERE TARIH=@tarih AND SALONADI=@salonadi";
                string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
                connection.Open();
                Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbDoluSaatler.Items.Add(oku["SAAT"].ToString());
                }
                connection.Close();

                SeansKONTROL();

                btnOlustur.Text = "OLUŞTUR";
                btnOlustur.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                Kaydet();
                Temizle();
                btnOlustur.Text = "TAMAMLA";
                btnOlustur.BackColor = Color.FromArgb(249, 164, 26);
            }
        }
        void Kaydet ()
        {
            string sorgu = "insert into Tbl_Kontrol (FILMADI,TARIH,SAAT,SALONADI) Values (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand ekle = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            ekle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbSalon.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SALON ATAMA İŞLEMİ GERÇEKLEŞTİRİLDİ");

        }
        private void SeansSaatleri(object sender, EventArgs e)
        { 
        
            //forech 
            foreach (RadioButton item in panelSEANS.Controls)
            {
                if(item.Checked) //true
                {
                    lblSecilen.Text = item.Text.ToString();
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle ()
        {

            cbFilmAdi.Items.Clear();
            cbSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
            panelSEANS.Controls.Clear();
            btnOlustur.Text = "TAMAMLA";
        }
        void SeansKONTROL()
        {
            // test için...
            panelSEANS.Controls.Clear();
            for (int i = 10; i <= 22; i++)//saat 10,00
            {
                for (int j = 0; j <= 30; j += 30)//dakika 10,30
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.FromArgb(249, 164, 26);
                    //rnd.FlatStyle = FlatStyle.Flat;
                    //rnd.Width = 70;
                    //rnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                    rnd.CheckedChanged += new EventHandler(SeansSaatleri);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }

                    panelSEANS.Controls.Add(rnd);
                }
            }
        }
    }
}
