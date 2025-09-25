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
    public partial class ListeEleman : UserControl
    {
        public ListeEleman()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");
        private void ListeEleman_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void ListeEleman_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = " select * from Tbl_Yonetmenler WHERE ID=@p1";
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblıd.Text);
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblCinsiyet.Text = oku["CINSIYET"].ToString();

            }
            connection.Close();
            if (lblCinsiyet.Text == "0")
            {
                //erkek
                pbCİNSİYET.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\male.png";
            }
            else
            {
                //kadın
                pbCİNSİYET.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\kadınn.png";
            }
        }

        private void lblCinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = " select * from Tbl_Yonetmenler WHERE ID=@p1";
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblıd.Text);
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                 MessageBox.Show("BİYOGRAFİ: " + oku["BİYOGRAFİ"].ToString(), oku["ADSOYAD"].ToString());
                // MessageBox.Show("BİYOGRAFİ: " + oku["BİYOGRAFİ"].ToString(), oku["ADSOYAD"].ToString(), MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            connection.Close();
        }
        // kayıt silme işlemi aşşağıda gerçekleşti
        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand sil = new Microsoft.Data.SqlClient.SqlCommand("delete from Tbl_Yonetmenler WHERE ID=@p1",connection);
            sil.Parameters.AddWithValue("@p1", lblıd.Text);
            sil.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(lblAdSoyad.Text+" KİŞİSİNE AİT KAYIT BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR!");
            this.Hide();// usercontrol aracımızı gizlemiş oluyoruz// tüm araçlar gizlenmiyor gizlenmeyecektir
        }
    }
}
