## 📘 Generic Collection Örnek Uygulaması
Bu proje, C# Generic Collection (List<T>) yapısının kullanımını adım adım gösteren bir örnek konsol uygulamasıdır.
Listelerde eleman ekleme, silme, arama, listeyi temizleme ve nesne listeleri oluşturma gibi temel işlemler örneklerle açıklanmaktadır.

## 📂 İçerik

- Liste Oluşturma

- Liste Eleman Sayısı (Count)

- Liste Elemanlarını Yazdırma

- Listeden Eleman Silme

- Arama ve Index İşlemleri

- Diziden Liste Oluşturma

- Listeyi Temizleme (Clear)

- Nesne Listeleri ile Çalışma

Kod
## 📌 Konu Özeti

Bu uygulama ile şu temel List<T> işlemleri gösterilir:

✔ Eleman ekleme
✔ Eleman silme (Remove, RemoveAt)
✔ Elemanları gezinme (foreach, ForEach)
✔ Arama (Contains, BinarySearch)
✔ Diziyi listeye dönüştürme
✔ Listeyi temizleme
✔ Bir sınıfı liste içinde nesne olarak tutma

## 🧱 Liste Oluşturma
```
List<int> sayiListesi = new List<int>();
List<string> renkListesi = new List<string>();
```
## 🔢 Liste Eleman Sayısı (Count)
```
sayiListesi.Count
renkListesi.Count

```
## 🖨 Liste Elemanlarını Yazdırma
foreach ile
```
foreach (var sayi in sayiListesi)
    Console.WriteLine(sayi);
```
ForEach ile (lambda)
```
sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

```
## ❌ Listeden Eleman Silme
```
sayiListesi.Remove(4);       // değere göre silme
sayiListesi.RemoveAt(0);     // index’e göre silme

```
## 🔍 Arama ve Index İşlemleri
```
sayiListesi.Contains(10);     // Eleman var mı?
renkListesi.BinarySearch("Mavi"); // İkili arama

```
## 🔄 Diziden Liste Oluşturma
```
string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
List<string> hayvanListesi = new List<string>(hayvanlar);

```
## 🧹 Listeyi Temizleme (Clear)
Örnek sınıf:
```
public class Kullanicilar
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}

```
Liste oluşturma:
```
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

```
Nesne ekleme:
```
kullaniciListesi.Add(new Kullanicilar {
    Isim = "Mehmet Duran",
    Soyisim = "Kaya",
    Yas = 48
});
```
Listeyi yazdırma:
```
foreach (var kullanici in kullaniciListesi)
{
    Console.WriteLine(kullanici.Isim);
}

```
## 🧾 Kod

Tam uygulama kodu projenin Program.cs dosyasında yer almaktadır.

---
