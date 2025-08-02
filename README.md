# 🏨 Hotel Tanıtım ve Yönetim Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-blue) ![C#](https://img.shields.io/badge/C%23-10.0-239120) ![License](https://img.shields.io/badge/license-MIT-green)

Bu proje, ASP.NET Core 8.0 ve N-Katmanlı Mimari kullanılarak geliştirilmiş kapsamlı bir otel tanıtım ve yönetim sistemidir. Sektörel ihtiyaçlara uygun olarak hem yönetici paneli hem de kullanıcı arayüzü ile tasarlanmıştır.

<img src="https://github.com/user-attachments/assets/d2fae62b-8cdc-425c-95be-a3a2761b1c23" alt="Ana Sayfa" style="width:100%; max-width:800px; border-radius:8px; box-shadow: 0 4px 8px rgba(0,0,0,0.1);" />

## 📖 Proje Özeti

Bu kapsamlı otel tanıtım ve yönetim sistemi, ASP.NET Core 8.0 teknolojisi ile geliştirilmiş modern bir web uygulamasıdır. Proje, N-Katmanlı Mimari yaklaşımıyla oluşturulmuş olup, hem yönetici paneli hem de kullanıcı arayüzü içermektedir. Sistem, otel işletmelerinin tanıtım, rezervasyon ve yönetim ihtiyaçlarını karşılamak üzere tasarlanmıştır.

## 📚 İçindekiler

- [Proje Özellikleri](#-proje-özellikleri)
- [Teknik Gereksinimler](#-teknik-gereksinimler)
- [Mimari Yapı](#-mimari-yapı)
- [Proje Yapısı](#-proje-yapısı)
- [Kurulum](#-kurulum)
- [API Endpoint'leri](#-api-endpointleri)
- [Veritabanı Şeması](#-veritabanı-şeması)
- [Lisans](#-lisans)
- [İletişim](#-iletişim)

## 📋 Proje Özellikleri

### 🖱️ Yönetici Paneli
- **CRUD İşlemleri:** Oda, Hizmet, Personel, Rezervasyon, Hakkımızda, Referans ve Abonelik için kapsamlı oluşturma, okuma, güncelleme ve silme işlemleri
- **Kullanıcı ve Rol Yönetimi:** ASP.NET Core Identity ile kullanıcı kimlik doğrulama ve rol tabanlı erişim kontrolü
- **Rezervasyon Yönetimi:** Rezervasyon durum takibi ve müşteri bilgileri yönetimi
- **İstatistiksel Analizler:** Oda doluluk oranları ve diğer istatistiksel veriler

### 👤 Kullanıcı Arayüzü
- **Modern ve Duyarlı Tasarım:** Bootstrap 5 ile oluşturulmuş mobil uyumlu arayüz
- **Detaylı Oda Bilgileri:** Oda fotoğrafları, açıklamaları ve fiyat bilgileri
- **Online Rezervasyon Sistemi:** Kolay rezervasyon oluşturma
- **Hizmet Tanıtımı:** Otel hizmetlerinin detaylı açıklamaları
- **İletişim Formu:** Doğrudan iletişim için mesaj gönderme imkanı
- **E-bülten Abonelik Sistemi:** Güncellemeler için abonelik
- **Hakkımızda Sayfası:** Kurumsal bilgilerin sunumu
- **Misafir Yorumları:** Otel deneyimi hakkında müşteri geri bildirimleri

## 🛠️ Teknik Gereksinimler

### Geliştirme Ortamı
- .NET 8.0 SDK
- Visual Studio 2022 veya Visual Studio Code
- Microsoft SQL Server (LocalDB veya tam sürüm)
- Git sürüm kontrol sistemi

### Kullanılan Teknolojiler

#### Backend Teknolojileri
- **ASP.NET Core 8.0 Web API:** RESTful API servisleri
- **Entity Framework Core 8.0:** ORM (Object-Relational Mapping) aracı
- **AutoMapper:** Nesneler arası eşleme işlemleri
- **Swagger/OpenAPI:** API dokümantasyonu ve test aracı
- **ASP.NET Core Identity:** Kullanıcı yönetimi ve kimlik doğrulama

#### Frontend Teknolojileri
- **HTML5/CSS3:** Yapısal işaretleme ve stil tanımlama
- **Bootstrap 5:** Responsive tasarım framework'ü
- **JavaScript:** İstemci tarafı etkileşimler
- **jQuery:** DOM manipülasyonu

#### Veritabanı
- **Microsoft SQL Server:** İlişkisel veritabanı yönetim sistemi

## 📊 Mimari Yapı

Proje N-Katmanlı Mimari (N-Layered Architecture) yaklaşımı ile geliştirilmiştir:

### Katmanlar

#### 📦 Entity Layer (HotelierAPI_EntityLayer)
- Veritabanı nesnelerinin tanımlandığı katmandır
- Her bir entity sınıfı bir veritabanı tablosuna karşılık gelir

#### 💾 DataAccess Layer (HotelierAPI_DataAccessLayer)
- Veritabanı ile iletişim kurulan katmandır
- Repository Pattern uygulanmıştır
- Entity Framework Core kullanılarak veri işlemleri gerçekleştirilir

#### 🧠 Business Layer (HotelierAPI_BusinessLayer)
- İş kurallarının tanımlandığı katmandır
- Abstract ve Concrete klasörleri ile soyut ve somut sınıflar ayrıştırılmıştır
- Dependency Injection ile bağımlılıklar yönetilir

#### 🌐 WebAPI Layer (HotelierAPI_WebAPI)
- RESTful API servislerinin bulunduğu katmandır
- Swagger ile dokümantasyon sağlanmıştır
- CRUD işlemleri için endpoint'ler tanımlanmıştır

#### 🖥️ WebUI Layer (HotelierAPI_WebUI)
- Kullanıcı arayüzünün (MVC) bulunduğu katmandır
- Admin paneli ve kullanıcı arayüzü olmak üzere iki temel bölüm içerir
- API consume işlemleri için IHttpClientFactory kullanılmıştır

## 📁 Proje Yapısı

```
HotelierAPI/
├── ApiConsume/
│   ├── HotelierAPI_BusinessLayer/
│   ├── HotelierAPI_DataAccessLayer/
│   ├── HotelierAPI_DTOLayer/
│   ├── HotelierAPI_EntityLayer/
│   └── HotelierAPI_WebAPI/
├── Frontend/
│   └── HotelierAPI_WebUI/
├── HotelierAPI.sln
└── README.md
```

## 🚀 Kurulum

### 📋 Önkoşullar

1. **.NET 8.0 SDK**'nın sisteminizde yüklü olduğundan emin olun
2. **Microsoft SQL Server** yüklü olmalıdır
3. **Visual Studio 2022** veya **Visual Studio Code** önerilir

### 📥 Projeyi İndirme

```bash
# GitHub üzerinden klonlama
git clone https://github.com/kullaniciadi/HotelierAPI.git
cd HotelierAPI
```

### ⚙️ Veritabanı Yapılandırması

Veritabanı bağlantı dizesi `ApiConsume/HotelierAPI_DataAccessLayer/Concrete/Context.cs` dosyasında tanımlanmıştır:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer("Server=YIGITATAMANPC;initial Catalog=HotelierAPI;integrated Security=True; TrustServerCertificate=True;");
}
```

Kendi ortamınıza göre bağlantı dizesini güncelleyin.

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
dotnet ef migrations add InitialCreate --project ApiConsume/HotelierAPI_DataAccessLayer
dotnet ef database update --project ApiConsume/HotelierAPI_DataAccessLayer
```

### 🧪 Uygulamayı Çalıştırma

#### Visual Studio ile:
1. Solution'ı açın
2. Başlangıç projelerini ayarlayın (HotelierAPI_WebAPI ve HotelierAPI_WebUI)
3. F5 ile debug başlatın

#### Komut Satırı ile:

```bash
# API katmanını başlatma
cd ApiConsume/HotelierAPI_WebAPI
dotnet run

# Web arayüzünü başlatma (yeni terminal)
cd Frontend/HotelierAPI_WebUI
dotnet run
```

API varsayılan olarak `https://localhost:7000` adresinde,
Web arayüzü ise `https://localhost:7001` adresinde çalışacaktır.

## 🌐 API Endpoint'leri

Sistem, RESTful prensiplerine uygun olarak tasarlanmış aşağıdaki endpoint'lere sahiptir:

### 🏠 Hakkımızda
- `GET /api/About` - Tüm hakkımızda kayıtlarını getir
- `GET /api/About/{id}` - Belirli bir hakkımızda kaydını getir
- `POST /api/About` - Yeni hakkımızda kaydı ekle
- `PUT /api/About` - Hakkımızda kaydını güncelle
- `DELETE /api/About/{id}` - Hakkımızda kaydını sil

### 📅 Rezervasyonlar
- `GET /api/BookingAPI` - Tüm rezervasyonları getir
- `GET /api/BookingAPI/{id}` - Belirli bir rezervasyonu getir
- `POST /api/BookingAPI` - Yeni rezervasyon ekle
- `PUT /api/BookingAPI/UpdateBooking` - Rezervasyonu güncelle
- `DELETE /api/BookingAPI/{id}` - Rezervasyonu sil

### 👥 Personel
- `GET /api/Staff` - Tüm personel bilgilerini getir
- `GET /api/Staff/{id}` - Belirli bir personeli getir
- `POST /api/Staff` - Yeni personel ekle
- `PUT /api/Staff` - Personel bilgisini güncelle
- `DELETE /api/Staff/{id}` - Personeli sil

### 🛏️ Odalar
- `GET /api/Room` - Tüm odaları getir
- `GET /api/Room/{id}` - Belirli bir odayı getir
- `POST /api/Room` - Yeni oda ekle
- `PUT /api/Room` - Oda bilgisini güncelle
- `DELETE /api/Room/{id}` - Odayı sil

### 🛠️ Hizmetler
- `GET /api/Service` - Tüm hizmetleri getir
- `GET /api/Service/{id}` - Belirli bir hizmeti getir
- `POST /api/Service` - Yeni hizmet ekle
- `PUT /api/Service` - Hizmet bilgisini güncelle
- `DELETE /api/Service/{id}` - Hizmeti sil

### 📝 Yorumlar
- `GET /api/Testimonial` - Tüm yorumları getir
- `GET /api/Testimonial/{id}` - Belirli bir yorumu getir
- `POST /api/Testimonial` - Yeni yorum ekle
- `PUT /api/Testimonial` - Yorumu güncelle
- `DELETE /api/Testimonial/{id}` - Yorumu sil

### 📧 Abonelikler
- `GET /api/Subscribe` - Tüm abonelikleri getir
- `GET /api/Subscribe/{id}` - Belirli bir aboneliği getir
- `POST /api/Subscribe` - Yeni abonelik ekle
- `PUT /api/Subscribe` - Aboneliği güncelle
- `DELETE /api/Subscribe/{id}` - Aboneliği sil

Tüm API endpoint'lerine erişim için Swagger arayüzü `https://localhost:7000/swagger` adresinden erişilebilir.

## 🗄️ Veritabanı Şeması

Sistem aşağıdaki tablolardan oluşan ilişkisel veritabanı yapısını kullanmaktadır:

### 🏢 About (Hakkımızda)
- `AboutId` (int, PK) - Birincil anahtar
- `Title1` (string) - Başlık 1
- `Title2` (string) - Başlık 2
- `Content` (string) - İçerik
- `RoomCount` (int) - Oda Sayısı
- `StaffCount` (int) - Personel Sayısı
- `CustomerCount` (int) - Müşteri Sayısı

### 👥 AppUser (Uygulama Kullanıcısı)
- `Id` (int, PK) - Birincil anahtar
- `UserName` (string) - Kullanıcı adı
- `Name` (string) - Ad
- `Surname` (string) - Soyad
- `Email` (string) - E-posta
- `PasswordHash` (byte[]) - Şifre hash değeri
- `PasswordSalt` (byte[]) - Şifre salt değeri
- `City` (string) - Şehir (nullable)

### 🔐 AppRole (Uygulama Rolü)
- `Id` (int, PK) - Birincil anahtar
- `Name` (string) - Rol adı

### 📅 Booking (Rezervasyon)
- `BookingID` (int, PK) - Birincil anahtar
- `Name` (string) - İsim
- `Mail` (string) - E-posta
- `CheckIn` (DateTime) - Giriş tarihi
- `CheckOut` (DateTime) - Çıkış tarihi
- `AdultCount` (string) - Yetişkin sayısı
- `ChildCount` (string) - Çocuk sayısı
- `RoomCount` (string) - Oda sayısı
- `SpecialRequest` (string) - Özel istekler
- `Description` (string) - Açıklama
- `Status` (string) - Durum

### 👥 Guest (Misafir)
- `GuestID` (int, PK) - Birincil anahtar
- `Name` (string) - Ad
- `Surname` (string) - Soyad
- `City` (string) - Şehir

### 🛏️ Room (Oda)
- `RoomId` (int, PK) - Birincil anahtar
- `RoomNumber` (string) - Oda numarası
- `RoomCoverImage` (string) - Kapak görseli
- `Price` (int) - Fiyat
- `Title` (string) - Başlık
- `BedCount` (string) - Yatak sayısı
- `BathCount` (string) - Banyo sayısı
- `Wifi` (string) - WiFi durumu
- `Description` (string) - Açıklama

### 🛠️ Service (Hizmet)
- `ServiceId` (int, PK) - Birincil anahtar
- `ServiceIcon` (string) - Hizmet ikonu
- `Title` (string) - Başlık
- `Description` (string) - Açıklama

### 👥 Staff (Personel)
- `StaffID` (int, PK) - Birincil anahtar
- `Name` (string) - Ad
- `Title` (string) - Unvan
- `PhotoUrl` (string) - Fotoğraf URL
- `SocialMedia1` (string) - Sosyal medya 1
- `SocialMedia2` (string) - Sosyal medya 2
- `SocialMedia3` (string) - Sosyal medya 3

### 📧 Subscribe (Abonelik)
- `SubscribeID` (int, PK) - Birincil anahtar
- `Mail` (string) - E-posta

### 📝 Testimonial (Referans/Yorum)
- `TestimonialID` (int, PK) - Birincil anahtar
- `Name` (string) - Ad
- `Title` (string) - Unvan
- `Description` (string) - Açıklama
- `Image` (string) - Görsel URL

### 🔗 İlişkiler

Veritabanı şemasında aşağıdaki ilişkiler tanımlanmıştır:

- **AppUser** ve **AppRole** arasında çoktan çoğa (many-to-many) ilişki
- Diğer tablolar birbirinden bağımsızdır ancak aynı otel yönetim sistemini oluştururlar

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Ticari kullanım için izin alınmalıdır.

## 📞 İletişim

Bu proje Udemy eğitim platformunda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında geliştirilmiştir.

Projeyle ilgili sorularınız için [e-posta] veya [GitHub issues] üzerinden iletişime geçebilirsiniz.
