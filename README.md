# 🏨 HotelierAPI - Otel Yönetim Sistemi

> **Udemy Eğitim Platformu'nda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında tamamladığım proje.**

Bu proje, modern web teknolojileri kullanılarak geliştirilmiş kapsamlı bir otel yönetim sistemidir. N-tier mimari yaklaşımı ile tasarlanmış olan sistem, hem API hem de web arayüzü sunmaktadır.

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Proje Mimarisi](#-proje-mimarisi)
- [Kurulum](#-kurulum)
- [Kullanım](#-kullanım)
- [API Dokümantasyonu](#-api-dokümantasyonu)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Lisans](#-lisans)

## 🎯 Proje Hakkında

HotelierAPI, otel işletmelerinin günlük operasyonlarını yönetmek için tasarlanmış kapsamlı bir yönetim sistemidir. Sistem, rezervasyon yönetimi, oda yönetimi, personel takibi, misafir kayıtları ve istatistiksel raporlama gibi temel otel işlemlerini kapsar.

### 🎓 Eğitim Detayları
- **Eğitmen:** Murat Yücedağ
- **Platform:** Udemy
- **Eğitim Adı:** Asp.Net Core Api - Rapid Api ve Api Consume
- **Tamamlanma Tarihi:** 09.10.2025

## ✨ Özellikler

### 🔐 Kimlik Doğrulama ve Yetkilendirme
- ASP.NET Core Identity ile güvenli kullanıcı yönetimi
- Rol tabanlı yetkilendirme sistemi
- JWT token tabanlı kimlik doğrulama
- Güvenli oturum yönetimi

### 🏠 Rezervasyon Yönetimi
- Rezervasyon oluşturma, güncelleme ve silme
- Rezervasyon onaylama/reddetme işlemleri
- Rezervasyon durumu takibi
- Giriş/çıkış tarihi yönetimi
- Misafir bilgileri kayıt sistemi

### 🛏️ Oda Yönetimi
- Oda ekleme, düzenleme ve silme
- Oda özellikleri yönetimi (yatak sayısı, banyo, wifi vb.)
- Oda fiyatlandırma sistemi
- Oda görselleri yönetimi

### 👥 Personel Yönetimi
- Personel kayıt sistemi
- Personel bilgileri ve pozisyon takibi
- Sosyal medya hesapları entegrasyonu
- Personel fotoğraf yönetimi

### 📊 Dashboard ve İstatistikler
- Gerçek zamanlı istatistikler
- Sosyal medya takipçi sayıları (Instagram, X/Twitter)
- Rezervasyon, oda, personel ve kullanıcı sayıları
- Son 6 rezervasyon listesi
- Son 4 personel listesi

### 💬 İletişim Yönetimi
- Misafir mesajları yönetimi
- E-posta gönderme sistemi
- Mesaj kategorileri
- Newsletter abonelik sistemi

### 🎨 Modern Arayüz
- Responsive tasarım
- Admin paneli
- Kullanıcı dostu arayüz
- Bootstrap tabanlı modern UI

## 🛠️ Teknolojiler

### Backend
- **.NET 8.0** - Ana framework
- **ASP.NET Core Web API** - RESTful API geliştirme
- **ASP.NET Core MVC** - Web uygulaması
- **Entity Framework Core 8.0** - ORM
- **SQL Server** - Veritabanı
- **AutoMapper** - Obje mapping
- **FluentValidation** - Model doğrulama
- **Swagger** - API dokümantasyonu

### Frontend
- **ASP.NET Core MVC** - Web arayüzü
- **Bootstrap 5** - CSS framework
- **JavaScript/jQuery** - İstemci tarafı etkileşim
- **Chart.js** - Grafik ve istatistikler

### Güvenlik ve Kimlik Doğrulama
- **ASP.NET Core Identity** - Kullanıcı yönetimi
- **JWT (JSON Web Token)** - Token tabanlı kimlik doğrulama
- **Role-based Authorization** - Rol tabanlı yetkilendirme

### Harici API Entegrasyonları
- **RapidAPI Instagram Scraper** - Instagram takipçi sayıları
- **RapidAPI X/Twitter Scraper** - X/Twitter takipçi sayıları

### Geliştirme Araçları
- **Visual Studio 2022** - IDE
- **Git** - Versiyon kontrolü
- **NuGet** - Paket yönetimi

## 🏗️ Proje Mimarisi

Proje, **N-Tier (Katmanlı) Mimari** yaklaşımı ile tasarlanmıştır:

```
HotelierAPI/
├── ApiConsume/                    # API Katmanı
│   ├── HotelierAPI_WebAPI/        # Web API Projesi
│   ├── HotelierAPI_BusinessLayer/ # İş Mantığı Katmanı
│   ├── HotelierAPI_DataAccessLayer/# Veri Erişim Katmanı
│   ├── HotelierAPI_EntityLayer/   # Varlık Katmanı
│   └── HotelierAPI_DTOLayer/      # DTO Katmanı
└── Frontend/                      # Frontend Katmanı
    └── HotelierAPI_WebUI/         # Web UI Projesi
```

### Katman Açıklamaları

#### 1. **Entity Layer** (`HotelierAPI_EntityLayer`)
- Veritabanı tablolarını temsil eden entity sınıfları
- Ana modeller: `Booking`, `Room`, `Staff`, `Guest`, `Contact`, vb.

#### 2. **Data Access Layer** (`HotelierAPI_DataAccessLayer`)
- Entity Framework Core ile veritabanı işlemleri
- Repository Pattern implementasyonu
- Generic Repository kullanımı
- CRUD operasyonları

#### 3. **Business Layer** (`HotelierAPI_BusinessLayer`)
- İş mantığı kuralları
- Service katmanı
- Dependency Injection ile gevşek bağlılık

#### 4. **DTO Layer** (`HotelierAPI_DTOLayer`)
- Data Transfer Objects
- API ve UI arasında veri transferi
- Mapping işlemleri

#### 5. **Web API** (`HotelierAPI_WebAPI`)
- RESTful API endpoints
- Swagger dokümantasyonu
- CORS konfigürasyonu
- JWT authentication

#### 6. **Web UI** (`HotelierAPI_WebUI`)
- MVC pattern ile web arayüzü
- Admin paneli
- Responsive tasarım

## 🚀 Kurulum

### Gereksinimler
- .NET 8.0 SDK
- SQL Server (LocalDB veya Full)
- Visual Studio 2022 (önerilen)
- Git

### Adım 1: Projeyi Klonlayın
```bash
git clone https://github.com/kullaniciadi/HotelierAPI.git
cd HotelierAPI
```

### Adım 2: Veritabanı Bağlantısını Yapılandırın
`ApiConsume/HotelierAPI_DataAccessLayer/Concrete/Context.cs` dosyasında connection string'i güncelleyin:

```csharp
optionsBuilder.UseSqlServer("Server=YOUR_SERVER;initial Catalog=HotelierAPI;integrated Security=True; TrustServerCertificate=True;");
```

### Adım 3: Migration'ları Çalıştırın
```bash
cd ApiConsume/HotelierAPI_WebAPI
dotnet ef database update
```

### Adım 4: Projeyi Çalıştırın

#### API Projesini Başlatın:
```bash
cd ApiConsume/HotelierAPI_WebAPI
dotnet run
```
API şu adreste çalışacak: `https://localhost:7135`

#### Web UI Projesini Başlatın:
```bash
cd Frontend/HotelierAPI_WebUI
dotnet run
```
Web UI şu adreste çalışacak: `https://localhost:5001`

### Adım 5: İlk Kullanıcıyı Oluşturun
Uygulamayı ilk çalıştırdığınızda, admin kullanıcısı oluşturmanız gerekecektir.

## 📖 Kullanım

### API Kullanımı

#### Swagger Dokümantasyonu
API'nin Swagger dokümantasyonuna şu adresten erişebilirsiniz:
`https://localhost:7135/swagger`

#### Örnek API Çağrıları

**Rezervasyon Listesi:**
```http
GET https://localhost:7135/api/BookingAPI
```

**Yeni Rezervasyon Ekleme:**
```http
POST https://localhost:7135/api/BookingAPI
Content-Type: application/json

{
  "name": "John Doe",
  "mail": "john@example.com",
  "checkIn": "2024-01-15",
  "checkOut": "2024-01-20",
  "adultCount": "2",
  "childCount": "1",
  "roomCount": "1",
  "specialRequest": "Sea view room",
  "status": "Onay Bekliyor!"
}
```

### Web Arayüzü Kullanımı

1. **Giriş Yapma:** `/Login/Index` sayfasından giriş yapın
2. **Dashboard:** Ana sayfada istatistikleri görüntüleyin
3. **Rezervasyon Yönetimi:** Rezervasyonları görüntüleyin, onaylayın/reddedin
4. **Oda Yönetimi:** Odaları ekleyin, düzenleyin, silin
5. **Personel Yönetimi:** Personel bilgilerini yönetin

## 📚 API Dokümantasyonu

### Ana Endpoint'ler

| Controller | Endpoint | Method | Açıklama |
|------------|----------|--------|----------|
| BookingAPI | `/api/BookingAPI` | GET | Tüm rezervasyonları listele |
| BookingAPI | `/api/BookingAPI` | POST | Yeni rezervasyon ekle |
| BookingAPI | `/api/BookingAPI/{id}` | GET | ID'ye göre rezervasyon getir |
| BookingAPI | `/api/BookingAPI/UpdateBooking` | PUT | Rezervasyon güncelle |
| BookingAPI | `/api/BookingAPI` | DELETE | Rezervasyon sil |
| BookingAPI | `/api/BookingAPI/BookingApproved` | PUT | Rezervasyon onayla |
| BookingAPI | `/api/BookingAPI/BookingRejected` | PUT | Rezervasyon reddet |
| Room | `/api/Room` | GET | Tüm odaları listele |
| Room | `/api/Room` | POST | Yeni oda ekle |
| Staff | `/api/Staff` | GET | Tüm personeli listele |
| Guest | `/api/Guest` | GET | Tüm misafirleri listele |

### Dashboard Widget'ları

| Endpoint | Açıklama |
|----------|----------|
| `/api/DashboardWidget/GetStaffCount` | Personel sayısı |
| `/api/DashboardWidget/GetBookingCount` | Rezervasyon sayısı |
| `/api/DashboardWidget/GetAppUserCount` | Kullanıcı sayısı |
| `/api/DashboardWidget/GetRoomCount` | Oda sayısı |

## 📸 Ekran Görüntüleri


## 🔧 Geliştirme Notları

### Proje Yapısı
- **Clean Architecture** prensiplerine uygun tasarım
- **SOLID** prensiplerinin uygulanması
- **Dependency Injection** ile gevşek bağlılık
- **Repository Pattern** ile veri erişim soyutlaması

### Güvenlik Özellikleri
- ASP.NET Core Identity ile kullanıcı yönetimi
- JWT token tabanlı kimlik doğrulama
- Role-based authorization
- Anti-forgery token koruması
- HTTPS zorunluluğu

### Performans Optimizasyonları
- Async/await pattern kullanımı
- Entity Framework Core ile optimize edilmiş sorgular
- HttpClient factory pattern
- Memory cache kullanımı (gelecek sürümlerde)

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## 📞 İletişim

**Proje Sahibi:** [Yiğit Ataman]
- **Email:** [yigitataman1@gmail.com]
- **LinkedIn:** [https://www.linkedin.com/in/yigitataman/]
- **GitHub:** [http://github.com/Atamany]

## 🙏 Teşekkürler

- **Murat Yücedağ** - Udemy eğitimi için
- **Microsoft** - .NET ekosistemi için
- **Açık kaynak topluluğu** - Kullanılan kütüphaneler için

---

⭐ **Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!**
