# C# Diziler (Arrays) Örneği

Bu proje, C# programlama dilinde dizilerin nasıl tanımlanacağını, değer atanacağını, döngülerle nasıl kullanılacağını ve kullanıcıdan alınan girdilerle bir dizinin ortalamasının nasıl hesaplanacağını gösteren basit bir örnek içerir.

---

## 🚀 Projenin Amacı

Bu örnek, temel C# dizileri üzerinde pratik yapmayı amaçlar:

- Dizi tanımlama  
- Diziye değer atama  
- Dizinin elemanlarına erişme  
- `for` ve `foreach` döngüleri ile dizi üzerinde işlem yapma  
- Kullanıcıdan dinamik eleman sayısı alıp dizi oluşturma  

---

## 📂 İçerik

Kod aşağıdaki bölümlerden oluşur:

### 1. **Dizi Tanımlama**
```csharp
string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi = new int[5];
```
---
2. Diziye Değer Atama
renkler[0] = "Mavi";
dizi[3] = 10;
3. Dizi Elemanlarına Erişim
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);
---
4. Kullanıcıdan Dizi Elemanlarının Alınması
Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] yeniDizi = new int[diziUzunlugu];
---
5. Dizi Elemanlarını Döngü ile Okuma
for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
    yeniDizi[i] = int.Parse(Console.ReadLine());
}
---
6. Dizinin Ortalamasının Hesaplanması
int toplam = 0;
foreach (var sayi in yeniDizi)
{
    toplam += sayi;
    Console.WriteLine($"Ortalama : {toplam / diziUzunlugu}");
}
---
🖥️ Programın Çalışma Mantığı

Sabit diziler tanımlanır.

Dizilere değer atanır ve ekrana yazdırılır.

Kullanıcıdan dizi uzunluğu alınır.

Girilen değerlere göre yeni bir dizi oluşturulur.
---

- foreach döngüsü ile dizideki tüm sayıların toplamı alınır.
- Ortalama hesaplanıp ekrana yazdırılır.
- Köpek
- 10
- Mavi
- Lütfen dizinin eleman sayısını giriniz: 3
- Lütfen 1. sayıyı giriniz: 10
- Lütfen 2. sayıyı giriniz: 20
- Lütfen 3. sayıyı giriniz: 30
- Ortalama : 10
- Ortalama : 20
- Ortalama : 30

