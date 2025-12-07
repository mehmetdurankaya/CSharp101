# 🎯 Console Daire Çizme Uygulaması  
Kullanıcıdan alınan yarıçap bilgisine göre konsola daire çizen bir C# uygulamasıdır.  
Kod yapısı **Single Responsibility Principle** (SRP) doğrultusunda sınıflara ayrılmıştır.
---

## 🚀 Amaç  
Konsol ekranında karakter tabanlı bir daire çizmek ve bunu yaparken:

- Kod tekrarından kaçınmak  
- Her sınıfın tek bir sorumluluğu olması  
- Esnek ve geliştirilebilir bir mimari kurmak  

---

## 📂 Proje Yapısı  
```
DaireCiz/
│
├── Program.cs
├── InputHandler.cs → Kullanıcıdan yarıçapı alan sınıf
├── CircleDrawer.cs → Daire çizen sınıf
└── README.md
```

---

## 📌 Kullanılan Yaklaşım  

Daire formülü, noktaların merkeze olan uzaklığı üzerinden hesaplanır:
```
distance = sqrt((x - centerX)² + (y - centerY)²)
```

- Eğer `distance` **yarıçapa yakınsa**, o noktaya `*` konur.  
- Çok satırlı karakter çiziminde en doğru daire görüntüsünü yakalamak için  
  **y ekseni ölçeklendirilmiştir (0.5 katsayısı)**.

---

## 🧩 Sınıfların Görevleri

### **InputHandler**
- Kullanıcıdan yarıçap bilgisini alır.
- Hatalı girişte tekrar ister.

### **CircleDrawer**
- Verilen yarıçapa göre daireyi hesaplar ve çizer.
- Y eksenini ölçeklendirerek gerçek bir daireye yakın görüntü oluşturur.

---

## 🖥️ Program.cs Örneği  

```csharp
using System;

namespace DaireCiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new InputHandler();
            int radius = input.GetRadius();

            var drawer = new CircleDrawer();
            drawer.Draw(radius);

            Console.WriteLine("\nDaire çizimi tamamlandı.");
        }
    }
}
```
📘 CircleDrawer.cs
using System;

namespace DaireCiz
{
    public class CircleDrawer
    {
        public void Draw(int radius)
        {
            double scaleY = 0.5; 
            int diameter = radius * 2;

            for (double y = -radius; y <= radius; y++)
            {
                for (double x = -radius; x <= radius; x++)
                {
                    double distance = Math.Sqrt(x * x + (y / scaleY) * (y / scaleY));

                    if (Math.Abs(distance - radius) < 0.7)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
```
## ▶️ Uygulamanın Çalıştırılması

- 1- Projeyi derleyin ve çalıştırın.

- 2- Konsola yarıçap girin:
```
Dairenin yarıçapını girin: 10
```
- 3- Konsola daire çizilir.
## 📌 Örnek Çıktı
        ********        
     **          **     
   **              **   
  *                  *  
 *                    * 
 *                    * 
 *                    * 
  *                  *  
   **              **   
     **          **     
        ********        
## 🏁 Sonuç

Bu proje, konsolda şekil çizimi yaparken matematiksel hesaplama,
SRP prensibi, ve temiz kod yaklaşımı gibi önemli yazılım kavramlarını pekiştirmek için idealdir.

İstersen şekilleri dosyaya kaydetme, farklı karakterlerle çizim veya UI ekleme gibi geliştirmeler yapabilirsin.
---
