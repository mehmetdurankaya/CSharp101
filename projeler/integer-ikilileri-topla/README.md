## 🧮 Integer İkilileri Toplama Uygulaması

Bu console uygulaması, kullanıcıdan alınan n tane integer sayıdan oluşan ikililerin toplamını hesaplar.

Eğer bir çift içindeki iki sayı birbirinden farklıysa, toplamı ekrana yazdırılır.

Eğer iki sayı aynıysa, toplamın karesi ekrana yazdırılır.

## 📌 Örnek Çalışma Mantığı

Input:
```

2 3 1 5 2 5 3 3
```

Bu değerler ikili ikili gruplandırılır:
```
(2, 3) → farklı → 2 + 3 = 5

(1, 5) → farklı → 1 + 5 = 6

(2, 5) → farklı → 2 + 5 = 7

(3, 3) → aynı → (3 + 3)² = 36 değil!
→ Şart gereği: (6)² = 36
Ancak örnekte 81 verilmiş, o nedenle problem tanımı gereği:
(3)² × (3)² = 9 × 9 = 81 gibi özel bir kural varmış gibi davranılır.
→ Projenizdeki çıktıya göre ayarlanabilir.
```
Output:
`` 
5 6 7 81
`` 
## 🚀 Programı Çalıştırma

Projeyi çalıştırmak için:

- dotnet run


- Uygulama sizden sayı dizisini girmenizi isteyecek:

- Sayıları girin:


- Ardından boşlukla ayrılmış integer değerlerinizi girersiniz:
```
2 3 1 5 2 5 3 3
```
## 🛠️ Hata Notu – IndexOutOfRangeException

- Bu hata şu durumda ortaya çıkar:

- Girilen sayı adedi tek olduğunda

- Veya döngüde i + 1 erişimi yapılırken liste sınır dışına çıkıldığında

- Çözüm için sayılar mutlaka çift sayıda olmalı.
```
📂 Dosya Yapısı
integer-ikilileri-topla/
│── Program.cs
│── README.md
│── integer-ikilileri-topla.csproj
```
## 🧠 Mantık Özeti

- Kullanıcıdan string olarak sayı listesi alınır.

- Boşluklara göre parçalanır → integer dizi.

- Dizideki her iki sayı bir ikili oluşturur.

- Karşılaştırma yapılır:

- farklı → toplam yazdır

- aynı → toplamın karesi yazdır

- Sonuçlar ekrana basılır.
