
## 🎯 Voting Uygulaması (OOP – C# Console)

Bu proje, pre-defined (önceden tanımlanmış) kategoriler arasında kullanıcıların oy verebildiği basit bir OOP tabanlı C# Console uygulamasıdır.
Sisteme kayıtlı kullanıcılar oy verebilir, kayıtlı olmayanlar ise otomatik olarak kayıt olup oylamaya devam edebilir.

Uygulama sonunda oylama sonuçları sayısal ve yüzdesel olarak gösterilir.

## 🧱 Özellikler

- Pre-defined kategoriler başlangıçta otomatik olarak yüklenir.

- Kullanıcı giriş sistemi:

- Kullanıcı varsa → direkt oy verebilir

- Kullanıcı yoksa → otomatik kayıt edilir

- Her kullanıcı sadece bir kez oy verebilir.

- Oylar kategori sayacına işlenir.

- Uygulama sonunda sonuçlar:

- Her kategori için toplam oy

- Yüzde hesaplaması şeklinde gösterilir.

- Tamamen OOP (Object-Oriented Programming) prensiplerine göre yazılmıştır.

- SRP (Single Responsibility Principle) uygulanmıştır.

- Katmanlı yapı kullanılmıştır.

## 📂 Proje Yapısı
```
/VotingApp
│
├── Program.cs
│
├── Data
│   └── Database.cs
│
├── Models
│   ├── User.cs
│   └── Category.cs
│
└── Services
    ├── UserService.cs
    └── VotingService.cs
```
## 🧠 Kullanılan Kavramlar

- Class & Nesne Yapısı

- Encapsulation

- List Koleksiyonları

- Service Yapısı

- Static Database Simülasyonu

- Input Validation

- Percentage Calculation (Yüzdelik Oranı)

## 🚀 Kurulum ve Çalıştırma

- Projeyi bilgisayarınıza indirin veya klonlayın.

- Terminali proje klasöründe açın.

Console uygulamasını başlatın:
```
dotnet run
```
## 🗳 Kullanım Akışı

1. Uygulama açılır.

2. Kullanıcıdan username istenir.

3. Kullanıcı:

- Sistemde varsa → direkt oylamaya geçer

- Yoksa → kayıt edilir ve oylamaya geçer

4. Kullanıcı listelenen kategorilerden birini seçer.

5. Oy kaydedilir.

6. Uygulama sonunda oylama sonuçları gösterilir.

## 📝 Örnek Çalışma
Input:
```
username: turan
Seçim: 2
```
Output:
```
Oyunuz başarıyla kaydedildi!

=== OYLAMA SONUÇLARI ===
Film: 0 oy (%0.00)
Tech Stack: 1 oy (%100.00)
Spor: 0 oy (%0.00)

Toplam Oy: 1
```
## 🔧 Pre-defined Kategoriler
```
Categories.Add(new Category("Film"));
Categories.Add(new Category("Tech Stack"));
Categories.Add(new Category("Spor"));
```
Bu kategoriler uygulama başlatıldığında otomatik yüklenir.
---

