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
    public partial class frmBiletSorgulama : Form
    {
        public frmBiletSorgulama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if(txtBiletNo.Text!="")
            {
                connection.Open();
                Microsoft.Data.SqlClient.SqlCommand komut = new Microsoft.Data.SqlClient.SqlCommand("select* from Tbl_Biletler WHERE BKOD=@p1", connection);
                komut.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    frmBiletDetay frm = new frmBiletDetay();
                    frm.biletno = txtBiletNo.Text.ToString();
                    txtBiletNo.Text = "";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("KAYITLI BİLET BULUNAMADI");
                    connection.Close();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ!");
            }
           

           
        }

        private void txtBiletNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
