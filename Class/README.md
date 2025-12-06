## 📘 Class ve Constructor Kullanımı
Bu proje, C# dilinde sınıf yapısı (class), erişim belirleyiciler, constructor (yapıcı metod) ve nesne kullanımı konularını örnekleyerek açıklayan basit bir console uygulamasıdır.
---

## 🎯 Projenin Amacı

Bu uygulamada amaç:

- Bir sınıf tanımlamak

- Birden fazla constructor oluşturup aşırı yükleme yapmak (constructor overloading)

- Nesne üzerinden veri atamak

- Nesne özelliklerini (property/field) ekrana yazdırmak

- Bir sınıfın yapısını anlamak
---

## 🧩 Kullanılan Yapılar
✔ Calisan Sınıfı

Bu sınıf bir çalışanın temel bilgilerini tutar:

- Ad

- Soyad

- No

- Departman

✔ Erişim Belirleyiciler

Kodda şu erişim belirleyiciler açıklanmış ve kullanılmıştır:

- public

- private (örnek yapılmadı ancak açıklaması mevcut)

- internal

- protected

## 🏗️ Constructor’lar

Calisan sınıfında 3 adet constructor bulunur:

1️⃣ **Tüm bilgileri alan constructor**
**public Calisan(string ad, string soyad, int no, string departman)**


**Tüm çalışan bilgilerini oluşturmaya yarar.**

2️⃣ **Parametresiz constructor**
```
public Calisan() { }
```

Daha sonra değer ataması yapmak isteyenler için.

3️⃣ **Sadece ad ve soyad alan constructor**
```
public Calisan(string ad, string soyad)
```

Numara ve departman bilgisi olmadan çalışan oluşturmak için.

## 🖨️ Metot: CalisanBilgileri()

Bu metot çalışan ile ilgili tüm bilgileri console ekranına yazdırır:
```
public void CalisanBilgileri()
{
    Console.WriteLine("Çalışanın Adı: {0}", Ad);
    Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
    Console.WriteLine("Çalışanın Numarası: {0}", No);
    Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
}
```
## 🧪 Program Akışı
✔ 1. Çalışan

Tüm bilgileri constructor ile verilir.
```
Calisan calisan1 = new Calisan("Mehmet Duran", "Kaya", 1111111, "Bilgi İşlem");
```
✔ 2. Çalışan

Parametresiz constructor kullanılır, bilgiler sonradan atanır:
```
Calisan calisan2 = new Calisan();
calisan2.Ad = "Nizamettin";
calisan2.Soyad = "Kaya";
calisan2.No = 22222222;
calisan2.Departman = "Muhasebe";
```
✔ 3. Çalışan

Sadece ad-soyad constructor’ı kullanılır:
```
Calisan calisan3 = new Calisan("Ertuğrul", "Kaya");
Console.WriteLine($"{calisan3.Ad} {calisan3.Soyad}");
```
## 📌 Özet

Bu proje ile:

- Class yapısının temelleri

- Nesne üretimi

- Constructor çeşitleri

- Nesne içi metot kullanımı

- gibi OOP’in temel taşları pratik bir şekilde gösterilmiştir.

---
