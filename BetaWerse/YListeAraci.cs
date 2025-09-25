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
    public partial class YListeAraci : UserControl
    {
        public YListeAraci()
        {
            InitializeComponent();
        }

        Microsoft.Data.SqlClient.SqlConnection connection = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;Integrated Security=true;");

        private void YListeAraci_Load(object sender, EventArgs e)
        {
            SecimiGuncelle(); // Artık seçim kontrolü buradan da çağrılabilir
        }

        public void SecimiGuncelle()
        {
            try
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblY.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    // Seçili kişi sarı renk ve turuncu ikon
                    lblY.ForeColor = Color.FromArgb(249, 164, 26);
                    pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\orange.png";
                }
                else
                {
                    // Seçili değilse siyah renk ve koyu ikon
                    lblY.ForeColor = Color.FromArgb(17, 28, 43);
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

        private void lblY_Click(object sender, EventArgs e)
        {
            if (lblY.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblY.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\orange.png";

                connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Secilenler (KISI, TUR) VALUES (@kisi, @tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lblY.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lblY.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\serha\OneDrive\Masaüstü\icons\dark.png";

                connection.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Secilenler WHERE KISI = @kisi AND TUR = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblY.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void bırak(object sender, EventArgs e)
        {
            lblY.Font = new Font(lblY.Font.Name, 12, FontStyle.Regular); // eski haline dön
        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblY.Font = new Font(lblY.Font.Name, 12, FontStyle.Underline); // labelin altını çiz
        }
    }
}
