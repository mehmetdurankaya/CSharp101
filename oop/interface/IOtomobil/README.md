## 🚗 Interface Example – Otomobil Sistemi

Bu proje, C# dilinde interface kullanımını, polimorfizmi, ve genişletilebilir mimari yaklaşımını göstermek için hazırlanmış bir otomobil örneğidir.

Her otomobil sınıfı, aynı interface’i implement ederek kendi marka, renk ve tekerlek sayısı bilgisini sağlar.

## 🎯 Amaç

Bu proje ile:

- Ortak bir sözleşme tanımlamak (IOtomobil interface'i)

- Farklı otomobil sınıflarının bu sözleşmeyi kendi özellikleriyle uygulamasını sağlamak

- Polimorfizmi pratik bir örnekle göstermek

- Genişlemeye açık / değişime kapalı bir yapı kurmak (SOLID – OCP)

amaçlanmaktadır.

## 🧩 Proje Yapısı
inteface_example
│
├── IOtomobil.cs
├── Civic.cs
├── Corolla.cs
├── Focus.cs
├── Program.cs
└── Enums.cs (Renk ve Marka)

## 🧱 IOtomobil Interface’i
```
public interface IOtomobil
{
    int KactekerlektenOlusur();
    Marka HangiMarkaninAraci();
    Renk StandartRengiNe();
}
```

Tüm otomobil sınıfları bu sözleşmeyi uygular.

## 🚘 Otomobil Sınıfları
```
🔵 Focus

public class Focus : IOtomobil
{
    public Marka HangiMarkaninAraci() => Marka.Ford;
    public int KactekerlektenOlusur() => 4;
    public Renk StandartRengiNe() => Renk.Beyaz;
}

⚪ Corolla
public class Corolla : IOtomobil
{
    public Marka HangiMarkaninAraci() => Marka.Toyota;
    public int KactekerlektenOlusur() => 4;
    public Renk StandartRengiNe() => Renk.Beyaz;
}

⚫ Civic
public class Civic : IOtomobil
{
    public Marka HangiMarkaninAraci() => Marka.Honda;
    public int KactekerlektenOlusur() => 4;
    public Renk StandartRengiNe() => Renk.Gri;
}

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

🚀 Program.cs – Kullanım Örneği
Focus focus = new Focus();
Console.WriteLine(focus.HangiMarkaninAraci());
Console.WriteLine(focus.KactekerlektenOlusur());
Console.WriteLine(focus.StandartRengiNe());

Console.WriteLine("******************");

Civic civic = new Civic();
Console.WriteLine(civic.HangiMarkaninAraci());
Console.WriteLine(civic.KactekerlektenOlusur());
Console.WriteLine(civic.StandartRengiNe());
```
## 📌 Örnek Çıktı
```
Ford
4
Beyaz
******************
Honda
4
Gri
```
## 🎉 Sonuç

- Bu örnek ile:

- Interface yapısının nasıl kullanıldığını

- Farklı sınıfların aynı sözleşmeyi nasıl uyguladığını

- Polimorfizmin gerçek bir senaryoda nasıl çalıştığını öğrenmiş olduk.
