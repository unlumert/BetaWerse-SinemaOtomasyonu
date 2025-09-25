📌 Projeyi Açma ve Çalıştırma Adımları

1)  Projeyi açma
    -   Proje_Kaynak_Kod.zip dosyasını çıkarın.
    -   Visual Studio içinde .sln dosyasını açın.
    -   NuGet paketleri otomatik olarak indirilecektir.
2)  Veritabanını kurma (.bak yöntemi)
    -   SQL Server Management Studio (SSMS)’i açın.
    -   Sol tarafta Databases (Veritabanları) üzerine sağ tıklayın →
        Restore Database (Veritabanını Geri Yükle) seçeneğini seçin.
    -   Açılan pencerede:
        -   Source (Kaynak) bölümünde Device (Cihaz) seçin.
        -   Browse (…) butonuna basın → .bak dosyasını seçin (örn.
            BetaWerseVT.bak).
        -   Database (Veritabanı adı) kısmında veritabanı adını
            BetaWerseVT olarak belirleyin.
    -   OK diyerek geri yükleme işlemini tamamlayın.

      Not: Eğer connection string içinde farklı bir veritabanı adı
      yazıyorsa, app.config veya appsettings.json dosyasında Initial
      Catalog=BetaWerseVT olacak şekilde güncelleyin.
3)  Projeyi çalıştırma
    -   Visual Studio’da Start (F5) tuşuna basarak uygulamayı
        çalıştırın.
