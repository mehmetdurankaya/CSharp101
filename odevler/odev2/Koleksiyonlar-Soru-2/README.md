## 📌 Koleksiyonlar – Soru 2

Bu proje, kullanıcıdan alınan 20 adet sayının içinden en küçük 3 sayı ve en büyük 3 sayı değerlerini bulan, bu sayıların ortalamasını hesaplayan ve sonuçları ekrana yazdıran bir C# console uygulamasıdır.

## 🎯 Amaç

- Kullanıcıdan 20 sayı almak

- Sayıları küçükten büyüğe sıralamak

- En küçük 3 ve en büyük 3 sayıyı seçmek

- Her iki grubun ortalamasını hesaplamak

- Ortalamalar ve ortalama toplamını ekrana yazdırmak

## 🧠 Kullanılan Yapılar
```
int[] dizi yapısı

Array.Sort() metodu
```
Metot kullanımı (Ortalama)
```
foreach döngüsü

Console girdi/çıktı işlemleri
```
## 📌 Program Akışı

- Kullanıcıdan 20 adet sayı alınır.

- Sayılar Array.Sort() ile küçükten büyüğe sıralanır.

- Dizinin ilk 3 elemanı en küçükler, son 3 elemanı en büyükler olarak alınır.

- Her iki dizinin ortalaması hesaplanır.

- Sonuçlar kullanıcıya gösterilir.

## 🧩 Ortalama Hesaplama Metodu
```
static double Ortalama(int[] dizi)
{
    int toplam = 0;
    foreach (var x in dizi) toplam += x;
    return (double)toplam / dizi.Length;
}
```
## 📤 Örnek Çalışma
```
Girdi:

1. sayıyı girin: 12
2. sayıyı girin: 5
3. sayıyı girin: 33
...
```

Olası Çıktı:
```
En küçük 3 sayı ortalaması: 6,33
En büyük 3 sayı ortalaması: 42
Ortalama toplamı: 48,33
```
## 🚀 Nasıl Çalıştırılır?

Projeyi çalıştırın.

- Art arda 20 sayı girin.

Program sonuçları otomatik olarak hesaplayacaktır.
