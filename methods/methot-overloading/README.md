# C# Metot Aşırı Yükleme (Overloading) ve `out` Parametre Örneği
Bu proje, C# dilinde **`out` parametreleri**, **metot aşırı yükleme (method overloading)**, **metot imzası** ve **farklı parametre tipleriyle çalışan metotlar** üzerine hazırlanmış öğretici bir örnek içerir.

---

## 🎯 Amaç

Bu örnek ile aşağıdaki konuların mantığını kavrayabilirsin:

* `out` anahtar sözcüğü ile veri döndürme
* Aynı metot adını farklı parametrelerle kullanma (overloading)
* Metot imzası kavramı
* `TryParse` kullanımı
* Farklı parametre tipleriyle metot çağırma

---

## 🧩 Kod Açıklaması

### ✔ `TryParse` Örneği

```csharp
string sayi = "999";
bool sonuc = int.TryParse(sayi, out int outSayi);
```

* `TryParse`, string değeri integer'a dönüştürmeye çalışır.
* Başarılı olursa `true` döner ve sonucu `outSayi` değişkenine aktarır.

### ✔ `out` Parametre ile Toplama Metodu

`Metotlar` sınıfında iki adet `Topla` metodu vardır:

```csharp
public void Topla(int a, int b, out int toplam)
public void Topla(int a, int b, int c, out int toplam)
```

* Aynı isimli ama farklı parametre sayılı metotlar **overloading** örneğidir.
* Hesaplanan değer `out` ile dışarı aktarılır.

### ✔ `EkranaYazdir` Metotları (Overloading Örneği)

```csharp
public void EkranaYazdir(string veri)
public void EkranaYazdir(int veri)
public void EkranaYazdir(string veri1, string veri2)
```

Bu metotlar aynı işi yapar ancak farklı tür parametre kabul eder.

**Metot İmzası = Metot Adı + Parametre Tipleri + Parametre Sayısı**
Bu yüzden hepsi aynı isimde olabilir.

---

## 🔍 Kodun İşleyişi

Aşağıdaki işlemler sırasıyla gerçekleşir:

1. `"999"` değeri `int.TryParse` ile sayı ya dönüştürülür.
2. `Topla(4, 5, out toplamaSonucu)` çalışır.
3. `EkranaYazdir` metotları farklı parametrelerle çağrılır:

   * string
   * int
   * iki string

---

## 💻 Tam Kod

```csharp
namespace methodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      //out parametreler
      string sayi = "999";

      bool sonuc = int.TryParse(sayi, out int outSayi);
      if (sonuc)
      {
        System.Console.WriteLine("Başarılı!");
        System.Console.WriteLine(outSayi);
      }
      else
      {
        System.Console.WriteLine("Başarısız!");
      }

      Metotlar instance = new Metotlar();
      instance.Topla(4, 5, out int toplamaSonucu);
      System.Console.WriteLine(toplamaSonucu);

      //Metot Aşırı Yükleme - Overloading
      int ifade = 999;
      instance.EkranaYazdir(Convert.ToString(ifade));
      instance.EkranaYazdir(ifade);
      instance.EkranaYazdir("Mehmet Duran", "Kaya");
      //Metot Imzası
      //Metot adı + parametre sayısı + parametre tipi
    }
  }

  class Metotlar
  {
    public void Topla(int a, int b, out int toplam)
    {
      toplam = a + b;
    }
    public void Topla(int a, int b, int c, out int toplam)
    {
      toplam = a + b + c;
    }
    public void EkranaYazdir(string veri)
    {
      System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
      System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
      System.Console.WriteLine(veri1 + veri2);
    }
  }
}
```

---

## 🚀 Çalıştırma

```bash
dotnet run
```

---

