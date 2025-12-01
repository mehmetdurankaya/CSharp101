# 🔢 Tek ve Çift Sayıların Toplamı Programı

Bu program, kullanıcıdan bir sayı alır ve 1'den bu sayıya kadar olan **tek ve çift sayıların toplamını** ayrı ayrı hesaplar ve ekrana yazdırır.

---

## 1. Program Açıklaması

* Kullanıcıdan bir sayı alınır.
* 1'den girilen sayıya kadar bir `for` döngüsü çalıştırılır.
* Döngüde **tek ve çift sayılar** ayrılır:

  * Tek sayılar: `i % 2 == 1`
  * Çift sayılar: `i % 2 == 0`
* Her adımda ilgili toplam **artırılır ve ekrana yazdırılır**.

---

## 2. Kullanılan Yapılar

* **for döngüsü**: 1'den kullanıcı tarafından girilen sayıya kadar iterasyon sağlar.
* **if-else**: Sayının tek veya çift olduğunu kontrol eder.
* **% (modulus)** operatörü: Sayının tek mi çift mi olduğunu anlamak için kullanılır.
* **Console.WriteLine**: Her adımda ara toplamları ekrana yazdırmak için kullanılır.

---

## 3. Örnek Kod

```csharp
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Sayı Giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                    Console.WriteLine($"Tek sayıların Toplamı: {tekToplam}");
                }
                else
                {
                    ciftToplam += i;
                    Console.WriteLine($"Çift Sayıların Toplamı: {ciftToplam}");
                }
            }
        }
    }
}
```

---

## 4. Örnek Çıktı

### Kullanıcı Girişi: 5

```
Lütfen Bir Sayı Giriniz:5
Tek sayıların Toplamı: 1
Çift Sayıların Toplamı: 2
Tek sayıların Toplamı: 4
Çift Sayıların Toplamı: 6
Tek sayıların Toplamı: 9
```

### Kullanıcı Girişi: 8

```
Lütfen Bir Sayı Giriniz:8
Tek sayıların Toplamı: 1
Çift Sayıların Toplamı: 2
Tek sayıların Toplamı: 4
Çift Sayıların Toplamı: 6
Tek sayıların Toplamı: 9
Çift Sayıların Toplamı: 12
Tek sayıların Toplamı: 16
Çift Sayıların Toplamı: 20
```

---

## 5. Notlar

* Program her adımda **ara toplamları** gösterir.
* Modulus operatörü sayesinde sayının tek veya çift olduğu kolayca anlaşılır.
* Kod, kullanıcıdan alınan herhangi bir pozitif sayı için çalışır.
