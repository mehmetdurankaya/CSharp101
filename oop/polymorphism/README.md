## C# Inheritance (Kalıtım) Örneği – Canlılar, Bitkiler ve Hayvanlar Hiyerarşisi

Bu proje, C# dilinde inheritance (kalıtım) kavramını anlamak için hazırlanmış örnek bir sınıf hiyerarşisini içerir. Canlıların ortak özelliklerini üst sınıfta toplayıp, alt sınıflara miras verilerek hem tekrar eden kodlardan kaçılması hem de hiyerarşik bir yapı kurulması hedeflenmiştir.
---
## 🌱 Proje Amacı

Bu örnek, kalıtımın nasıl çalıştığını;

üst sınıftaki metotların alt sınıflardan erişilmesini,

protected erişim belirtecinin amacını,

türlere özgü davranışların alt sınıflarda nasıl tanımlandığını
göstermektedir.
---
## 🧬 Sınıf Hiyerarşisi

Aşağıdaki yapı kullanılmıştır:

                Canlilar
                /     \
         Bitkiler      Hayvanlar
         /     \        /      \
TohumluBitkiler TohumsuzBitkiler Sürüngenler Kuşlar
---
## 🧩 Sınıfların Görevleri
Canlilar (Base Class)

Tüm canlılarda ortak olan davranışları içerir:

- Beslenme

- Solunum

- Boşaltım

- Bu metotlar protected olduğu için sadece türetilmiş sınıflar tarafından kullanılabilir.

Bitkiler (Canlilar’dan türeyen)

Ek olarak:

- Fotosentez yapma kabiliyeti

- TohumluBitkiler & TohumsuzBitkiler

- Bitkilerin özel davranışlarını içerir:

- Tohumla çoğalma

- Sporla çoğalma

**Her biri kurucu metotta bitkilere ait ortak fonksiyonları base üzerinden çağırır.**

**Hayvanlar (Canlilar’dan türeyen)**

Ek olarak:

- Adaptasyon yapabilme

- Sürüngenler & Kuşlar

- Her türün kendine özgü hareket biçimi vardır:

- Sürüngenler → Sürünerek hareket eder

**Kuşlar → Uçar**

- Kuşlar ayrıca canlılara ait temel fonksiyonları kurucu metotta çağırır.

💡 Kod Akışı

Program.cs içinde:
```
TohumluBitkiler tohumluBitki = new TohumluBitkiler();
tohumluBitki.TohumlaCogalma();

Console.WriteLine("*********************");

Kuslar marti = new Kuslar();
marti.Ucmak();
```

Bu akış;

- Tohumlu bitkilerin temel canlı davranışlarını miras aldığını,

- Kuşların hem hayvan hem de canlı özelliklerini kullandığını gösterir.

## 🧠 Bu Örnek Ne Öğretir?

- Kalıtımın temel mantığı

- **base keyword kullanımını

- **protected erişim belirteciyle kapsülleme**

- **Kod tekrarını azaltma**

- **Hiyerarşik sınıf yapısı oluşturma**

- **Polimorfizme geçiş için temel alt yapı**
---
