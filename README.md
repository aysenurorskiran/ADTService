# ADTService
Bu proje, N-katmanlı mimari ile geliştirilmiş; müşteri, randevu ve servis süreçlerini yöneten bir C# WinForms uygulamasıdır. Amacı: Mekanik servis gibi yoğun servislerin işini akışta tutmak.

# 📌 Proje Özellikleri
* Giriş Ekranı: Kullanıcıların girişi.
* Admin Rapor Sayfaları: Bir hizmeti ortalama çözüm süresi,ortalama verilen puan,talep türüne göre hizmet yoğunluğu,personel performans raporu ve müşteri talep raporu içerir.
* Bekleyen Randevu Talepleri: Müşterinin oluşturduğu,adminin onay/reddini bekleyen hizmetler.
* Görev Atama: Adminin personellere görev ataması.
* Müşteri Ekleme: Adminin müşterilerin tüm verilerine erişebildiği liste.
* Hizmetlerim: Müşterinin tüm hizmetlerini görüp paunladığı7şikayet ettiği ekran.
* Randevu Alma Sayfası: Müşterinin randevu talep edip,min fiyatı görüp ve kısaca arıza açıklaması yazdığı ekran.
* Personel Görev Ekranı: Personelin atanan görevi gördüğü ve yönetebildiği ekran.
* Şikayet Kutusu: Müşterilerden gelen şikayetleri gösteren ekran.

# 📂 Kullanılan Teknolojiler
* C# (.NET Framework)
* Windows Forms (Masaüstü uygulama tasarımı)
* MySQL (Veritabanı)
* Domain Layer: Katmanlı mimari (DAL, BLL)

# 📸 Ekran Görüntüleri

***1-Kullanıcı Giriş Ekranı***

![Kullanıcı Giriş Ekranı](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190527.png)

Kullanıcıların (Müşteri, Personel veya Yönetici) telefon numarası ve şifre bilgileriyle sisteme güvenli erişim sağladığı karşılama ekranıdır.

***2-Admin Rapor Sayfası***

![Admin Rapor Sayfası](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190554.png)

Servis genelindeki ortalama çözüm süresi, müşteri memnuniyet puanları, hizmet yoğunluğu ve personel performans grafiklerinin yer aldığı rapor (özet) ekranıdır.

***3-Admin Rapor Sayfası 2***

![Admin Rapor Sayfası 2-](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190609.png)

Kayıtlı müşterilerin listelendiği, tarih aralığına göre filtreleme yapılabilen ve toplam talep sayılarının takip edildiği raporlama arayüzüdür.

***4-Bekleyen Randevu Talepleri***

![Bekleyen Randevu Talepleri](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190621.png)

Müşterilerden gelen yeni servis taleplerinin görüntülendiği, yöneticinin bu talepleri onaylayabildiği veya iptal nedeni belirterek reddedebildiği onay ekranıdır.

***5-Görev Atama***

![Görev Atama](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190633.png)

Onaylanmış servis taleplerinin listeden seçilerek ilgili personele atandığı ve iş takibinin başlatıldığı yönetim ekranıdır.

***6-Müşteri Ekleme***

![Müşteri Ekle](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190645.png)

Yeni müşteri kaydı oluşturma, mevcut müşteri bilgilerini güncelleme veya silme işlemlerinin yapıldığı veri yönetim ekranıdır.

***7-Hizmetlerim***

![Hizmetlerim](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190907.png)

Müşterilerin geçmiş randevularını, tamamlanan işlemlerini ve ücret bilgilerini görebildiği; ayrıca hizmeti puanlayıp şikayet iletebildiği kullanıcı panelidir.

***8-Randevu Alma Sayfası***

![Randevu Alma Sayfası](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190917.png)

Müşterilerin araç bilgilerini girerek, hizmet türünü seçip arıza açıklamasıyla birlikte yeni bir servis randevusu oluşturduğu form ekranıdır.

***9-Personel Görev Ekranı***

![Personel Görev Ekranı](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190948.png)

Personele atanan işlerin listelendiği, personelin iş durumunu (Tamamlandı, Ertelendi vb.) güncelleyebildiği ve not ekleyebildiği çalışma ekranıdır.

***10-Şikayet Kutusu***

![Şikayet Kutusu](https://github.com/aysenurorskiran/ADTService/blob/main/README/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-15%20190959.png)

Müşteriler tarafından iletilen geri bildirimlerin ve şikayetlerin tarih sırasına göre listelendiği, çözüm takibi yapılan yönetim arayüz#

# 🚀 Kullanım
* 1.Projeyi [indirin](https://github.com/aysenurorskiran/ADTService.git)
* 2.Visual Studio kullanarak projeyi açın.
* 3.Gerekli MySQL bağlantı ayarlarını `Database.cs` dosyasından yapılandırın.
* 4.Uygulamayı çalıştırın ve giriş ekranından kullanıcı bilgilerinizi girerek başlayın.

# 🛠️ Proje Yapısı
* DAL (Data Access Layer): Veritabanı işlemleri.
* BLL (Business Logic Layer): İş mantığı.
* UI (User Interface): Windows Forms kullanıcı arayüzü.
* MySQL: Veritabanı bağlantı ve sorguları.

# ✨ Proje Hedefleri
* Mekanik servisleri dijitalleştirerek iş akışını hızlandırmak.
* Kullanıcı dostu arayüz ile kolay yönetim.
* Hizmet raporlama.

# 📞 İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin:
* Ad: Ayşenur
* Soyad: Örskıran
* Tel No:+90 543 295 67 27
* E-posta: aysenurorskirann@gmail.com

# ▶ Youtube Video
Youtube proje tanıtım videosu izlemek için [tıklayınız](https://youtu.be/KBXo0JTmMgs?si=LT2mBkh80saFzgdB)



