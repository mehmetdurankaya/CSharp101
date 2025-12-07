## 📌 Static Class ve Static Üyeler

Bu proje, C# dilinde static class’lar, static üyeler ve static constructor’ların nasıl çalıştığını göstermek için hazırlanmış basit ve açıklayıcı bir örnektir.

## 🔍 Projenin Amacı

- Bir sınıfa ait static field, static property ve static constructor kullanımını göstermek

- Static olmayan sınıflardan oluşturulan nesnelerin static sayacı artırmasını sağlamak

- Static class yapısının yalnızca static üyeler barındırdığı bir yardımcı araç sınıfı şeklinde kullanımını göstermek

## 🧱 Yapı Özeti
**✔ Calisan Sınıfı**

- static int calisanSayisi → Sistemde oluşturulmuş çalışan sayısını tutar.

- static Calisan() → Program çalıştığında yalnızca bir kez çalışır; sayacı 0’a çeker.

- Yapıcı metot her çalışan oluşturulduğunda sayacı artırır.

**✔ Islemler Static Sınıfı**

- İçerisinde yalnızca static metotlar bulunur.

Topla(int, int) ve Cıkar(int, int) metotları doğrudan sınıf adı üzerinden çağrılır.

Static class olduğu için örneklenemez.

## 🏃‍♂️ Program Akışı

- İlk olarak Calisan.CalisanSayisi ekrana yazılır.

- Üç çalışan nesnesi oluşturulur → sayaç artar.

- Son çalışan sayısı tekrar ekrana yazılır.

- Islemler sınıfının toplama ve çıkarma metotları çağrılır.

## 🧪 Örnek Çıktı
```
Çalışan sayısı: 0
Çalışan sayısı: 3
Toplama işleminin sonucu: 300
Çıkarma işleminin sonucu: 100
```
## 🎯 Öğrenilen Konular

- **Static field nasıl tanımlanır?**

- **Static constructor ne zaman çalışır?**

- **Static property nasıl kullanılır?**

- **Static class neden örneklenemez?**

- **Static metotlar nasıl çağrılır?**
