## 🚗 Abstract Class Example – Otomobil Sistemi

Bu proje, C# dilinde abstract sınıflar, override, virtual metotlar ve kalıtım mimarisi kavramlarını göstermek için hazırlanmış bir otomobil örneğidir.
Abstract sınıf, tüm araçlara ortak bir temel davranış sunarken; alt sınıflar kendi marka bilgilerini ve gerekiyorsa varsayılan renklerini özelleştirir.
---

## 🎯 Projenin Amacı

Bu yapının hedefi:

- Abstract sınıf kullanımını göstermek

- Miras alan sınıfların zorunlu metotları override etmesini sağlamak

- "virtual" metotlar ile alt sınıflara özelleştirme imkanı tanımak

- Polimorfizmi pratik bir örnekle açıklamak

- Genişletilebilir bir mimari kurmak

## 🧩 Proje Yapısı
abstract_example
│
├── Otomobil.cs (abstract sınıf)
├── Focus.cs
├── Civic.cs
├── Corolla.cs
├── Enums.cs (Renk ve Marka)
└── Program.cs

## 🧱 Abstract Sınıf – Otomobil
```
public abstract class Otomobil
{
    public int KacTekerlektenOlusur()
    {
        return 4;
    }

    public virtual Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }

    public abstract Marka HangiMakinaninAraci();
}

Abstract sınıfın özellikleri:

✔ Ortak metotlar tanımlanabilir
✔ abstract metot zorunlu olarak override edilmelidir
✔ virtual metot isteğe bağlı olarak override edilebilir

## 🚘 Alt Sınıflar
🔵 Focus
public class Focus : Otomobil
{
    public override Marka HangiMakinaninAraci()
    {
        return Marka.Ford;
    }

    public int KactekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}


Focus sınıfı StandartRengiNe metodunu override ETMEMİŞ, fakat kendi versiyonunu YENİDEN YAZMIŞTIR.
(Not: Bu override değildir, "method hiding" olur.)

⚪ Corolla
public class Corolla : Otomobil
{
    public override Marka HangiMakinaninAraci()
    {
        return Marka.Toyota;
    }
}


Renk override edilmediği için Corolla varsayılan olarak Beyaz renktedir.

⚫ Civic
public class Civic : Otomobil
{
    public override Marka HangiMakinaninAraci()
    {
        return Marka.Honda;
    }

    public override Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
}


Civic, hem marka bilgisini hem de varsayılan rengi başarılı şekilde override eder.

🎨 Enum Tanımları
public enum Renk
{
    Beyaz,
    Gri
}

public enum Marka
{
    Ford,
    Toyota,
    Honda
}

## 🚀 Program.cs – Kullanım Örneği
Focus focus = new Focus();
Console.WriteLine(focus.HangiMakinaninAraci());
Console.WriteLine(focus.KactekerlektenOlusur());
Console.WriteLine(focus.StandartRengiNe());

Console.WriteLine("******************");

Civic civic = new Civic();
Console.WriteLine(civic.HangiMakinaninAraci());
Console.WriteLine(civic.KacTekerlektenOlusur());
Console.WriteLine(civic.StandartRengiNe());

## 📌 Beklenen Çıktı:
********ABSTRACT EXAMPLE**********
Ford
4
Beyaz
******************
Honda
4
Gri
```
## 🎉 Sonuç

Bu örnek sayesinde:

- **Abstract sınıfların kullanımını,**

- **Abstract – virtual metot farkını,**

- **Override mantığını,**

- **Ortak davranışların nasıl miras bırakıldığını,**

- **Polimorfizmin gerçek bir senaryoda nasıl çalıştığını öğrenmiş olduk.**
