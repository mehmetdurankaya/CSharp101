## 🔤 Karakter Değiştirme Uygulaması (OOP Versiyonu)

Bu C# console uygulaması, kullanıcıdan alınan kelimelerin **ilk ve son karakterlerini değiştirir**.  
Uygulama tamamen OOP prensiplerine uygun, modüler ve kolay genişletilebilir bir yapıdadır.

---

## 📌 Örnek Kullanım

**Input:**  
Merhaba Hello Algoritma x
```
**Output:**  
```
aerhabM oellH algoritmA x
```

---

## 🚀 Programı Çalıştırma

Terminal veya Visual Studio üzerinden:

```bash
dotnet run
```
Program sizden metinleri girmeyi isteyecek:
```
Metinleri girin:
```
Boşlukla ayrılmış kelimeleri yazın ve Enter tuşuna basın.

🧠 Algoritma Adımları

1. Kullanıcıdan alınan string, kelimelere bölünür.

2. Her kelime için Word sınıfı kullanılarak:

- Uzunluk 1 veya daha az → olduğu gibi kalır.

- Uzunluk >1 → ilk ve son karakter değişir.

3. İşlenmiş kelimeler tekrar birleştirilir ve ekrana yazdırılır.

📂 Proje Yapısı
```
karakter-degistirme/
│── Program.cs
│── README.md
│── Models/
│   └── Word.cs
│── Services/
│   └── WordProcessor.cs
``` 
## 🧩 Sınıfların Görevleri

- Word → Tek bir kelimenin verisini ve işleme metodunu tutar.

- WordProcessor → Tüm giriş metnini alır, kelimeleri işler ve sonuç döndürür.

- Program.cs → Kullanıcı girişini alır ve sonucu ekrana yazdırır.

Bu yapı sayesinde:

- **✔ Kod tekrarından kaçınılmıştır**
- **✔ SRP (Single Responsibility Principle) uygulanmıştır**
- **✔ Modüler ve genişletilebilir bir çözüm sağlanmıştır**
