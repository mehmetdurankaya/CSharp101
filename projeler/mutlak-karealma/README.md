## 📐 Mutlak Kare Alma Uygulaması (OOP Yapısı)

Bu uygulama, kullanıcıdan alınan sayıların 67 ile farklarını hesaplar:

- Eğer sayı **67’den küçükse**, fark **normal olarak toplanır**.
- Eğer sayı **67’den büyükse**, farkın **mutlak karesi** alınarak toplanır.

Uygulama tamamen **OOP prensiplerine uygun**, modüler ve genişletilebilir bir yapıdadır.

---

## 🚀 Çalıştırma

Terminalden:

```bash
dotnet run
```

### Program şu şekilde veri ister:
```
Sayıları girin:
```
**Sayıları boşluklarla ayırarak girin.**
## 🔍 Örnek
```
56 45 68 77
```
Output:
```
33 101
```
## 🧠 Proje Yapısı
```
MutlakKare/
│── Program.cs
│── README.md
│── Models/
│   └── NumberResult.cs
│── Services/
│   └── NumberProcessor.cs
│── Utils/
│   └── InputParser.cs
```
## 🧩 Sınıfların Görevleri
- NumberResult

- Çıktıyı temsil eder

- Küçük toplam ve büyük toplam değerlerini tutar

- NumberProcessor

- Tüm işlem mantığını içerir

- 67’den küçük/büyük hesaplamalarını yapar

- InputParser

- Kullanıcıdan gelen string’i integer diziye dönüştürür

## 💡 Kullanılan Kod (Özet)
Program.cs
```
int[] numbers = InputParser.ParseNumbers(input);
var processor = new NumberProcessor();
var result = processor.ProcessNumbers(numbers);

Console.WriteLine(result);
```
Bu yapı sayesinde:

**✔ Kod tekrarından kaçınılmıştır**
**✔ SRP (Single Responsibility Principle) uygulanmıştır**
**✔ Modüler ve genişletilebilir bir çözüm sunulmuştur**
