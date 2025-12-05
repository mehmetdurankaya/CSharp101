# 📝 Odev1 Konsol Uygulaması

Bu proje, kullanıcıdan alınan seçimlerle dört farklı işlemi gerçekleştiren basit bir C# konsol uygulamasıdır.
Uygulama, bir menü üzerinden kullanıcı etkileşimi sağlar ve kullanıcı çıkış yapana kadar çalışmaya devam eder.

# 📌 İçindekiler

- Genel Bakış

- Çalışma Mantığı

- Menü Seçenekleri

  1. Çift Sayıları Yazdır

  2. Tam Bölünenleri Yazdır

  3. Kelimeleri Tersten Yazdır

  4. Kelime ve Harf Sayısını Hesapla

- Kod Yapısı

- Çalıştırma

## 📌 Genel Bakış

Program sürekli çalışan bir while döngüsü ile kullanıcıya bir menü sunar. Kullanıcının seçimine göre ilgili metot çağrılır.
Seçim 5 olduğunda program kapanır.

## 📌 Çalışma Mantığı

Program başlarken x = 0 ile başlar.

Kullanıcıya bir menü gösterilir.

Kullanıcı bir seçim yapar.

switch-case ile ilgili fonksiyon çalıştırılır.

Kullanıcı 5 seçeneğini seçene kadar menü tekrar gösterilir.

## 📌 Menü Seçenekleri
1. Çift Sayıları Yazdır

Kullanıcıdan:

- Bir adet pozitif sayı (n)

- Ardından n adet pozitif sayı alınır.

Amaç:
Girilen sayılar içerisindeki çift sayıları ekrana yazdırmaktır.

2. Tam Bölünenleri Yazdır

Kullanıcıdan:

- Pozitif bir sayı n

- Pozitif bir sayı m

- Ardından n adet pozitif sayı alınır.

Amaç:
Girilen sayılar içerisinden m’e eşit olan veya m’e tam bölünen sayıların ekrana yazdırılmasıdır.

3. Kelimeleri Tersten Yazdır

Kullanıcıdan:

- Pozitif bir sayı (n)

- Ardından n adet kelime alınır.

Amaç:
Girilen kelimeleri tersten sıralayarak ekrana yazdırmak.

Kullanılan yöntem:
```
Array.Reverse(kelimeler);
```
4. Kelime ve Harf Sayısını Hesapla

- Kullanıcıdan bir cümle alınır.

Amaç:

- Cümledeki kelime sayısını bulmak

- Cümledeki tüm kelimelerdeki toplam harf sayısını hesaplamak

Boşluklar hariç analiz yapılır.

Kullanılan yöntem:
```
cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);

```
## 📌 Kod Yapısı

Proje aşağıdaki statik fonksiyonlardan oluşur:
| Fonksiyon                       | Açıklama                                          |
| ------------------------------- | ------------------------------------------------- |
| `ciftSayilariYazdir()`          | Girilen sayı dizisindeki çift değerleri yazdırır. |
| `tamBolunenleriYazdir()`        | m’e eşit olan veya tam bölünen sayıları gösterir. |
| `kelimeleriTerstenYazdir()`     | Girilen kelimeleri ters sırayla ekrana yazar.     |
| `KelimeVeHarfSayisiniHesapla()` | Cümledeki kelime ve harf sayısını hesaplar.       |

## 🚀 Çalıştırma

1. Projeyi bilgisayarına klonla veya indir.

2. Terminalde proje klasörüne gir.

3. Aşağıdaki komutu çalıştır:
```
dotnet run

```
4. Menüden seçenek seçerek programı kullanmaya başlayabilirsin.
