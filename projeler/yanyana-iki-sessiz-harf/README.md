## Sessiz Harf Kontrolü – OOP Console Uygulaması

Bu proje, verilen string ifadeler içinde yan yana iki sessiz harf bulunup bulunmadığını kontrol eden basit bir C# OOP tabanlı console uygulamasıdır.

Her kelime ayrı ayrı değerlendirilir ve sonuçlar sırayla ekrana yazdırılır.

## 🎯 Amaç

- Bir cümledeki kelimeleri ayırmak

- Her kelimenin içinde ardışık iki sessiz harf olup olmadığını OOP yapısıyla kontrol etmek

- Sonuçları True veya False olarak ekrana vermek

## 🧠 Kurallar

Türkçe sessiz harfler:
```
b c d f g ğ h j k l m n p r s ş t v y z
```
Her kelime şu mantıkla değerlendirilir:

- Eğer kelimenin herhangi bir yerinde yan yana iki sessiz harf varsa → True

- Aksi durumda → False
## 📝 Örnek
Input:
```
Merhaba Umut Arya
```
Output:
```
True False True
```
Açıklama:

- Merhaba → rh kısmında yan yana iki sessiz harf → True

- Umut → m-u ve u-t, hiçbiri iki sessiz yanyana değil → False

- Arya → r-y iki sessiz harf → True

## 📌 Proje Yapısı
```
/SessizHarfKontrol
│
├── Program.cs
└── ConsonantChecker.cs
```
## 💻 Kodlar
ConsonantChecker.cs
```
public class ConsonantChecker
{
    private readonly HashSet<char> _consonants = new HashSet<char>
    {
        'b','c','d','f','g','ğ','h','j','k','l','m','n','p','r','s','ş','t','v','y','z'
    };

    public bool HasDoubleConsonant(string word)
    {
        word = word.ToLower();

        for (int i = 0; i < word.Length - 1; i++)
        {
            if (_consonants.Contains(word[i]) && _consonants.Contains(word[i + 1]))
                return true;
        }

        return false;
    }
}
```
```
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kelime giriniz:");
        string input = Console.ReadLine();

        var checker = new ConsonantChecker();
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            Console.Write(checker.HasDoubleConsonant(word) + " ");
        }
    }
}
```
## 🚀 Çalıştırma

1. Projeyi bir klasöre kaydedin.

2. dotnet new console komutu ile bir console proje oluşturun.

3. Kodları ilgili dosyalara ekleyin.

4. Terminalde:

```
dotnet run
```
