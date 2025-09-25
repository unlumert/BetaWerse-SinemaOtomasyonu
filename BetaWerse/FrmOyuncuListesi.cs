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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            PanelListe.Controls.Clear();
            connection.Open();
            string sorgu = "SELECT * FROM Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                this.Visible = true;
                OyuncuListesi arac = new OyuncuListesi();
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
            SqlCommand ara = new SqlCommand("SELECT * FROM Tbl_Oyuncular WHERE ADSOYAD LIKE @p1 collate Turkish_CI_AS ORDER BY ADSOYAD ASC", connection);
            ara.Parameters.AddWithValue("@p1", "%" + txtAramaYap.Text + "%");
            SqlDataReader oku = ara.ExecuteReader();

            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
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
