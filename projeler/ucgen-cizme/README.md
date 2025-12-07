## TriangleDrawer – Üçgen Çizme Uygulaması

Bu proje, kullanıcıdan alınan boyut bilgisine göre konsolda üçgen çizen bir C# konsol uygulamasıdır. Uygulama, Single Responsibility Principle (SRP) ve kod tekrarından kaçınma prensiplerine uygun şekilde tasarlanmıştır.

## Özellikler

- Kullanıcıdan üçgenin yüksekliğini alma

- Konsola üçgen çizme

- Kodun sınıflara ve metodlara ayrılmasıyla temiz ve sürdürülebilir yapı

- Hatalı girişleri kontrol edip kullanıcıyı tekrar yönlendirme

Kullanılan Sınıflar
1. **TrianglePrinter**

- Üçgenin çiziminden sorumludur.

- PrintTriangle(int height) metodu ile belirtilen yükseklikte üçgen çizer.

- PrintSpaces(int count) ve PrintStars(int count) metodları ile kod tekrarı önlenir.

2. **InputHandler**

- Kullanıcıdan veri alır ve doğrular.

- Hatalı girişte kullanıcıyı tekrar sorar.

- GetTriangleHeight() metodu yüksekliği alır ve pozitif olduğundan emin olur.

3. **Program**

- Kullanıcı girişini alır, üçgen çizim işlemini başlatır.

- Kod okunabilir ve SRP’ye uygundur.

- Kurulum ve Çalıştırma

- Bu projeyi bilgisayarınıza klonlayın veya zip olarak indirin.

 -Visual Studio veya Visual Studio Code ile açın.

- Projeyi derleyin ve çalıştırın.

- Konsolda üçgenin yüksekliğini girin.

 - Konsola çizilen üçgen görüntülenecektir.

Örnek Çalışma
```
Üçgenin yüksekliğini girin: 5

    *
   ***
  *****
 *******
*********
```
## Kod Yapısı ve SRP

- TrianglePrinter: Üçgen çizimi

- InputHandler: Kullanıcı girişleri

- Program/Main: Uygulama akışı

 -Her sınıf tek bir sorumluluk üstlenir ve kod tekrarından kaçınılmıştır. Bu sayede uygulama temiz, sürdürülebilir ve okunabilir bir yapıya sahiptir.

## Gereksinimler

- .NET 6 veya üzeri

- C# 10 veya üzeri
