# 🏨 Hotel Tanıtım ve Yönetim Sistemi

![.NET](https://img.shields.io/badge/.NET-8.0-blue) ![C#](https://img.shields.io/badge/C%23-10.0-239120) ![License](https://img.shields.io/badge/license-MIT-green)

Bu proje, ASP.NET Core 8.0 ve N-Katmanlı Mimari kullanılarak geliştirilmiş kapsamlı bir otel tanıtım ve yönetim sistemidir. Sektörel ihtiyaçlara uygun olarak hem yönetici paneli hem de kullanıcı arayüzü ile tasarlanmıştır.

<img src="https://github.com/user-attachments/assets/d2fae62b-8cdc-425c-95be-a3a2761b1c23" alt="Ana Sayfa" style="width:100%; max-width:800px; border-radius:8px; box-shadow: 0 4px 8px rgba(0,0,0,0.1);" />

## 📖 Proje Özeti

Bu kapsamlı otel yönetim sistemi, modern web teknolojileri ve en iyi yazılım mühendisliği uygulamaları kullanılarak geliştirilmiştir. Sistem, otel işletmelerinin hem tanıtım hem de yönetim ihtiyaçlarını karşılamak üzere iki ana bileşenden oluşur:

1. **Yönetici Paneli:** CRUD işlemleri, istatistiksel analizler ve kapsamlı veri yönetimi
2. **Kullanıcı Arayüzü:** Modern, duyarlı tasarım ile otel tanıtımı ve müşteri etkileşimi

Proje, Udemy eğitim platformunda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında geliştirilmiştir.

## 📚 İçindekiler

- [Proje Özellikleri](#-proje-özellikleri)
- [Teknik Gereksinimler](#-teknik-gereksinimler)
- [Mimari Yapı](#-mimari-yapı)
- [Kurulum](#-kurulum)
- [API Endpoint'leri](#-api-endpointleri)
- [Veritabanı Şeması](#-veritabanı-şeması)
- [Test ve Debugging](#-test-ve-debugging)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)
- [İletişim](#-iletişim)

## 📋 Proje Özellikleri

### 🖱️ Yönetici Paneli
- **CRUD İşlemleri:** Tüm veri türleri (Oda, Hizmet, Personel, Rezervasyon, Hakkımızda, Referanslar) için kapsamlı oluşturma, okuma, güncelleme ve silme işlemleri
- **İstatistiksel Analizler:** Oda doluluk oranları, aylık rezervasyon eğilimleri, gelir analizleri ve personel performans metrikleri
- **Kullanıcı ve Rol Yönetimi:** ASP.NET Core Identity ile kullanıcı kimlik doğrulama, yetkilendirme ve rol tabanlı erişim kontrolü
- **Rezervasyon Yönetimi:** Rezervasyon durum takibi, onay/red işlemleri, müşteri bilgileri yönetimi
- **Personel Yönetimi:** Personel bilgileri, görev tanımları, iletişim bilgileri ve görev dağılımı
- **Hizmet Yönetimi:** Otel hizmetlerinin tanımlanması, açıklamaları, fiyatlandırması ve durum yönetimi
- **Müşteri Geri Bildirim Yönetimi:** Yorumların onay/red işlemleri, değerlendirme puanları ve müşteri memnuniyeti analizi

### 👤 Kullanıcı Arayüzü
- **Modern ve Duyarlı Tasarım:** Bootstrap 5 ile oluşturulmuş mobil uyumlu arayüz
- **Detaylı Oda Bilgileri:** Oda fotoğrafları, açıklamaları, fiyat bilgileri, özellikler ve müsaitlik durumu
- **Online Rezervasyon Sistemi:** Tarih seçimi, oda seçimi, müşteri bilgileri ile kolay rezervasyon
- **Hizmet Tanıtımı:** Otel hizmetlerinin detaylı açıklamaları ve görsellerle sunumu
- **İletişim Formu:** Doğrudan iletişim için mesaj gönderme imkanı
- **E-bülten Abonelik Sistemi:** Güncellemeler ve özel teklifler için abonelik
- **Hakkımızda Sayfası:** Kurumsal bilgiler ve değerlerin sunumu
- **Misafir Yorumları:** Otel deneyimi hakkında müşteri geri bildirimleri

## 🛠️ Teknik Gereksinimler

### Geliştirme Ortamı
- .NET 8.0 veya üzeri
- Visual Studio 2022 (önerilen) veya Visual Studio Code
- Microsoft SQL Server 2019+ veya SQL Server Express
- Node.js (NPM paket yönetimi için)
- Git sürüm kontrol sistemi

### Kullanılan Teknolojiler

#### Backend Teknolojileri
- **ASP.NET Core 8.0:** Web API ve MVC uygulamaları için çapraz platform framework
- **Entity Framework Core 8.0:** ORM (Object-Relational Mapping) aracı, Code First yaklaşımı
- **AutoMapper:** Nesneler arası eşleme işlemleri
- **FluentValidation:** Veri doğrulama işlemleri
- **Swagger/OpenAPI:** API dokümantasyonu ve test aracı
- **JWT Authentication:** Token tabanlı kimlik doğrulama
- **ASP.NET Core Identity:** Kullanıcı yönetimi ve kimlik doğrulama

#### Frontend Teknolojileri
- **HTML5/CSS3:** Yapısal işaretleme ve stil tanımlama
- **Bootstrap 5:** Responsive tasarım framework'ü
- **JavaScript (ES6+):** İstemci tarafı etkileşimler
- **jQuery:** DOM manipülasyonu ve AJAX işlemleri

#### Veritabanı
- **Microsoft SQL Server:** İlişkisel veritabanı yönetim sistemi
- **SQL Server Management Studio:** Veritabanı yönetimi için araç

## 📊 Mimari Yapı

Proje N-Katmanlı Mimari (N-Layered Architecture) yaklaşımı ile geliştirilmiştir. Bu mimari yapı, kodun sürdürülebilirliğini, test edilebilirliğini ve ölçeklenebilirliğini artırmak için kullanılmıştır.

### Katmanlar

#### 📦 Entity Layer
- Veritabanı nesnelerinin tanımlandığı katmandır
- Her bir entity sınıfı bir veritabanı tablosuna karşılık gelir
- Entity sınıfları arasında ilişkiler tanımlanmıştır
- Data Annotations ile veri doğrulama kuralları uygulanmıştır

#### 💾 DataAccess Layer
- Veritabanı ile iletişim kurulan katmandır
- Repository Pattern uygulanmıştır
- Generic repository yapısı ile kod tekrarı önlenmiştir
- Entity Framework Core kullanılarak veri işlemleri gerçekleştirilir

#### 🧠 Business Layer
- İş kurallarının tanımlandığı katmandır
- Abstract ve Concrete klasörleri ile soyut ve somut sınıflar ayrıştırılmıştır
- Dependency Injection ile bağımlılıklar yönetilir
- FluentValidation ile veri doğrulama işlemleri yapılır

#### 🔄 DTO Layer
- Veri transfer nesnelerinin bulunduğu katmandır
- API ile WebUI arasındaki veri transferini kolaylaştırır
- AutoMapper ile entity ve DTO nesneleri arasında eşleme yapılır

#### 🌐 WebAPI Layer
- RESTful API servislerinin bulunduğu katmandır
- Swagger ile dokümantasyon sağlanmıştır
- JWT ile kimlik doğrulama uygulanmıştır
- CRUD işlemleri için endpoint'ler tanımlanmıştır

#### 🖥️ WebUI Layer
- Kullanıcı arayüzünün (MVC) bulunduğu katmandır
- Admin paneli ve kullanıcı arayüzü olmak üzere iki temel bölüm içerir
- API consume işlemleri için IHttpClientFactory kullanılmıştır
- Razor Pages ve MVC yapısı ile geliştirilmiştir

## 🚀 Kurulum

### 📋 Önkoşullar

1. **.NET 8.0 SDK**'nın sisteminizde yüklü olduğundan emin olun
2. **Microsoft SQL Server** (2019 veya üzeri) yüklü olmalıdır
3. **Visual Studio 2022** veya **Visual Studio Code** önerilir
4. **Node.js** ve **NPM** (Frontend bağımlılıkları için)

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

#### Ortam Değişkenleri

Güvenlik için bazı ayarlar ortam değişkenleri olarak saklanmalıdır:

- `JWT_SECRET_KEY`: JWT token imzalama anahtarı
- `ADMIN_EMAIL`: Varsayılan admin kullanıcı e-posta
- `ADMIN_PASSWORD`: Varsayılan admin kullanıcı şifre

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
dotnet ef migrations add InitialCreate --project ApiConsume/DataAccess
dotnet ef database update
```

### 🧪 Uygulamayı Çalıştırma

#### Visual Studio ile:
1. Solution'ı açın
2. Başlangıç projelerini ayarlayın (WebAPI ve WebUI)
3. F5 ile debug başlatın

#### Komut Satırı ile:

```bash
# Frontend bağımlılıklarını yükleyin (ilk kez)
npm install

# API katmanını başlatma
cd ApiConsume/WebAPI
dotnet run

# Web arayüzünü başlatma (yeni terminal)
cd Frontend/HotelierAPI_WebUI
dotnet run
```

API varsayılan olarak `https://localhost:7000` ve `http://localhost:5000` adreslerinde,
Web arayüzü ise `https://localhost:7001` ve `http://localhost:5001` adreslerinde çalışacaktır.

### 🔐 Varsayılan Kullanıcı

Sistem ilk çalıştırıldığında otomatik olarak bir admin kullanıcısı oluşturulur:

- **Kullanıcı Adı:** admin@hotelier.com
- **Şifre:** Admin123!

Güvenlik için ilk girişten sonra şifreyi değiştirmeniz önerilir.

## 🌐 API Endpoint'leri

Sistem, RESTful prensiplerine uygun olarak tasarlanmış aşağıdaki endpoint'lere sahiptir:

### 🔐 Kimlik Doğrulama
- `POST /api/Login/Auth` - Kullanıcı girişi ve JWT token üretimi
  - **Request Body:** `{ "username": "string", "password": "string" }`
  - **Response:** JWT token ve kullanıcı bilgileri

### 🏠 Hakkımızda
- `GET /api/About` - Hakkımızda bilgilerini getir
- `GET /api/About/{id}` - Belirli bir hakkımızda kaydını getir
- `POST /api/About` - Yeni hakkımızda kaydı ekle
  - **Yetki Gerekli:** Admin
- `PUT /api/About/{id}` - Hakkımızda kaydını güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/About/{id}` - Hakkımızda kaydını sil
  - **Yetki Gerekli:** Admin

### 📅 Rezervasyonlar
- `GET /api/Booking` - Tüm rezervasyonları getir
  - **Yetki Gerekli:** Admin
- `GET /api/Booking/{id}` - Belirli bir rezervasyonu getir
  - **Yetki Gerekli:** Admin
- `POST /api/Booking` - Yeni rezervasyon ekle
  - **Public Endpoint** (Kullanıcılar tarafından kullanılabilir)
- `PUT /api/Booking/{id}` - Rezervasyonu güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/Booking/{id}` - Rezervasyonu sil
  - **Yetki Gerekli:** Admin

### 👥 Personel
- `GET /api/Staff` - Tüm personel bilgilerini getir
- `GET /api/Staff/{id}` - Belirli bir personeli getir
- `POST /api/Staff` - Yeni personel ekle
  - **Yetki Gerekli:** Admin
- `PUT /api/Staff/{id}` - Personel bilgisini güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/Staff/{id}` - Personeli sil
  - **Yetki Gerekli:** Admin

### 🛏️ Odalar
- `GET /api/Room` - Tüm odaları getir
- `GET /api/Room/{id}` - Belirli bir odayı getir
- `POST /api/Room` - Yeni oda ekle
  - **Yetki Gerekli:** Admin
- `PUT /api/Room/{id}` - Oda bilgisini güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/Room/{id}` - Odayı sil
  - **Yetki Gerekli:** Admin

### 🛠️ Hizmetler
- `GET /api/Service` - Tüm hizmetleri getir
- `GET /api/Service/{id}` - Belirli bir hizmeti getir
- `POST /api/Service` - Yeni hizmet ekle
  - **Yetki Gerekli:** Admin
- `PUT /api/Service/{id}` - Hizmet bilgisini güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/Service/{id}` - Hizmeti sil
  - **Yetki Gerekli:** Admin

### 📝 Yorumlar
- `GET /api/Testimonial` - Tüm yorumları getir
- `GET /api/Testimonial/{id}` - Belirli bir yorumu getir
- `POST /api/Testimonial` - Yeni yorum ekle
  - **Public Endpoint** (Kullanıcılar tarafından kullanılabilir)
- `PUT /api/Testimonial/{id}` - Yorumu güncelle
  - **Yetki Gerekli:** Admin
- `DELETE /api/Testimonial/{id}` - Yorumu sil
  - **Yetki Gerekli:** Admin

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
- `RoomSize` (int) - Oda boyutu (metrekare)

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

### 🔗 İlişkiler

Veritabanı şemasında aşağıdaki ilişkiler tanımlanmıştır:

- **AppUser** ve **AppRole** arasında çoktan çoğa (many-to-many) ilişki
- Diğer tablolar birbirinden bağımsızdır ancak aynı otel yönetim sistemini oluştururlar

## 🧪 Test ve Debugging

### Birim Testleri

Proje, iş katmanı bileşenleri için kapsamlı birim testleri içermektedir. Testler NUnit framework'ü kullanılarak geliştirilmiştir.

#### Test Katmanı Yapısı

- **Business.Tests:** İş katmanı bileşenleri için birim testler
- **DataAccess.Tests:** Veri erişim katmanı için testler
- **WebAPI.Tests:** API endpoint'leri için entegrasyon testleri

```bash
# Tüm testleri çalıştırmak için
dotnet test

# Belirli bir test projesini çalıştırmak için
dotnet test Business.Tests

# Test sonuçlarını ayrıntılı görmek için
dotnet test --verbosity detailed
```

### Debugging İpuçları

#### API Katmanı Hata Ayıklama
- Swagger UI üzerinden endpoint'leri test edin (`https://localhost:7000/swagger`)
- API yanıtlarında hata mesajlarını kontrol edin
- Log dosyalarını inceleyin (`logs` klasörü)

#### Veritabanı Sorunları
- `appsettings.json` dosyasındaki bağlantı dizesini kontrol edin
- SQL Server'ın çalışır durumda olduğundan emin olun
- Gerekirse yeni bir migration oluşturun

#### Entity Framework Sorunları
- Package Manager Console'da `Update-Database` komutunu çalıştırın
- Migration dosyalarını kontrol edin
- `dotnet ef database update` komutunu kullanın

#### Frontend Hataları
- Tarayıcı geliştirici araçlarını kullanarak console hatalarını inceleyin
- Network sekmesinden API çağrılarını kontrol edin
- CSS ve JavaScript dosyalarının doğru yüklendiğinden emin olun

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak isteyenler aşağıdaki adımları izleyebilir:

### Geliştirme Süreci

1. **Repository'yi fork'layın**
   - GitHub üzerinden projeyi kendi hesabınıza fork'layın

2. **Yeni bir özellik dalı oluşturun**
   ```bash
   git checkout -b ozellik/yeni-ozellik-adi
   ```

3. **Değişikliklerinizi uygulayın**
   - Kod yazın ve test edin
   - Gerekli dokümantasyonu güncelleyin

4. **Değişikliklerinizi commit'leyin**
   ```bash
   git commit -m 'Yeni özellik: kısa açıklama'
   ```

5. **Dalınızı push'layın**
   ```bash
   git push origin ozellik/yeni-ozellik-adi
   ```

6. **Pull Request oluşturun**
   - GitHub üzerinden orijinal repository'e pull request gönderin

### Kod Stili ve Standartlar

- C# kodlamada [Microsoft'un C# Kodlama Kuralları](https://docs.microsoft.com/tr-tr/dotnet/csharp/programming-guide/inside-a-program/coding-conventions) takip edilmelidir
- İsimlendirme kurallarına dikkat edilmelidir (PascalCase, camelCase)
- Yorum satırları Türkçe olarak yazılmalıdır
- Her yeni özellik için birim testleri yazılmalıdır

### Hata Bildirimi

- GitHub Issues üzerinden hata raporu oluşturun
- Hatanın tekrarlanabilir bir örneğini sağlayın
- Kullanılan ortam bilgilerini ekleyin (.NET sürümü, işletim sistemi vb.)

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Ticari kullanım için izin alınmalıdır.

## 📞 İletişim

Bu proje Udemy eğitim platformunda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında geliştirilmiştir.

Projeyle ilgili sorularınız için [e-posta] veya [GitHub issues] üzerinden iletişime geçebilirsiniz.
