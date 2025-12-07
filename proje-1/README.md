## 📞 Telefon Rehberi Uygulaması

Console tabanlı bir telefon rehberi uygulamasıdır. Kullanıcı; kişi ekleyebilir, silebilir, güncelleyebilir, listeleyebilir veya rehberde arama yapabilir. Uygulama, sorumlulukların ayrı sınıflara bölündüğü, okunabilirliği yüksek bir mimari yaklaşımıyla geliştirilmiştir.
---

## 🚀 Özellikler
**✔ Yeni Numara Kaydet**

- **Kullanıcıdan isim, soyisim ve telefon numarası bilgileri alınarak rehbere eklenir.**

**✔ Varolan Numarayı Sil**

- **Kullanıcının girdiği isim veya soyisime göre arama yapılır.**
- **Eşleşme bulunursa silme onayı istenir, onaylanırsa kişi silinir.**

- **✔ Varolan Numarayı Güncelle**

-- **Kullanıcının girdiği isim veya soyisime göre mevcut kişi bulunur ve bilgileri güncellenir.**

**✔ Rehberi Listele (A-Z / Z-A)**

Rehberde bulunan tüm kişiler alfabetik veya ters alfabetik sıralamayla listelenebilir.

**✔ Rehberde Arama**

- İsim veya soyisime göre

- Telefon numarasına göre
- arama yapılabilir.

## 📂 Proje Yapısı
TelefonRehberi
│
├── Program.cs
├── Person.cs
├── PhoneBook.cs
│
├── AddOperation.cs
├── DeleteOperation.cs
├── UpdateOperation.cs
├── ListOperation.cs
└── SearchOperation.cs

## 🔎 Sınıfların Sorumlulukları
| Dosya                  | Açıklama                                                          |
| ---------------------- | ----------------------------------------------------------------- |
| **Program.cs**         | Tüm işlemlerin kullanıcıyla etkileşime geçtiği ana giriş noktası. |
| **Person.cs**          | Kişi bilgilerini tutan veri modeli.                               |
| **PhoneBook.cs**       | Rehberi (person listesi) yöneten temel yapı.                      |
| **AddOperation.cs**    | Yeni kişi ekleme işlemi.                                          |
| **DeleteOperation.cs** | Kişi silme işlemi.                                                |
| **UpdateOperation.cs** | Kişi bilgilerini güncelleme işlemi.                               |
| **ListOperation.cs**   | Rehberdeki kişileri listeler.                                     |
| **SearchOperation.cs** | Rehber içinde arama yapar.                                        |

## 🧩 Çalışma Mantığı

- Uygulama başladığında kullanıcıya bir işlem menüsü sunulur.
- Her seçenek, ilgili sınıftaki metoda yönlendirilir.

Örnek menü:
```
Lütfen yapmak istediğiniz işlemi seçiniz :)
*******************************************
(1) Yeni Numara Kaydetmek
(2) Varolan Numarayı Silmek
(3) Varolan Numarayı Güncelleme
(4) Rehberi Listelemek
(5) Rehberde Arama Yapmak
```
## 🗃 Varsayılan Veri

Uygulama ilk çalıştığında otomatik olarak 5 kişilik bir rehber oluşturulur:

Mehmet Duran Kaya

Fatma Kaya

Nizamettin Kaya

Atahan Şahinbaş

İrem Şahinbaş

## ⚙ Kullanım Talimatları
## ▶ Projeyi Çalıştırmak

Projeyi Visual Studio veya Rider ile açın.

Program.cs ana çalıştırılabilir dosyadır.

Run (▶) tuşuna basarak uygulamayı başlatın.

## 🛠 Geliştirme Notları

Bu yapı temel bir rehber uygulaması sunar. Geliştirilmeye açıktır.

İstersen:

Interface tabanlı bir Service katmanı

Dependency Injection

Unit Test

Veritabanı (EF Core) entegrasyonu

Loglama mekanizması

ekleyerek gerçek bir kurumsal düzey uygulamaya dönüştürebiliriz.

## 📄 Lisans

Bu proje tamamen eğitim amaçlıdır ve özgürce genişletilebilir.
---
