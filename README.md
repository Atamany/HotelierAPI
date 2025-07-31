# 🏨 Hotel Tanıtım ve Yönetim Sistemi

Bu proje, ASP.NET Core 8.0 ve N-Katmanlı Mimari kullanılarak geliştirilmiş kapsamlı bir otel tanıtım ve yönetim sistemidir. Sektörel ihtiyaçlara uygun olarak hem yönetici paneli hem de kullanıcı arayüzü ile tasarlanmıştır.

<img src="https://i.hizliresim.com/crbhiuk.png" alt="Ana Sayfa" style="width:100%; max-width:800px; border-radius:8px; box-shadow: 0 4px 8px rgba(0,0,0,0.1);" />

## 📋 Proje Özellikleri

### 🖱️ Yönetici Paneli
- CRUD işlemleri ile veri yönetimi
- Gerçek zamanlı istatistiksel analizler
- Kullanıcı ve rol tabanlı yetkilendirme
- Rezervasyon takibi ve yönetimi
- Personel bilgileri yönetimi
- Hizmet tanımlama ve güncelleme
- Müşteri geri bildirim yönetimi

### 👤 Kullanıcı Arayüzü
- Modern ve duyarlı tasarım
- Detaylı oda bilgileri ve görseller
- Online rezervasyon sistemi
- Hizmet tanıtımı ve açıklamalar
- İletişim formu
- E-bülten abonelik sistemi

## 🛠️ Teknik Gereksinimler

### Geliştirme Ortamı
- .NET 8.0 veya üzeri
- Visual Studio 2022
- Microsoft SQL Server 2019+

### Kullanılan Teknolojiler
- **Backend:** ASP.NET Core 8.0, Entity Framework Core 8.0
- **Frontend:** HTML5, CSS3, Bootstrap 5, JavaScript
- **Veritabanı:** Microsoft SQL Server
- **Güvenlik:** ASP.NET Core Identity, JWT Authentication
- **Diğer:** AutoMapper, Fluent Validation, Swagger

## 📊 Mimari Yapı

Proje N-Katmanlı Mimari yaklaşımı ile geliştirilmiştir:

- **Entity Layer:** Veritabanı nesneleri
- **DataAccess Layer:** Veri erişim işlemleri
- **Business Layer:** İş kuralları ve işlemler
- **DTO Layer:** Veri transfer nesneleri
- **WebAPI Layer:** RESTful API servisleri
- **WebUI Layer:** Kullanıcı arayüzü (MVC)

## 🚀 Kurulum

### 📋 Önkoşullar

1. **.NET 8.0 SDK**'nın sisteminizde yüklü olduğundan emin olun
2. **Microsoft SQL Server** (2019 veya üzeri) yüklü olmalıdır
3. **Visual Studio 2022** veya **Visual Studio Code** önerilir

### 📥 Projeyi İndirme

```bash
# GitHub üzerinden klonlama
git clone https://github.com/kullaniciadi/HotelierAPI.git
cd HotelierAPI
```

veya doğrudan ZIP dosyası olarak indirip çıkarabilirsiniz.

### ⚙️ Yapılandırma

#### Veritabanı Bağlantısı

`appsettings.json` dosyasında bağlantı dizesini güncelleyin:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=HotelierDb;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

### 🗄️ Veritabanı Oluşturma

#### Package Manager Console ile:

```powershell
# DataAccess katmanında çalıştırın
Add-Migration InitialCreate
Update-Database
```

#### Dotnet CLI ile:

```bash
# Proje kök dizininde çalıştırın
dotnet ef migrations add InitialCreate --project DataAccessLayer
dotnet ef database update
```

### 🧪 Uygulamayı Çalıştırma

#### Visual Studio ile:
1. Solution'ı açın
2. Başlangıç projelerini ayarlayın (WebAPI ve WebUI)
3. F5 ile debug başlatın

#### Komut Satırı ile:

```bash
# API katmanını başlatma
cd ApiConsume/WebAPI
dotnet run

# Web arayüzünü başlatma
cd Frontend/HotelierAPI_WebUI
dotnet run
```

API varsayılan olarak `https://localhost:7000` ve `http://localhost:5000` adreslerinde,
Web arayüzü ise `https://localhost:7001` ve `http://localhost:5001` adreslerinde çalışacaktır.

## 🌐 API Endpoint'leri

Sistem, RESTful prensiplerine uygun olarak tasarlanmış aşağıdaki endpoint'lere sahiptir:

### 🔐 Kimlik Doğrulama
- `POST /api/Login/Auth` - Kullanıcı girişi ve JWT token üretimi

### 🏠 Hakkımızda
- `GET /api/About` - Hakkımızda bilgilerini getir
- `GET /api/About/{id}` - Belirli bir hakkımızda kaydını getir
- `POST /api/About` - Yeni hakkımızda kaydı ekle
- `PUT /api/About/{id}` - Hakkımızda kaydını güncelle
- `DELETE /api/About/{id}` - Hakkımızda kaydını sil

### 📅 Rezervasyonlar
- `GET /api/Booking` - Tüm rezervasyonları getir
- `GET /api/Booking/{id}` - Belirli bir rezervasyonu getir
- `POST /api/Booking` - Yeni rezervasyon ekle
- `PUT /api/Booking/{id}` - Rezervasyonu güncelle
- `DELETE /api/Booking/{id}` - Rezervasyonu sil

### 👥 Personel
- `GET /api/Staff` - Tüm personel bilgilerini getir
- `GET /api/Staff/{id}` - Belirli bir personeli getir
- `POST /api/Staff` - Yeni personel ekle
- `PUT /api/Staff/{id}` - Personel bilgisini güncelle
- `DELETE /api/Staff/{id}` - Personeli sil

### 🛏️ Odalar
- `GET /api/Room` - Tüm odaları getir
- `GET /api/Room/{id}` - Belirli bir odayı getir
- `POST /api/Room` - Yeni oda ekle
- `PUT /api/Room/{id}` - Oda bilgisini güncelle
- `DELETE /api/Room/{id}` - Odayı sil

### 🛠️ Hizmetler
- `GET /api/Service` - Tüm hizmetleri getir
- `GET /api/Service/{id}` - Belirli bir hizmeti getir
- `POST /api/Service` - Yeni hizmet ekle
- `PUT /api/Service/{id}` - Hizmet bilgisini güncelle
- `DELETE /api/Service/{id}` - Hizmeti sil

### 📝 Yorumlar
- `GET /api/Testimonial` - Tüm yorumları getir
- `GET /api/Testimonial/{id}` - Belirli bir yorumu getir
- `POST /api/Testimonial` - Yeni yorum ekle
- `PUT /api/Testimonial/{id}` - Yorumu güncelle
- `DELETE /api/Testimonial/{id}` - Yorumu sil

Tüm API endpoint'lerine erişim için Swagger arayüzü `https://localhost:7000/swagger` adresinden erişilebilir.

## 🗄️ Veritabanı Şeması

Sistem aşağıdaki tablolardan oluşan ilişkisel veritabanı yapısını kullanmaktadır:

### 🏢 About (Hakkımızda)
- `AboutID` (int, PK) - Birincil anahtar
- `Title` (string) - Başlık
- `Description` (string) - Açıklama
- `ImageUrl` (string) - Görsel URL

### 👥 AppUser (Uygulama Kullanıcısı)
- `Id` (int, PK) - Birincil anahtar
- `UserName` (string) - Kullanıcı adı
- `Name` (string) - Ad
- `Surname` (string) - Soyad
- `Email` (string) - E-posta
- `PasswordHash` (byte[]) - Şifre hash değeri
- `PasswordSalt` (byte[]) - Şifre salt değeri

### 🔐 AppRole (Uygulama Rolü)
- `Id` (int, PK) - Birincil anahtar
- `Name` (string) - Rol adı

### 📅 Booking (Rezervasyon)
- `BookingID` (int, PK) - Birincil anahtar
- `Name` (string) - İsim
- `Mail` (string) - E-posta
- `Checkin` (DateTime) - Giriş tarihi
- `Checkout` (DateTime) - Çıkış tarihi
- `AdultCount` (int) - Yetişkin sayısı
- `ChildCount` (int) - Çocuk sayısı
- `RoomCount` (int) - Oda sayısı
- `SpecialRequest` (string) - Özel istekler
- `Description` (string) - Açıklama
- `Status` (string) - Durum

### 🛏️ Room (Oda)
- `RoomID` (int, PK) - Birincil anahtar
- `Title` (string) - Başlık
- `Description` (string) - Açıklama
- `ImageUrl` (string) - Görsel URL
- `Price` (decimal) - Fiyat
- `BedCount` (int) - Yatak sayısı
- `BathCount` (int) - Banyo sayısı
- `Wifi` (bool) - WiFi durumu
- `RoomSize` (int) - Oda boyutu

### 🛠️ Service (Hizmet)
- `ServiceID` (int, PK) - Birincil anahtar
- `Title` (string) - Başlık
- `Description` (string) - Açıklama
- `ImageUrl` (string) - Görsel URL

### 👥 Staff (Personel)
- `StaffID` (int, PK) - Birincil anahtar
- `Name` (string) - Ad
- `Title` (string) - Unvan
- `ImageUrl` (string) - Görsel URL
- `FacebookUrl` (string) - Facebook URL
- `TwitterUrl` (string) - Twitter URL
- `InstagramUrl` (string) - Instagram URL

### 📧 Subscribe (Abonelik)
- `SubscribeID` (int, PK) - Birincil anahtar
- `Mail` (string) - E-posta

### 📝 Testimonial (Referans/Yorum)
- `TestimonialID` (int, PK) - Birincil anahtar
- `Name` (string) - Ad
- `Title` (string) - Unvan
- `Description` (string) - Açıklama
- `ImageUrl` (string) - Görsel URL

## 🧪 Test ve Debugging

### Birim Testleri
Proje, iş katmanı bileşenleri için birim testleri içermektedir. Testler NUnit framework'ü kullanılarak geliştirilmiştir.

```bash
# Testleri çalıştırmak için
dotnet test
```

### Debugging İpuçları
- API katmanında hata ayıklama için Swagger UI kullanılabilir
- Veritabanı bağlantı sorunlarında `appsettings.json` dosyasını kontrol edin
- Entity Framework migration hatalarında Package Manager Console'u kullanın
- Frontend hatalarında tarayıcı geliştirici araçlarını kullanın

## 🤝 Katkıda Bulunma

1. Repository'yi fork'layın
2. Yeni bir özellik dalı oluşturun (`git checkout -b yeni-ozellik`)
3. Değişikliklerinizi commit'leyin (`git commit -m 'Yeni özellik eklendi'`)
4. Dalınızı push'layın (`git push origin yeni-ozellik`)
5. Bir Pull Request oluşturun

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Ticari kullanım için izin alınmalıdır.

## 📞 İletişim

Bu proje Udemy eğitim platformunda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında geliştirilmiştir.

Projeyle ilgili sorularınız için [e-posta] veya [GitHub issues] üzerinden iletişime geçebilirsiniz.
