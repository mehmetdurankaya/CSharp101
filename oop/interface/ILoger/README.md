## 📘 Interface Örneği – Logger Sistemi

Bu proje, C# dilinde Interface kullanımını ve bağımlılıkların gevşek bağlanması (loosely coupled design) yaklaşımını göstermek için hazırlanmış basit bir Logger Sistemi örneğidir.

## 🎯 Amaç

- Ortak bir sözleşme tanımlamak (ILogger Interface’i)

- Aynı interface’i farklı şekillerde uygulayarak polimorfizmi göstermek

- LogManager aracılığıyla hangi loglama türünün kullanılacağının runtime’da belirlenmesini sağlamak

- Kodun genişletilebilir (extendable) ve bakımı kolay (maintainable) olmasını sağlamak

## 🧩 Proje Yapısı
Interface_example
│
├── ILogger.cs
├── FileLogger.cs
├── SmsLogger.cs
├── DatabaseLogger.cs
├── LogManager.cs
└── Program.cs

## 🧱 Kullanılan Interface
```
public interface ILogger
{
    void writeLog();
}
```

Tüm logger sınıfları bu interface’i implemente eder ve kendi loglama yöntemini sunar.

## 📝 Logger Sınıfları
## 📁 FileLogger
```
public class FileLogger : ILogger
{
    public void writeLog()
    {
        Console.WriteLine("Dosyaya log yazar");
    }
}

## 🗄️ DatabaseLogger
public class DatabaseLogger : ILogger
{
    public void writeLog()
    {
        Console.WriteLine("Database logları yazar");
    }
}

## 📱 SmsLogger
public class SmsLogger : ILogger
{
    public void writeLog()
    {
        Console.WriteLine("Sms olarak yazar");
    }
}

## 🧠 LogManager – Bağımlılık Enjeksiyonu
public class LogManager : ILogger
{
    public ILogger _logger;

    public LogManager(ILogger logger)
    {
        _logger = logger;
    }

    public void writeLog()
    {
        _logger.writeLog();
    }
}
```
## ✨ Ne İşe Yarar?

- LogManager hiçbir loglama türüne bağımlı değildir.

- Sadece ILogger arayüzünü bilir.

- **Hangi loglama türünün kullanılacağı constructor üzerinden dışarıdan verilir (Dependency Injection).**

Bu sayede:

- ✔ Yeni bir log tipi eklendiğinde LogManager değiştirilmez
- ✔ Kod genişlemeye açık, değişime kapalıdır (Open/Closed Principle – SOLID)

## 🚀 Program.cs – Kullanım Örneği
```
Console.WriteLine("**********");
FileLogger fileLogger = new FileLogger();
fileLogger.writeLog();

Console.WriteLine("**********");
DatabaseLogger databaseLogger = new DatabaseLogger();
databaseLogger.writeLog();

Console.WriteLine("**********");
SmsLogger smsLogger = new SmsLogger();
smsLogger.writeLog();

Console.WriteLine("**********");

LogManager logManager = new LogManager(new FileLogger());
logManager.writeLog();

## 🧪 Örnek Çıktı:
**********
Dosyaya log yazar
**********
Database logları yazar
**********
Sms olarak yazar
**********
Dosyaya log yazar
```
## 🎉 Sonuç

Bu örnekle birlikte:

- **Interface kullanımını**

- **Polimorfizmi**

- **Dependency Injection mantığını**

- **Esnek ve genişletilebilir mimarinin temelini görmüş olduk.**
