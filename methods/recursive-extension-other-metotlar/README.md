# Recursive ve Extension Metot Örnekleri - C#

Bu proje, C# dilinde **recursive (özyinelemeli) metotlar**, **iterative (döngüsel) metotlar** ve **extension metotlar** kullanımını göstermektedir. Hem temel programlama kavramlarını hem de C#’ın gelişmiş özelliklerini öğrenmek için iyi bir örnektir.

---

## İçindekiler

- [Proje Hakkında](#proje-hakkında)  
- [Kurulum](#kurulum)  
- [Kullanılan Metotlar](#kullanılan-metotlar)  
  - [Recursive Metot](#recursive-metot)  
  - [Iterative Metot](#iterative-metot)  
  - [Extension Metotlar](#extension-metotlar)  
- [Örnek Kullanım](#örnek-kullanım)  
- [Çıktı](#çıktı)  

---

## Proje Hakkında

Bu proje şu amaçları taşır:

1. **Recursive Metotlar**: Kendi kendini çağıran metotlarla işlem yapmayı göstermek.  
2. **Iterative Metotlar**: Döngü kullanarak aynı işlemin yapılmasını göstermek.  
3. **Extension Metotlar**: Var olan veri tiplerine yeni metotlar eklemeyi göstermek.

---

## Kurulum

1. Projeyi GitHub’dan klonlayın veya zip olarak indirin:

```bash
git clone <repository-url>
```
Kullanılan Metotlar
Recursive Metot
```
   public static int recursiveMetot(int n)
```
- Kendi kendini çağırır.

- Örnek: F(4) = 4 + F(3)

- Sonu bilinemeyen veya derinliği değişken durumlar için uygundur.

Iterative Metot
```
static int iterativeMetot(int n)
```
- Döngüsel hesaplama yapar.

- Örnek: F(4) = 4 + 3 + 2 + 1
### Extension Metotlar

Extension metotlar, var olan veri tiplerine yeni fonksiyonellik ekler.
| Metot                 | Açıklama                                 |
| --------------------- | ---------------------------------------- |
| `CheckSpaces()`       | String içinde boşluk var mı kontrol eder |
| `RemoveWhiteSpaces()` | Boşlukları `*` ile değiştirir            |
| `MakeUpperCase()`     | Tüm karakterleri büyük yapar             |
| `MakeLowerCase()`     | Tüm karakterleri küçük yapar             |
| `GetFirstCharacter()` | String’in ilk karakterini döndürür       |

#### Int Dizisi Uzantıları
| Metot            | Açıklama               |
| ---------------- | ---------------------- |
| `SortArray()`    | Diziyi sıralar         |
| `EkranaYazdir()` | Diziyi ekrana yazdırır |

### Int Uzantıları
| Metot            | Açıklama                                  |
| ---------------- | ----------------------------------------- |
| `IsEvenNumber()` | Sayının çift olup olmadığını kontrol eder |

### Örnek Kullanım
```
string ifade = "Mehmet Duran Kaya";

if (ifade.CheckSpaces())
{
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}

Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
dizi = dizi.SortArray();
dizi.EkranaYazdir();

int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());
Console.WriteLine(ifade.GetFirstCharacter());
```
### Çıktı
``` 
Recursive Metot ile sonuç: 10
Iterative metot ile sonuç: 10
******Extension Metotlar******
Boşluk kontrolü yapılıyor...
Boşluklar yerine * işareti koyuluyor...
MEHMET DURAN KAYA
mehmet duran kaya
Dizi ekrana yazdırılıyor...
0
1
2
3
5
6
9
False
M
```

