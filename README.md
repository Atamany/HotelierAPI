# 🏨 HotelierAPI - Otel Yönetim Sistemi

> **Udemy Eğitim Platformu'nda Murat Yücedağ tarafından verilen "Asp.Net Core Api - Rapid Api ve Api Consume" eğitimi kapsamında tamamladığım proje.**

Bu proje, modern web teknolojileri kullanılarak geliştirilmiş kapsamlı bir otel yönetim sistemidir. N-tier mimari yaklaşımı ile tasarlanmış olan sistem, hem API hem de web arayüzü sunmaktadır.

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Teknolojiler](#️-teknolojiler)
- [Proje Mimarisi](#️-proje-mimarisi)
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

### 📊 Dashboard Widget Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/DashboardWidget/GetStaffCount` | Personel sayısını getir |
| GET | `/api/DashboardWidget/GetBookingCount` | Rezervasyon sayısını getir |
| GET | `/api/DashboardWidget/GetAppUserCount` | Kullanıcı sayısını getir |
| GET | `/api/DashboardWidget/GetRoomCount` | Oda sayısını getir |

### 🏨 Rezervasyon (Booking) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/BookingAPI` | Tüm rezervasyonları listele |
| POST | `/api/BookingAPI` | Yeni rezervasyon ekle |
| GET | `/api/BookingAPI/{id}` | ID'ye göre rezervasyon getir |
| PUT | `/api/BookingAPI/UpdateBooking` | Rezervasyon güncelle |
| DELETE | `/api/BookingAPI?id={id}` | Rezervasyon sil |
| PUT | `/api/BookingAPI/BookingApproved?id={id}` | Rezervasyon onayla |
| PUT | `/api/BookingAPI/BookingRejected?id={id}` | Rezervasyon reddet |
| GET | `/api/BookingAPI/GetLast6Booking` | Son 6 rezervasyonu getir |

### 🛏️ Oda (Room) Endpoint'leri

#### Room Controller
| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Room` | Tüm odaları listele |
| POST | `/api/Room` | Yeni oda ekle |
| GET | `/api/Room/{id}` | ID'ye göre oda getir |
| PUT | `/api/Room` | Oda güncelle |
| DELETE | `/api/Room?id={id}` | Oda sil |

#### Room2 Controller (DTO ile)
| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Room2` | Tüm odaları listele |
| POST | `/api/Room2` | DTO ile yeni oda ekle |
| PUT | `/api/Room2` | DTO ile oda güncelle |

### 👥 Personel (Staff) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Staff` | Tüm personeli listele |
| POST | `/api/Staff` | Yeni personel ekle |
| GET | `/api/Staff/{id}` | ID'ye göre personel getir |
| PUT | `/api/Staff` | Personel güncelle |
| DELETE | `/api/Staff?id={id}` | Personel sil |
| GET | `/api/Staff/GetLast4Staff` | Son 4 personeli getir |

### 👤 Misafir (Guest) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Guest` | Tüm misafirleri listele |
| POST | `/api/Guest` | Yeni misafir ekle |
| GET | `/api/Guest/{id}` | ID'ye göre misafir getir |
| PUT | `/api/Guest` | Misafir güncelle |
| DELETE | `/api/Guest?id={id}` | Misafir sil |

### 📧 İletişim (Contact) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Contact` | Tüm iletişim mesajlarını listele |
| POST | `/api/Contact` | Yeni iletişim mesajı ekle |
| GET | `/api/Contact/{id}` | ID'ye göre mesaj getir |
| GET | `/api/Contact/GetContactCount` | İletişim mesajı sayısını getir |

### 📤 Gönderilen Mesaj (SendMessage) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/SendMessage` | Tüm gönderilen mesajları listele |
| POST | `/api/SendMessage` | Yeni mesaj gönder |
| GET | `/api/SendMessage/{id}` | ID'ye göre mesaj getir |
| PUT | `/api/SendMessage` | Mesaj güncelle |
| DELETE | `/api/SendMessage?id={id}` | Mesaj sil |
| GET | `/api/SendMessage/GetSendMessageCount` | Gönderilen mesaj sayısını getir |

### 📂 Mesaj Kategorisi (MessageCategory) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/MessageCategory` | Tüm mesaj kategorilerini listele |
| POST | `/api/MessageCategory` | Yeni mesaj kategorisi ekle |
| GET | `/api/MessageCategory/{id}` | ID'ye göre kategori getir |
| PUT | `/api/MessageCategory` | Kategori güncelle |
| DELETE | `/api/MessageCategory?id={id}` | Kategori sil |

### 📰 Newsletter (Subscribe) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Subscribe` | Tüm aboneleri listele |
| POST | `/api/Subscribe` | Yeni abone ekle |
| GET | `/api/Subscribe/{id}` | ID'ye göre abone getir |
| PUT | `/api/Subscribe` | Abone güncelle |
| DELETE | `/api/Subscribe?id={id}` | Abone sil |

### 🏢 Çalışma Lokasyonu (WorkLocation) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/WorkLocation` | Tüm çalışma lokasyonlarını listele |
| POST | `/api/WorkLocation` | Yeni lokasyon ekle |
| GET | `/api/WorkLocation/{id}` | ID'ye göre lokasyon getir |
| PUT | `/api/WorkLocation` | Lokasyon güncelle |
| DELETE | `/api/WorkLocation?id={id}` | Lokasyon sil |

### 👤 Kullanıcı (AppUser) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/AppUser` | Çalışma lokasyonu ile birlikte kullanıcıları getir |

### 📝 Hakkında (About) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/About` | Tüm hakkında bilgilerini listele |
| POST | `/api/About` | Yeni hakkında bilgisi ekle |
| GET | `/api/About/{id}` | ID'ye göre hakkında bilgisi getir |
| PUT | `/api/About` | Hakkında bilgisi güncelle |
| DELETE | `/api/About?id={id}` | Hakkında bilgisi sil |

### 🎯 Hizmetler (Service) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Service` | Tüm hizmetleri listele |
| POST | `/api/Service` | Yeni hizmet ekle |
| GET | `/api/Service/{id}` | ID'ye göre hizmet getir |
| PUT | `/api/Service` | Hizmet güncelle |
| DELETE | `/api/Service?id={id}` | Hizmet sil |

### 💬 Müşteri Yorumları (Testimonial) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| GET | `/api/Testimonial` | Tüm müşteri yorumlarını listele |
| POST | `/api/Testimonial` | Yeni müşteri yorumu ekle |
| GET | `/api/Testimonial/{id}` | ID'ye göre yorum getir |
| PUT | `/api/Testimonial` | Yorum güncelle |
| DELETE | `/api/Testimonial?id={id}` | Yorum sil |

### 📁 Dosya İşlemleri (FileProcess) Endpoint'leri

| Method | Endpoint | Açıklama |
|--------|----------|----------|
| POST | `/api/FileProcess` | Dosya yükle |

### 📊 API İstatistikleri

- **Toplam Controller Sayısı:** 15
- **Toplam Endpoint Sayısı:** 70+
- **HTTP Method'ları:** GET, POST, PUT, DELETE
- **Ana Özellikler:** CRUD operasyonları, Dashboard istatistikleri, Dosya yükleme

### 🔗 Swagger Dokümantasyonu

Tüm endpoint'leri test etmek ve detaylı dokümantasyonu görmek için: https://localhost:7135/swagger

## 📸 Ekran Görüntüleri
<img src="https://github.com/user-attachments/assets/f9bb7c48-3945-432a-aafa-3e87f4cda8a2" width="1000px" title="Veri Tabanı" alt="Veri Tabanı">
<img src="https://github.com/user-attachments/assets/a64dd9c6-5c54-43dc-9790-6dd0b9c64921" width="1000px" title="Ana Sayfa" alt="Ana Sayfa">
<img src="https://github.com/user-attachments/assets/a4ae0750-e6b8-435e-9412-f85cf7550c6d" width="1000px" title="Rezervasyon" alt="Rezervasyon">
<img src="https://github.com/user-attachments/assets/a6684256-1324-49bc-bf57-5d0e44aeec4f" width="1000px" title="İletişim" alt="İletişim">
<img src="https://github.com/user-attachments/assets/a06f56ab-8a1d-4cc0-8359-4d100a65c633" width="1000px" title="Dashboard" alt="Dashboard">
<img src="https://github.com/user-attachments/assets/558a0bcc-c144-4973-9558-5ffeec65236f" width="1000px" title="Admin Rezervasyonlar" alt="Admin Rezervasyonlar">
<img src="https://github.com/user-attachments/assets/9f2028b6-335c-4071-b2c7-4dacebedd7c5" width="1000px" title="Admin Mesajlar" alt="Admin Mesajlar">
<img src="https://github.com/user-attachments/assets/ec9c48dc-80f1-4344-99d1-0c498ea62779" width="1000px" title="Giriş Paneli" alt="Giriş Paneli">
<img src="https://github.com/user-attachments/assets/fcceb8fc-123e-4697-92b7-f70cf94b173e" width="1000px" title="Kayıt Paneli" alt="Kayıt Paneli">

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

**Proje Sahibi:** Yiğit Ataman
- **Email:** yigitataman1@gmail.com
- **LinkedIn:** https://www.linkedin.com/in/yigitataman/
- **GitHub:** http://github.com/Atamany

## 🙏 Teşekkürler

- **Murat Yücedağ** - Udemy eğitimi için
- **Microsoft** - .NET ekosistemi için
- **Açık kaynak topluluğu** - Kullanılan kütüphaneler için

---

⭐ **Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!**
