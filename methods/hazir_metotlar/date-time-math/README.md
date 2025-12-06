# DateTime ve Math Kütüphanesi Örnekleri

Bu proje, .NET'in **DateTime** ve **Math** kütüphanelerini pratik örneklerle gösteren basit bir C# konsol uygulamasıdır. Kod, tarih/saat bilgileriyle ilgili temel işlemleri ve matematiksel fonksiyonları içeren kapsamlı bir demo sunar.

---

## 📅 DateTime Kullanımı

C# `DateTime` yapısı güncel tarih, saat ve bunlarla ilgili işlemleri yapmayı sağlar. Aşağıdaki örnekler kodda gösterilmiştir:

### **Temel Bilgiler**

* `DateTime.Now` → Şu anki tarih ve saat
* `DateTime.Now.Date` → Sadece tarih
* `DateTime.Now.Day` → Gün
* `DateTime.Now.Month` → Ay
* `DateTime.Now.Year` → Yıl
* `DateTime.Now.Hour` → Saat
* `DateTime.Now.Minute` → Dakika
* `DateTime.Now.Second` → Saniye
* `DateTime.Now.DayOfWeek` → Haftanın günü
* `DateTime.Now.DayOfYear` → Yılın kaçıncı günü

### **Formatlama**

* `ToLongDateString()` → Örn. "Sunday, 24 August 2025"
* `ToShortDateString()` → Örn. "24.08.2025"
* `ToLongTimeString()` → "18:24:05"
* `ToShortTimeString()` → "18:24"

### **Tarih Üzerinde İşlemler**

* `AddDays(2)` → 2 gün ekler
* `AddHours(3)` → 3 saat ekler
* `AddSeconds(30)` → 30 saniye ekler
* `AddMonths(5)` → 5 ay ekler
* `AddYears(10)` → 10 yıl ekler
* `AddMilliseconds(50)` → 50 ms ekler

### **Formatlama Örnekleri**

* `dd` → Gün (24)

* `ddd` → Kısa gün adı (Sun)

* `dddd` → Uzun gün adı (Sunday)

* `MM` → Ay (08)

* `MMM` → Kısa ay adı (Aug)

* `MMMM` → Uzun ay adı (August)

* `yy` → Yılın son iki hanesi (25)

* `yyyy` → Tam yıl (2025)

---

## 🔢 Math Kütüphanesi Kullanımı

C# `Math` sınıfı matematiksel işlemler için geniş bir fonksiyon yelpazesi sunar.

### **Temel Fonksiyonlar**

* `Math.Abs(-25)` → Mutlak değer
* `Math.Sin(10)` → Sinüs
* `Math.Cos(10)` → Kosinüs
* `Math.Tan(10)` → Tanjant

### **Yuvarlama İşlemleri**

* `Math.Ceiling(22.3)` → 23 (Yukarı yuvarlar)
* `Math.Round(22.3)` → 22 (En yakına yuvarlar)
* `Math.Round(22.7)` → 23
* `Math.Floor(22.7)` → 22 (Aşağı yuvarlar)

### **Karşılaştırmalar**

* `Math.Max(2,6)` → 6
* `Math.Min(2,6)` → 2

### **Diğer Fonksiyonlar**

* `Math.Pow(3,4)` → 81 (Üs alma)
* `Math.Sqrt(9)` → 3 (Karekök)
* `Math.Log(9)` → 9'un e tabanındaki logaritması
* `Math.Exp(3)` → e³ değeri
* `Math.Log10(10)` → 10'un logaritması

---

## 🚀 Çalıştırma

Uygulamayı çalıştırmak için:

```bash
dotnet run
```

---

## 📁 Proje Amacı

Bu proje, DateTime ve Math sınıflarının kullanımını öğrenmek isteyenler için bir referans niteliği taşır. Hem temel hem de sık kullanılan fonksiyonlar tek bir kod bloğunda toplanmıştır.

---

Hazırlayan: **Mehmet Duran Kaya**
