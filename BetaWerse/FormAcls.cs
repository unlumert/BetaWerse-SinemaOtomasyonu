using Microsoft.Data.SqlClient; // Modern k�t�phane
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

        // Modern ba�lant� (Microsoft.Data.SqlClient ile)
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
            //kullan�c� giri� i�lemlerini ger�ekle�tirece�iz
            //select insert update delete
            //�art ve ko�ul t�mlecimiz where idi.
            connection.Open();
            // * programlama dilinde ALL anlam�na gelir yani t�m t�m� anlam�n� kar��lamaktad�r
            Microsoft.Data.SqlClient.SqlCommand sorgula = new Microsoft.Data.SqlClient.SqlCommand("select * from Tbl_Kullanicilar WHERE KADI=@username AND KSIFRE=@password", connection);
            sorgula.Parameters.AddWithValue("@username", txtkullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            Microsoft.Data.SqlClient.SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read()) // okuma i�lemi ba�ar�l� ise yani girmi� oldu�umuz veri taban�nda mevcut ise veya bilgiler e�le�iyor ise ya da bilgiler do�ru ise yap
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.kisiAdiSoyadi = oku["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI KAYDI BULUNAMADI ! KULLANICI ADI YA DA ��FRE HATALI");
            }
            connection.Close();

            txtkullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtkullaniciAdi.Focus();// imleci konumland�r


        }
    }
}
