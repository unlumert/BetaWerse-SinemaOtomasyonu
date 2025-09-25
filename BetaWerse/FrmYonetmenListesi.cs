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
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            PanelListe.Controls.Clear();
            connection.Open();

            string sorgu = " select * from Tbl_Yonetmenler  ORDER BY ADSOYAD ASC";//DESC
            Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand(sorgu, connection);
            Microsoft.Data.SqlClient.SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                this.Visible = true;
                // işlemlerimizi gerçekleştireceğiz
                ListeEleman arac = new ListeEleman();
                arac.lblıd.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.pbCİNSİYET.Text = oku["CINSIYET"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                PanelListe.Controls.Add(arac);

            }
            connection.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            PanelListe.Controls.Clear();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand ara = new Microsoft.Data.SqlClient.SqlCommand("select * from Tbl_Yonetmenler  WHERE ADSOYAD LIKE @p1 collate Turkish_CI_AS ORDER BY ADSOYAD ASC", connection);
            ara.Parameters.AddWithValue("@p1", "%" + txtAramaYap.Text + "%");
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                ListeEleman arac = new ListeEleman();
                arac.lblıd.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.pbCİNSİYET.Text = oku["CINSIYET"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                PanelListe.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
