## C# ile Nesne Yönelimli Programlama (OOP)
Bu proje, C# programlama dili kullanılarak Nesne Yönelimli Programlama (OOP) kavramlarını anlamanızı ve uygulamanızı kolaylaştırmak için hazırlanmıştır. OOP, yazılım geliştirmede kodun daha organize, yeniden kullanılabilir ve yönetilebilir olmasını sağlayan bir yaklaşımdır.
---

## İçindekiler

- OOP Kavramları

- Sınıflar ve Nesneler

- Constructor (Kurucu Metotlar)

- Encapsulation (Kapsülleme)

- Inheritance (Kalıtım)

- Polymorphism (Çok Biçimlilik)

- Static Sınıflar ve Üyeler

- Struct ve Enum Kavramları

- Boxing ve Unboxing

- Referans ve Değer Tipleri
---

**OOP Kavramları**

C# dilinde OOP, aşağıdaki temel kavramlarla uygulanır:

- Class (Sınıf): Nesnelerin şablonu. Özellikler ve metotlar içerir.

- Object (Nesne): Sınıfın bir örneği.

- Encapsulation (Kapsülleme): Verilerin ve metotların bir sınıf içinde gizlenmesi ve kontrollü erişim sağlanması.

- Inheritance (Kalıtım): Bir sınıfın özellik ve metotlarını başka bir sınıfa aktarma.

- Polymorphism (Çok Biçimlilik): Bir nesnenin farklı şekillerde davranabilmesi.

**Sınıflar ve Nesneler** 
```
class Calisan
{
    public string Ad;
    public string Soyad;

    public void BilgileriGoster()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}

Calisan calisan1 = new Calisan();
calisan1.Ad = "Mehmet";
calisan1.Soyad = "Kaya";
calisan1.BilgileriGoster();


Class: Calisan sınıfı, çalışanlara ait bilgileri tutar.

Object: calisan1 nesnesi, sınıfın örneğidir.

Constructor (Kurucu Metotlar)

Nesne oluşturulduğunda çalışır ve başlangıç değerlerini atar.

Overload edilebilir, yani bir sınıfta birden fazla constructor olabilir.

class Ogrenci
{
    public string Isim;
    public int Sinif;

    public Ogrenci(string isim, int sinif)
    {
        Isim = isim;
        Sinif = sinif;
    }
}

Ogrenci ogrenci1 = new Ogrenci("Ali", 3);

Encapsulation (Kapsülleme)

Alanları private yapıp property ile erişim sağlamak.

Veriye kontrollü erişim sağlar.

class Ogrenci
{
    private int sinif;
    public int Sinif
    {
        get { return sinif; }
        set { sinif = (value < 1) ? 1 : value; }
    }
}

Inheritance (Kalıtım)

Bir sınıf başka sınıftan özellik ve metotları miras alabilir.

class Personel
{
    public string Ad;
}

class Yonetici : Personel
{
    public string Departman;
}

Polymorphism (Çok Biçimlilik)

Compile-time Polymorphism (Method Overloading): Aynı metot adı farklı parametrelerle.

Run-time Polymorphism (Method Overriding): Türetilmiş sınıfta base metodu değiştirme.

Static Sınıflar ve Üyeler

Static class: Nesnesi oluşturulmaz, tüm üyeleri sınıfa aittir.

static class Islemler
{
    public static int Topla(int a, int b) => a + b;
}


Static field: Tüm nesneler tarafından paylaşılan alan.

Struct ve Enum Kavramları

Struct: Değer tipidir, sınıf gibi metot ve alan tutar.

Enum: Sabit değerleri isimlendirerek tutar.

struct Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
}

enum Gunler { Pazartesi, Sali, Carsamba }

Boxing ve Unboxing

Boxing: Değer tipini referans tipine çevirme.

Unboxing: Referans tipini değer tipine çevirme.

int sayi = 5;
object obj = sayi; // Boxing
int x = (int)obj;  // Unboxing
```
- Referans ve Değer Tipleri
- Tip	Hafıza	Örnek
- Value Type	Stack	int, double, struct
- Reference Type	Heap	class, string, array

## Özet

**C# OOP, sınıflar, nesneler, kapsülleme, kalıtım, çok biçimlilik kavramlarını içerir.**

**Static ve struct kullanımı bellek yönetimi ve performans açısından önemlidir.**

**Enum, boxing/unboxing ve referans/değer tipi bilgisi, veri işleme ve kontrol için kritik öneme sahiptir.**
