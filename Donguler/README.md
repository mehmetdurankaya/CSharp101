# C# Döngü Örnekleri

Bu proje, C# dilinde **for**, **while** ve **foreach** döngülerinin nasıl kullanıldığını gösteren basit örneklerden oluşur. Her örnek, kullanıcıdan alınan verilere göre işlem yapar ve sonucu ekrana yazdırır.

---

## 📌 Proje Yapısı

Kod içinde üç adet ayrı döngü örneği bulunur:

1. **forLoopExample()** → Tek ve çift sayıların toplamını hesaplama
2. **whileLoopExample()** → Girilen sayıya kadar olan sayıların ortalamasını alma
3. **foreachLoopExample()** → Bir dizi elemanını ekrana yazma

Program çalıştığında bu üç metod sırayla çalıştırılır.

---

## 🔹 1. forLoopExample()

Kullanıcıdan bir sayı istenir. 1’den başlayarak o sayıya kadar olan tüm sayılar taranır.

* Tek sayılar için toplam ayrı tutulur
* Çift sayılar için toplam ayrı tutulur
* Toplamlar adım adım ekrana yazdırılır

**Amaç:** Döngü koşulu, mod alma ve biriktirme işlemini anlamak.

---

## 🔹 2. whileLoopExample()

Kullanıcı bir sayı girer. While döngüsü:

* 1’den başlayarak girilen sayıya kadar ilerler
* Her sayı toplam değişkenine eklenir
* Döngü bittiğinde, toplam giriş sayısına bölünerek ortalama ekrana yazdırılır

**Amaç:** While döngüsünün çalışma mantığını (koşul sağlandıkça devam eder) göstermek.

---

## 🔹 3. foreachLoopExample()

Hazır bir string dizisi kullanılır:

```csharp
string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
```

Foreach döngüsü dizi içindeki her bir elemanı sırasıyla ekrana yazdırır.

**Amaç:** Koleksiyon ve dizi dolaşmanın en basit yöntemini göstermek.

---

## ▶️ Programın Çalışma Akışı

Program başladığında otomatik olarak şu sırayla çalışır:

1. For döngüsü örneği
2. While döngüsü örneği
3. Foreach döngüsü örneği

Her örnek konsol ekranına ayırıcı başlıklarla yazılır.

---

## 🎯 Öğrenilen Konular

* Döngü tiplerinin farkları
* Kullanıcıdan veri alma (Console.ReadLine)
* Mod alma işlemi (% operatörü)
* Sayı biriktirme (toplama)
* Dizilerde gezinme

---

## 📌 Not

Bu örnekler başlangıç seviyesinde döngü mantığını pekiştirmek amacıyla hazırlanmıştır.
---


