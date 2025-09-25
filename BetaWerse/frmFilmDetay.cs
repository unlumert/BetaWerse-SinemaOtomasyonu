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
    public partial class frmFilmDetay : Form
    {
        public frmFilmDetay()
        {
            InitializeComponent();
        }
       
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        public string idNo = "";
        private void frmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_Filmler Where ID =@p1";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
               
                PPResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdi.Text= oku["ADI"].ToString();
                lblFilmBiçimi.Text = oku["BICIMI"].ToString();
                lblFilmÖzellikleri.Text = oku["OZELLIKLERI"].ToString();
                lblFilmTürü.Text = oku["TURU"].ToString();
                lblFilmOyuncu.Text = oku["OYUNCU"].ToString();
                lblFilmYönetmen.Text = oku["YONETMEN"].ToString();
                lblVizyonTarihi.Text = oku["TARIH"].ToString();
                lblFilmDurum.Text = oku["DURUM"].ToString();
                lblFilmDetay.Text = oku["DETAY"].ToString();
                lblFilmPuan.Text = oku["PUAN"].ToString();
            }
            connection.Close();

            if (lblFilmDurum.Text == "0")
            {
                lblFilmDurum.Text = "FİLM VİZYONDA";
            }
            else
            {
                lblFilmDurum.Text = "FİLM VİZYONA GİRMEDİ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
