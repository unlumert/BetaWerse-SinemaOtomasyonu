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
    public partial class OListeAraci : UserControl
    {
        public OListeAraci()
        {
            InitializeComponent();
        }

        private void OListeAraci_Load(object sender, EventArgs e)
        {
            SecimiGuncelle();
        }
        public void SecimiGuncelle()
        {
            try
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblO.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    // Seçili kişi sarı renk ve turuncu ikon
                    lblO.ForeColor = Color.FromArgb(249, 164, 26);
                    pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\orange.png";
                }
                else
                {
                    // Seçili değilse siyah renk ve koyu ikon
                    lblO.ForeColor = Color.FromArgb(17, 28, 43);
                    pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\dark.png";
                }

                oku.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim güncelleme hatası: " + ex.Message);
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");
        private void lblO_Click(object sender, EventArgs e)
        {
            if (lblO.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblO.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\orange.png";
                connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Secilenler (KISI, TUR) VALUES (@kisi, @tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lblO.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lblO.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\dark.png";
                connection.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblO.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }
        
            
        private void lblO_MouseMove(object sender, MouseEventArgs e)
        {
            lblO.Font = new Font(lblO.Font.Name, 12, FontStyle.Underline);//labelin altını çiz
        }

        private void OListeAraci_MouseLeave(object sender, EventArgs e)
        {
            lblO.Font = new Font(lblO.Font.Name, 12, FontStyle.Regular);// eski haline dön
        }
    }
}
