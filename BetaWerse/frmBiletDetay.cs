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
    public partial class frmBiletDetay : Form
    {
        public frmBiletDetay()
        {
            InitializeComponent();
        }
        
       
        public string biletno = "";
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void frmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletno;
            lblBiletNo2.Text = biletno;
            barkotNoOlustur();
            bilgiGetir();
        }
        void bilgiGetir()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@kod";
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand getir = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            getir.Parameters.AddWithValue("@kod", biletno);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblFilmAdi.Text= oku["FILMADI"].ToString();
                lblFilmAdi2.Text = oku["FILMADI"].ToString();
                lblTelNo.Text = oku["TELNO"].ToString();
                lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                lblBiletTuru.Text = oku["TUR"].ToString();
                lblSalonAdi.Text = oku["SALON"].ToString();
                lblSalon2.Text = oku["SALON"].ToString();
                lblTarih2.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblTarihSaat.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblİslemTarihi.Text = oku["ISLEMSAATI"].ToString();
                lblKoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();

            }
            connection.Close();
        }
        void barkotNoOlustur()
        {

            Random rastgele = new Random();
            string karakterler = "1234567899876234567899876523456789876523458998765234567812345678998762345678998765";
            string kod = "";



            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
