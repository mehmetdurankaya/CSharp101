## Fibonacci Ortalama Hesaplama Uygulaması

Bu proje, kullanıcıdan alınan derinliğe göre Fibonacci serisindeki sayıların ortalamasını hesaplayan bir C# konsol uygulamasıdır. Uygulama, Single Responsibility Principle (SRP) ve kod tekrarından kaçınma prensiplerine uygun şekilde tasarlanmıştır.
---

## Özellikler

- Kullanıcıdan Fibonacci serisinin uzunluğunu alma

- Fibonacci serisini hesaplama

- Hesaplanan serinin ortalamasını bulma

- Seri ve ortalamayı ekrana yazdırma

- Kodun sınıflara ve metodlara ayrılmasıyla temiz ve sürdürülebilir yapı

## Kullanılan Sınıflar
1. **FibonacciCalculator**

Sadece Fibonacci serisini üretmekten sorumludur.

GenerateSeries(int length) metodu ile belirtilen uzunlukta Fibonacci serisi döndürür.

2. **AverageCalculator**

Verilen sayı listesinin ortalamasını hesaplar.

CalculateAverage(List<int> numbers) metodu ile ortalamayı döndürür.

3. **Program**

- Kullanıcı girişini alır.

- Hesaplamaları ilgili sınıflara devreder.

- Sonucu ekrana yazdırır.

##  Kurulum ve Çalıştırma

- Bu projeyi bilgisayarınıza klonlayın veya zip olarak indirin.

- Visual Studio veya Visual Studio Code ile açın.

- Projeyi derleyin ve çalıştırın.

- Konsolda Fibonacci serisinin uzunluğunu girin.

- Seri ve ortalama ekranda görüntülenecektir.

## Örnek Çalışma
```
Fibonacci serisi uzunluğunu girin: 7
Fibonacci Serisi: 0, 1, 1, 2, 3, 5, 8
Ortalama: 2.857142857142857
```
**Kod Yapısı ve SRP**

- Her sınıf tek bir sorumluluk üstlenir:

- Fibonacci serisi hesaplama

- Ortalama hesaplama

- Kullanıcı ile etkileşim

- Kod tekrarından kaçınılmıştır ve temiz bir yapı sağlanmıştır.

## Gereksinimler

- .NET 6 veya üzeri

- C# 10 veya üzeri
