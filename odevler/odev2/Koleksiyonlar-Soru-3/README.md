## 📌 Koleksiyonlar – Soru 3

Bu proje, kullanıcıdan alınan bir cümledeki sesli harfleri bulup bir koleksiyon içinde saklayan ve sıralayarak ekrana yazdıran bir C# console uygulamasıdır.

## 🎯 Amaç

- Kullanıcıdan bir cümle almak

- Cümlede geçen Türkçe sesli harfleri tespit etmek

- Bu harfleri bir ArrayList içinde toplamak

- ArrayList'i alfabetik olarak sıralamak

- Sonuçları ekrana yazdırmak

## 🧠 Kullanılan Yapılar

- ArrayList

- Array.IndexOf()

- foreach döngüsü

- Sort() metodu

- String üzerinde karakter gezme

## 📌 Program Akışı

- Kullanıcı bir cümle girer.

- Cümledeki her karakter tek tek kontrol edilir.

- Karakter bir sesli harfse ArrayList'e eklenir.

- Tüm sesli harfler alfabetik olarak sıralanır.

- Sonuç ekrana yazdırılır.

## 🧩 Sesli Harf Dizisi

Program aşağıdaki Türkçe sesli harfleri kontrol eder:
```
char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
```

## 🧩 Sesli Harf Bulma Mantığı
```
foreach (char c in cumle)
    if (Array.IndexOf(sesliler, c) != -1)
        bulunan.Add(c);
```

Karakter, sesli harf dizisi içinde bulunuyorsa listeye eklenir.

## 📤 Örnek Çıktı

Girdi:
```
Cümleyi girin: Merhaba dünya
```

## Çıktı:

Cümledeki sesli harfler:
```
a a a e ı ü 
```
## 🚀 Nasıl Çalıştırılır?

Projeyi çalıştırın.

İstenen cümleyi yazın.

Program tüm seslileri bularak sıralı şekilde ekranda gösterecektir.
