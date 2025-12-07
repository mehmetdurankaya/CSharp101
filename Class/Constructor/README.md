## 📘 C# Constructor (Yapıcı Metot)
Bu proje, C# dilinde constructor (yapıcı metot) kullanımını örnekleyen basit bir sınıf yapısı içerir. Constructor’ların nasıl tanımlandığını, nasıl aşırı yüklendiğini (overloading) ve nesne oluşturma sürecindeki rollerini anlamaya odaklanır.
---

## 🔍 Constructor Nedir?

Constructor, bir sınıftan nesne oluşturulduğunda ilk çalışan özel metottur.
Amacı, nesnenin başlangıç değerlerini ayarlamak ve gerekli kurulumları yapmaktır.

**Constructor’ın özellikleri:**

- İsmi daima sınıf adıyla aynıdır.

- Geri dönüş tipi yoktur.

- new anahtar kelimesi ile nesne oluşturulduğunda otomatik çalışır.

- Parametre alabilir veya almadan da tanımlanabilir.

- Aşırı yüklenebilir (overloading).
---

## 🏗️ Calisan Sınıfındaki Constructor Yapıları

Bu projede Calisan sınıfında 3 farklı constructor tanımlanmıştır.

**1️⃣ Tam Parametreli Constructor**

Tüm çalışan bilgilerini başlatmak için:
```
public Calisan(string ad, string soyad, int no, string departman)
{
    this.Ad = ad;
    this.Soyad = soyad;
    this.No = no;
    this.Departman = departman;
}
```
**2️⃣ Parametresiz Constructor**

Nesne oluşturulup değerlerin sonradan atanabilmesi için:
```
public Calisan() { }
```
**3️⃣ Kısmi Constructor (Ad + Soyad)**

Bazı bilgilerin sonradan girileceği durumlarda:
```
public Calisan(string ad, string soyad)
{
    this.Ad = ad;
    this.Soyad = soyad;
}
```
## 🧪 Constructor Kullanımı
**✔ Tam parametreli kullanımı:**
```
Calisan c1 = new Calisan("Mehmet", "Kaya", 12345, "Bilgi İşlem");
```
**✔ Parametresiz kullanımı:**
```
Calisan c2 = new Calisan();
c2.Ad = "Nizamettin";
```
**✔ Sadece ad–soyad constructor’ı:**
```
Calisan c3 = new Calisan("Ertuğrul", "Kaya");
```
## 🎯 Özet

Bu örnek ile şu constructor özellikleri gösterilmiştir:

- **Nesne oluşturma sürecinde otomatik çalışma**

- **Parametreli ve parametresiz constructor yazımı**

- **Constructor overloading**

- **Başlangıç değerlerinin atanması**
---
