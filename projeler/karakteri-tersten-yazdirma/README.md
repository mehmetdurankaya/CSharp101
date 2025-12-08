## Karakterleri Tersten Yazdırma Uygulaması

Bu proje, kullanıcıdan alınan metindeki her kelimeyi tersten (reverse) yazdıran basit bir C# Console uygulamasıdır.
Uygulama, birden fazla kelime girildiğinde her kelimeyi bağımsız olarak tersine çevirip çıktı verir.

---
## 📌 Amaç

- Kullanıcıdan metin almak

- Metindeki her kelimeyi tek tek tersine çevirmek

- Kelimeler arası boşlukları koruyarak yeni bir satır olarak ekrana yazmak

## 📥 Kullanıcı Girdisi Formatı

Tek satırda bir veya birden fazla kelime girilir:

Merhaba Hello Question

## 📤 Program Çıktısı (Output)

Girilen her kelimenin karakterleri tamamen ters çevrilir.

Örnekler:
| Input                  | Output                 |
| ---------------------- | ---------------------- |
| Merhaba                | abahreM                |
| Hello                  | olleH                  |
| Question               | noitseuQ               |
| Merhaba Hello Question | abahreM olleH noitseuQ |
| Algoritma              | amtirolgA              |

## 🧠 Algoritma Adımları

- Kullanıcıdan bir metin alınır.

- Metin kelimelere ayrılır.

- Her kelime karakter dizisine çevrilir.

- Dizinin karakterleri ters çevrilir (Array.Reverse).

- Ters çevrilen kelimeler tekrar birleştirilir.

- Sonuç ekrana yazdırılır.

## 🧩 Kod Örneği
```
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Metin girin: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine();
            return;
        }

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            char[] arr = words[i].ToCharArray();
            Array.Reverse(arr);
            words[i] = new string(arr);
        }

        string output = string.Join(" ", words);
        Console.WriteLine(output);
    }
}
```
📎 Geliştirme Önerileri

- Noktalama işaretlerini de işleyebilen gelişmiş bir parser eklenebilir.

- Büyük/küçük harf koruma seçenekleri eklenebilir.

- Kelime bazlı değil, tüm cümleyi tek seferde ters çeviren bir mod eklenebilir.
