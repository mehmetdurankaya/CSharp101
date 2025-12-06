## 📌 ArrayList Örnek Uygulaması – README.md
ArrayList Example (C#)

Bu proje, C# dilinde ArrayList sınıfının temel kullanımını örnekleyen basit bir konsol uygulamasıdır.
ArrayList, farklı veri tiplerini aynı koleksiyonda tutabilen, dinamik olarak büyüyüp küçülebilen bir koleksiyon yapısıdır.

Bu örnek uygulamada aşağıdaki işlemler yapılmaktadır:

## 🚀 Kullanılan Yapılar
✔ ArrayList oluşturma
```
ArrayList liste = new ArrayList();
```
--- 

## ✔ AddRange – Birden Çok Eleman Ekleme

Listeye bir koleksiyonun elemanlarını toplu olarak eklemek için AddRange kullanılır.

List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
liste.AddRange(sayilar);
```
## ✔ Liste Elemanlarını Yazdırma
foreach (var item in liste)
    Console.WriteLine(item);
```
## ✔ Sort – Sıralama
```
ArrayList.Sort() metodu, listedeki elemanları artan sıralamaya göre düzenler.

liste.Sort();
```
Not: Sort işlemi yapılabilmesi için listedeki bütün elemanların aynı veri tipinde olması gerekir.
Bu örnekte sadece int değerleri olduğundan hata oluşmaz.

## ✔ BinarySearch – Eleman Arama

Bir elemanın sıralı listede kaçıncı indeksinde olduğunu bulur.
```
Console.WriteLine(liste.BinarySearch(9));
```
## ✔ Reverse – Ters Çevirme

Listenin elemanlarını ters sıraya çevirir.
```
liste.Reverse();
```
## ✔ Clear – Listeyi Temizleme

Listedeki tüm elemanları siler.
```
liste.Clear();
```
## 🧩 Örnek Çıktı

Uygulamanın sıralı haliyle üretebileceği örnek çıktı şöyledir:
``` 
***** Add Range *****
1
8
3
7
9
92
5
***** Sort ******
1
3
5
7
8
9
92
***** Binary Search *****
5
****** Reverse ******
92
9
8
7
5
3
1
****** Clear ******

```
--- 

## 📘 Özet

Bu proje ile:

- **ArrayList oluşturmayı**

- **AddRange ile toplu eleman eklemeyi**

- **Sort, Reverse, BinarySearch gibi önemli metodları**

- **Clear ile liste temizlemeyi pratik olarak öğrenmiş oluyoruz.**
