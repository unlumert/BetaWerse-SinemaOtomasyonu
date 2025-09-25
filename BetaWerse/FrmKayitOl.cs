using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace BetaWerse
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BetaWerseVT;TrustServerCertificate=true;");

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Boş alan kontrolü
                if (txtAdSoyad.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "")
                {
                    MessageBox.Show("Kayıt işlemi başlatılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Open();
                    MessageBox.Show("Veritabanına bağlantı sağlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 2. Aynı kullanıcı adı var mı kontrol
                    SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Tbl_Kullanicilar WHERE KADI=@kadi", connection);
                    kontrol.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                    int kullaniciSayisi = (int)kontrol.ExecuteScalar();

                    if (kullaniciSayisi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı uygun, kayıt ekleniyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand ekle = new SqlCommand("INSERT INTO Tbl_Kullanicilar (ADSOYAD, KADI, KSIFRE) VALUES (@adsoyad, @kadi, @sifre)", connection);
                        ekle.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        ekle.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);
                        ekle.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        ekle.ExecuteNonQuery();

                        MessageBox.Show("Kayıt başarılı! Hoş geldiniz, " + txtAdSoyad.Text, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close(); // Formu kapat
                    }

                    connection.Close();
                    MessageBox.Show("Veritabanı bağlantısı kapatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
