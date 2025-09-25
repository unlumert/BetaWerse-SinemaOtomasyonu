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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");
        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            PanelListe.Controls.Clear();
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //verileri getir
                FimListesi arac = new FimListesi();
                arac.lblFilmAdı.Text = oku["ADI"].ToString();
                arac.pPResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblNo.Text = oku["ID"].ToString();
                PanelListe.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            PanelListe.Controls.Clear();
            connection.Open();
            Microsoft.Data.SqlClient.SqlCommand ara = new Microsoft.Data.SqlClient.SqlCommand("select * from Tbl_Filmler  WHERE ADI LIKE '%" + txtAramaYap.Text + "%' collate TURKISH_CI_AS  ORDER BY ADI ASC", connection);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                FimListesi arac = new FimListesi();
                arac.lblFilmAdı.Text = oku["ADI"].ToString();
                arac.pPResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblNo.Text = oku["ID"].ToString();
                PanelListe.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
