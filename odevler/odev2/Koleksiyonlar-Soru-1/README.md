## 📘 Koleksiyonlar – Soru 1

Bu proje, kullanıcıdan alınan 20 pozitif sayıyı asal ve asal olmayan olarak ayıran, bu sayıları sıralayan ve istatistiklerini hesaplayan bir C# Console uygulamasıdır.

## 🎯 Amaç

Program aşağıdaki işlemleri gerçekleştirir:

- Kullanıcıdan 20 adet pozitif tam sayı alır.

- Negatif, sıfır veya sayı olmayan girişleri kabul etmez.

- Sayıların asal olup olmadığını kontrol eder.

- Asal ve asal olmayan sayıları iki ayrı ArrayList içinde saklar.

- Her iki listeyi büyükten küçüğe sıralar.

Her liste için:

- Elemanların tamamı

- Eleman sayısı

- Ortalama değeri hesaplanır ve ekrana yazdırılır.

## 🛠 Kullanılan Yapılar

- ArrayList

- Sayısal doğrulama (TryParse)

- Asal sayı algoritması

- Sıralama ve ters çevirme

- Döngüler & koşullar

## 📂 Kod Açıklaması
✔ Sayı Alma Döngüsü

Program, geçerli giriş alınana kadar kullanıcıdan 20 pozitif sayı talep eder.
Hatalı girişlerde uyarı verir.

## ✔ Asal Kontrolü

AsalMi(int sayi) metodu ile sayıların asal olup olmadığı hesaplanır.

## ✔ Liste İşlemleri

Her iki liste:

- Sort() ile sıralanır

- Reverse() ile büyükten küçüğe çevrilir

## ✔ İstatistik Hesaplama

## YazdirVeIstatistik(ArrayList liste) metodu:

- Elemanları yazdırır

- Sayıyı hesaplar

- Toplam ve ortalama değeri ekrana yazdırır

## ▶ Çalıştırma

Terminal üzerinden:

dotnet run


Çalıştırdığınızda program sizden teker teker 20 pozitif sayı isteyecektir.

## 📄 Örnek Çıktı
```
--- ASAL SAYILAR ---
19 17 13 11 7 5 3 2
Eleman sayısı: 8
Ortalama: 9.625

--- ASAL OLMAYAN SAYILAR ---
20 18 16 14 12 10 9 8 6 4
Eleman sayısı: 10
Ortalama: 11.7
```
### 📝 Notlar

Bu uygulama, ArrayList kullanımı, temel algoritmalar, koleksiyon işlemleri ve doğrulama pratikleri için uygundur.
