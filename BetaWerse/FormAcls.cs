using Microsoft.Data.SqlClient; // Modern kütüphane
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BetaWerse
{
    public partial class FormAcls : Form
    {
        public FormAcls()
        {
            InitializeComponent();
        }

        // Modern baðlantý (Microsoft.Data.SqlClient ile)
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //kullanýcý giriþ iþlemlerini gerçekleþtireceðiz
            //select insert update delete
            //þart ve koþul tümlecimiz where idi.
            connection.Open();
            // * programlama dilinde ALL anlamýna gelir yani tüm tümü anlamýný karþýlamaktadýr
            Microsoft.Data.SqlClient.SqlCommand sorgula = new Microsoft.Data.SqlClient.SqlCommand("select * from Tbl_Kullanicilar WHERE KADI=@username AND KSIFRE=@password", connection);
            sorgula.Parameters.AddWithValue("@username", txtkullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            Microsoft.Data.SqlClient.SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read()) // okuma iþlemi baþarýlý ise yani girmiþ olduðumuz veri tabanýnda mevcut ise veya bilgiler eþleþiyor ise ya da bilgiler doðru ise yap
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.kisiAdiSoyadi = oku["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI KAYDI BULUNAMADI ! KULLANICI ADI YA DA ÞÝFRE HATALI");
            }
            connection.Close();

            txtkullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtkullaniciAdi.Focus();// imleci konumlandýr


        }
    }
}
