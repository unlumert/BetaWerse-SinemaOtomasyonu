using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BetaWerse
{
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != "")
            {
                connection.Open();
                Microsoft.Data.SqlClient.SqlCommand kaydet = new Microsoft.Data.SqlClient.SqlCommand("insert into Tbl_Salonlar (SALONADI, KOLTUKSAYISI) Values (@P1,@P2)", connection);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("SALON KEYDETME İŞLEMİ BAŞARILI BİRŞEKLİDE GERÇEKLEŞTİRİLDİ!");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
             
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR DEĞER GİRİNİZ!");
            }
        }
        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
        }

        void Kolustur()
        {
            cbKoltukSayisi.Items.Clear();
            for (int i = 1;i <= 200; i++)
            {
             
                cbKoltukSayisi.Items.Add(i);
               
            }
            
        }
        void listeGetir ()
        {
            panelsalonliste.Controls.Clear();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand("SELECT * FROM Tbl_Salonlar ORDER BY SALONADI ASC ", connection);
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                SalonListesi arac = new SalonListesi();
                arac.lblSalonAdi.Text = oku["SALONADI"].ToString();
                arac.lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
                panelsalonliste.Controls.Add(arac);
                Kolustur();
            }
            connection.Close();
        }

       
    }
}
