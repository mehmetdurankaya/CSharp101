## 📌 C# Enum (Sabitler) Kavramı

Bu örnek, C# programlama dilinde enum (sabit listeleri) kavramını açıklamak ve gerçek bir senaryo üzerinde nasıl kullanılacağını göstermek için hazırlanmıştır.

## 🎯 Enum Nedir?

- Enum (Enumeration), birbiriyle ilişkili sabit değerleri isimlendirilebilir ve okunabilir bir biçimde tanımlamamızı sağlayan özel bir türdür.

- Kodun anlaşılabilirliğini artırır.

- Magic number (gizli sayılar) kullanımını ortadan kaldırır.

- Switch/if gibi akışlarda daha temiz kontrol sağlar.

## 📌 Enum Kullanmanın Avantajları

**✔ Değerlerin anlam kazanmasını sağlar.**
Örn: 25 yerine HavaDurumu.Sicak çok daha anlaşılırdır.

**✔ Harici sabit listeleri merkezi yönetilir.**

**✔ Sayısal karşılıkları otomatik veya isteğe göre verilebilir.**

**📎 Örnek Kod – Günler ve Hava Durumu Enum Yapısı**

Aşağıdaki kodda iki enum tanımı vardır:

Gunler → Haftanın günlerini temsil eder.

HavaDurumu → Sıcaklık durumuna göre seviyeleri temsil eder.

Bu enum'lar programın daha okunaklı olmasını sağlar.
```
namespace Enum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Gunler.Pazar);
      Console.WriteLine((int)Gunler.Cumartesi);

      int sicaklik = 32;

      if (sicaklik <= (int)HavaDurumu.Normal)
      {
        Console.WriteLine("Dışarıya çıkmak için havanın biraz ısınması bekleyelim.");
      }
      else if (sicaklik >= (int)HavaDurumu.Sicak)
      {
        Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
      }
      else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
      {
        Console.WriteLine("Hadi dışarıya çıkalım!");
      }
    }
  }

  enum Gunler
  {
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
  }

  enum HavaDurumu
  {
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
  }
}
```
## 🔍 Kodun Açıklaması
**✔ 1) Enum Değerini Yazdırmak**
```
Console.WriteLine(Gunler.Pazar);
```

Bu satır enum değerinin adını yazdırır → Pazar

**✔ 2) Enum’un Sayısal Karşılığını Yazdırmak**
```
Console.WriteLine((int)Gunler.Cumartesi);
```

Enum içindeki her elemanın aslında bir int değeri vardır.
Burada Cumartesi → 6

**✔ 3) Enum Kullanarak Sıcaklık Kontrolü**
```
if (sicaklik <= (int)HavaDurumu.Normal)
```

Burada sıcaklık değerini (32) enum’ın numeric (sayısal) karşılıklarıyla kıyaslıyoruz.

Bu sayede:

20 → Normal

25 → Sicak

30 → CokSicak

şeklinde daha açıklayıcı karşılaştırmalar yapılabiliyor.

## 🧠 Neden Enum Kullanmalıyım?

Aşağıdaki satır:
```

if (sicaklik <= 20)
```

çok açıklayıcı değildir.
Ama şöyle yazıldığında:
```
if (sicaklik <= (int)HavaDurumu.Normal)
```

Hem anlamlıdır hem de kodun kendisi dökümantasyon gibidir.

## 🎉 Sonuç

- Bu örnekle birlikte:

- Enum kavramının ne olduğunu,

- Sayısal karşılıkların nasıl çalıştığını,

- Gerçek bir senaryoda (hava durumu kontrolü) nasıl kullanılacağını
öğrenmiş oluyoruz.
