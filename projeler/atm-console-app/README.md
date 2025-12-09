# ATM Console Uygulaması (OOP - C#)

Bu proje, bir ATM'nin temel fonksiyonlarını simüle eden **OOP tabanlı C# Console uygulamasıdır**.  
Uygulama şu özellikleri içerir:

- Kullanıcı doğrulama (kayıt / giriş)
- Para çekme, para yatırma, ödeme yapma, bakiye görüntüleme
- Transaction (işlem) kaydı (uygulama belleğinde)
- Hatalı giriş (fraud) kayıtları
- Gün sonu (EOD) raporunu `EOD_ddMMyyyy.txt` formatında dosyaya yazma
- Kullanıcı verilerini `users.txt` dosyasında saklama (username;password;balance)

---

## Başlarken

1. .NET SDK yüklü olduğundan emin olun.
2. Projeyi klonlayın veya dosyaları yeni bir console projesine ekleyin.
3. Terminalde proje klasöründe çalıştırın:

```bash
dotnet run
Dosya Yapısı
/ATMApp
│
├── Program.cs
├── Data
│   └── Database.cs
├── Models
│   ├── User.cs
│   └── Transaction.cs
└── Services
    ├── AuthService.cs
    ├── ATMService.cs
    ├── TransactionService.cs
    └── FileLogger.cs
```
users.txt Formatı

users.txt dosyası uygulama kökünde bulunur. Satır biçimi:
```
username;password;balance
```

Örnek:
```
turan;1234;5000
ali;abcd;2500
```

Uygulama yoksa başlangıçta birkaç kullanıcı ile seed (oluşturur).

## Kullanım Akışı

1. Program başlatılır.

2. Kullanıcı adı istenir.

3. Kullanıcı sistemde yoksa kayıt olma seçeneği sunulur.

4. Kayıtlı kullanıcı şifre girer (3 hatalı deneme loglanır).

5. Kullanıcı menüden işlem seçer:

- Bakiye görüntüleme

- Para yatırma

- Para çekme

- Ödeme yapma

- Gün sonu (EOD) alma -> EOD_ddMMyyyy.txt oluşturulur ve transaction + fraud logları yazılır

6. Çıkış yapıldığında users.txt güncellenir (bakiye vb.).

## Güvenlik Notları

- Bu örnek proje öğreticidir; şifreler düz metin olarak saklanmıştır. Gerçek uygulamalarda şifreler hash ve salt ile korunmalıdır.

- Dosya tabanlı basit bir veritabanı kullanılmıştır. Geliştirmek için SQLite veya başka bir veritabanı ekleyebilirsiniz.
