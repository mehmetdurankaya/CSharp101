## 📘 Struct Kavramı – C# (Temel Seviye Öğretici)
📌 Struct Nedir?
C#’ta struct (yapı), hafif veri modelleri oluşturmak için kullanılan değer tipi bir yapıdır.
Bir struct oluşturduğunuzda verinin kendisi saklanır, referansı değil. Bu da struct’ı küçük ve taşınabilir veri modelleri için ideal yapar.
---
Struct:

- Değer tiptir (stack’te tutulur)

- new kullanılmadan da oluşturulabilir, ancak tüm alanlar mutlaka atanmalıdır

- Küçük, değiştirilebilir veri taşıyıcıları için uygundur

- Kalıtım (inheritance) desteklemez

- Varsayılan bir constructor'ı vardır ve alanlar otomatik olarak 0 gibi default değerlere atanır (new kullanıldığında)

📌 Struct Neden Kullanılır?

**Aşağıdaki durumlarda struct idealdir:**

- Küçük veri modelleri oluşturmak istiyorsan

- Nesnenin kısa ömürlü olacağı senaryolarda

- Kalıtıma ihtiyaç yoksa

- Bellek verimliliği önemliyse

- Sadece veri taşımak istiyorsan (point, rectangle, color gibi)

## 📂 Örneğin Anlattığı Yapı

Bu örnekte hem class hem de struct kullanılarak bir dikdörtgenin alanı hesaplanıyor.
Buradaki temel amaç, struct’ın class’tan farkını göstermek.

## Class örneğinde:

- new ile nesne oluşturulur

- Referans mantığıyla çalışır

## Struct örneğinde:

- new kullanılmadan da oluşturulabilir

- Ancak tüm alanların atanmış olması zorunludur

## 🧪 Kod Parçası – Struct ve Class Alan Hesabı
```
// CLASS - Referans Tipi
class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

// STRUCT - Değer Tipi
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}

🖥 Örnek Kullanım
Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;
Console.WriteLine(dikdortgen.AlanHesapla());

// Struct
Dikdortgen_Struct d = new Dikdortgen_Struct();
d.KisaKenar = 3;
d.UzunKenar = 4;
Console.WriteLine(d.AlanHesapla());
```
## 🎯 Struct'ı Öğrenirken Aklında Kalması Gereken 3 Şey

- **Struct = Değer tipi, Class = Referans tipi**

- **Struct küçük veri modelleri için tasarlanmıştır**

- **new kullanmazsan bile alanları kullanılmadan önce atamak zorundasın**

## ✔️ Sonuç

- Bu örnek, struct’ın:

- nasıl tanımlandığını,

- nasıl kullanıldığını,

- class ile farkını,

- değer tipi olduğunu,

- basit bir dikdörtgen alan hesabı üzerinden öğretmektedir.
---
