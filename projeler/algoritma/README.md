## String Index Karakter Çıkarma Uygulaması

Bu proje, kullanıcıdan string ve index bilgisini virgülle ayrılmış şekilde alarak, verilen string içinden belirtilen index’teki karakteri kaldıran basit bir C# Console uygulamasıdır.
---

## 📌 Amaç

- Ekrandan "metin,index" formatında bir giriş almak

- String ve index'i ayırmak

- Index doğruysa o karakteri metinden çıkarmak

- Geçersiz index durumunda metni değiştirmeden göstermek

## 📥 Kullanıcı Girdisi Formatı
```
Kelime,Index
```
Örnek:
```
Algoritma,3
```
## 📤 Program Çıkışı (Output)

Girilen indeks doğru bir değer ise, string içerisindeki o karakter silinir ve yeni string ekrana yazılır.
| Input        | Output    |
| ------------ | --------- |
| Algoritma,3  | Algritma  |
| Algoritma,5  | Algortma  |
| Algoritma,22 | Algoritma |
| Algoritma,0  | lgoritma  |

## 🧠 Algoritma Adımları

1. Kullanıcıdan "metin,index" formatında girdi alınır.

2. Split(',') ile text ve index ayrılır.

3. Index sayıya dönüştürülür (TryParse ile).

4. Index geçersizse (0’dan küçük veya metnin uzunluğundan büyük) → orijinal metin yazılır.

5. Index geçerliyse, Remove kullanılarak karakter silinir.

6. Sonuç ekrana yazdırılır.

## 🧩 Kod Örneği
```
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Metin ve index girin (örn: Algoritma,3): ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');

        if (parts.Length != 2)
        {
            Console.WriteLine("Hatalı format! Örnek kullanım: Kelime,3");
            return;
        }

        string text = parts[0];
        if (!int.TryParse(parts[1], out int index))
        {
            Console.WriteLine("Index bir sayı olmalı!");
            return;
        }

        if (index < 0 || index >= text.Length)
        {
            Console.WriteLine(text);
            return;
        }

        string result = text.Remove(index, 1);

        Console.WriteLine(result);
    }
}
```
## 📎 Geliştirme Önerileri

- Birden fazla input’u ardışık işleyebilir hale getirilebilir.

- Hatalı giriş durumlarında tekrar giriş istenebilir.

- Birim testler eklenebilir.
---
