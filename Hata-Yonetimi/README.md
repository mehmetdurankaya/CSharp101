# Hata Yönetimi Örneği

Bu proje, C# programlama dilinde **try-catch-finally** yapısını kullanarak hata yönetiminin nasıl yapılacağını gösteren basit bir konsol uygulamasıdır.

---

## 📌 Amaç

* Kullanıcıdan giriş almak
* Olası hataları yakalamak
* Farklı istisna türleri için ayrı ayrı `catch` blokları kullanmak
* Programın çökmesini engellemek

---

## 📂 Kod Açıklaması

Aşağıdaki işlemler gerçekleştirilir:

1. **Kullanıcıdan sayı alma**

   * `Convert.ToInt32` ile veri türü dönüşümü yapılır.
   * Geçersiz girişlerde `Exception` yakalanır.

2. **Farklı hata türlerini yakalama**

   * `ArgumentNullException` → Boş değer gönderildiğinde
   * `FormatException` → Sayıya çevrilemeyen bir ifade girildiğinde
   * `OverflowException` → Değer int sınırlarını aştığında

---

## 🧩 Kullanılan Hata Türleri

### **ArgumentNullException**

Bir değişken `null` olup dönüşüm yapılamadığında oluşur.

### **FormatException**

Girilen veri sayısal formata dönüştürülemediğinde oluşur.

### **OverflowException**

Girilen değer int'in alabileceği minimum/maximum sınırı aştığında oluşur.

---

## ▶️ Program Akışı

```text
Kullanıcı bir değer girer →
   Geçerliyse sayı ekrana yazılır →
   Geçersizse uygun catch bloğu çalışır →
İkinci try bloğu int.Parse testleri yapar
```

---

## 🛠 Çalıştırma

Bu projeyi çalıştırmak için:

```bash
csc Program.cs
./Program.exe
```

---

## 📘 Örnek Hata Senaryoları

* "test" → FormatException
* "-20000000000" → OverflowException
* null → ArgumentNullException

---

## 📄 Notlar

* `finally` bloğu örnek olması açısından yorum satırı halindedir.
* İstendiğinde tüm koşullarda çalışan kod blokları için `finally` aktif edilebilir.

---

## 🧱 Geliştirilebilir Özellikler

* Tekrar deneyebilmek için döngü eklenebilir.
* Hatalar log dosyasına kaydedilebilir.
* Kullanıcıya daha açıklayıcı uyarılar gösterilebilir.

---


