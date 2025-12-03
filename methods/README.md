# C# Metotlar

Bu proje, C# programlama dilinde metot kullanımı, parametre yapıları, `ref` anahtar sözcüğü ve sınıf/metot ilişkilerini gösteren basit bir örnek içerir.

---

## 📌 Amaç

Bu örneğin amacı aşağıdaki kavramları pratik bir şekilde göstermek:

* Metot tanımlama ve geri dönüş değerleri
* Parametre ile veri gönderimi
* `ref` ile referans üzerinden veri güncelleme
* Sınıf içerisinde metot kullanımı
* Konsola çıktı yazdırma

---

## 🧩 Proje Açıklaması

Kod içerisinde iki sınıf bulunmaktadır:

### **1. Program Sınıfı**

Bu sınıf içinde:

* `Topla(int, int)` isimli statik bir metot bulunur.
* `Main` metodu içinde değişkenler tanımlanır, metotlar çağrılır ve sonuçlar ekrana yazdırılır.

### **2. Metotlar Sınıfı**

Bu sınıf iki metot içerir:

* **EkranaYazdir(string veri)** → Konsola veri yazdırır.
* **ArttirVeTopla(ref int deger1, ref int deger2)** → Parametreleri bir artırır ve toplamı döndürür. `ref` sayesinde orijinal değişkenler güncellenir.

---

## 🔍 Kodun İşleyişi

Başlangıçta:

```
a = 2
b = 3
```

**Topla(a, b)** → sonuç: 5

**ArttirVeTopla(ref a, ref b)** çağrılınca:

* a = 3 olacak
* b = 4 olacak
* dönüş değeri = 7

Son durumda **a + b = 7** olur.

---

## 💻 Örnek Kod

```csharp
using System;
namespace methods
{
  class Program
  {
    public static void Main(string[] args)
    {
      int a = 2;
      int b = 3;
      Console.WriteLine(a + b);

      int sonuc = Topla(a, b);
      Console.WriteLine(sonuc);

      Metotlar ornek = new Metotlar();
      ornek.EkranaYazdir(Convert.ToString(sonuc));

      int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
      ornek.EkranaYazdir(Convert.ToString(sonuc2));
      ornek.EkranaYazdir(Convert.ToString(a + b));
    }

    static int Topla(int deger1, int deger2)
    {
      return (deger1 + deger2);
    }
  }

  class Metotlar
  {
    public void EkranaYazdir(string veri)
    {
      Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
      deger1 += 1;
      deger2 += 1;
      return deger1 + deger2;
    }
  }
}
```

---

## 🚀 Çalıştırma

Projenizi çalıştırmak için:

```bash
dotnet run
```

---
