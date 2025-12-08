## Alan – Çevre – Hacim Hesaplama Uygulaması

Bu proje, C# konsol ortamında çalışan, farklı geometrik şekiller için alan, çevre veya hacim hesaplaması yapan, Single Responsibility Principle (SRP) odaklı modüler bir uygulamadır.

## 🎯 Özellikler

- Kullanıcıdan hesaplanacak şekil alınır

- Seçilen şekle göre gerekli kenar bilgileri sorulur

- Hesaplama türü seçilir:

- Alan

- Çevre

- Hacim (sadece ilgili şekillerde)

- Sonuç anlaşılır bir şekilde ekrana yazdırılır

- Kod tekrarını önleyen, sınıflara bölünmüş, SRP prensibine uygun yapı

## 🏗 Mimari Yapı
```

/AlanHesaplama
│
├── IShape.cs
├── Circle.cs
├── Square.cs
├── Rectangle.cs
├── Triangle.cs
├── ShapeFactory.cs
└── Program.cs
``` 
## 🧩 Kullanım Akışı

Kullanıcı bir şekil seçer

- Daire

- Kare

- Dikdörtgen

- Üçgen

### Şekle göre gerekli ölçüler istenir

- Daire → yarıçap

- Kare → kenar

- Dikdörtgen → genişlik + yükseklik

- Üçgen → 3 kenar

- Hesaplanacak boyut seçilir

- Alan

- Çevre

- Hacim (uygun değilse 0 döner)

- Sonuç gösterilir

## 🧠 Single Responsibility Açıklaması

**Her şeklin tek sorumluluğu vardır**
**→ Kendi alan/çevre/hacim formüllerini hesaplamak**

**ShapeFactory'nin tek sorumluluğu**
**→ Kullanıcı seçiminden doğru nesneyi üretmek**

**Program.cs sadece**
**→ kullanıcı etkileşimini yönetir**

**Bu sayede kod tekrarından kaçınılır ve her sınıf bağımsız genişletilebilir olur.**

## 🧪 Örnek Kullanım

Input:
```

Şekil seçin: Daire
Yarıçap: 5
Hesaplama türü: Alan


Output:

Sonuç: 78.5398
```
## 🚀 Geliştirme Önerileri

- Silindir, Küre, Koni gibi 3D şekiller eklenebilir

- Hatalı giriş kontrolü güçlendirilebilir

- Menü bazlı navigasyon eklenebilir

- Birden fazla hesaplama peş peşe yapılabilir
---
