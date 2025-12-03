# C# Array (Dizi) İşlemleri Uygulaması

Bu proje, C# dilinde diziler üzerinde gerçekleştirilebilecek temel işlemleri örnekleyen bir konsol uygulamasıdır. Kod; sıralama, temizleme, ters çevirme, eleman arama, yeniden boyutlandırma gibi birçok temel `Array` sınıfı işlevini göstermektedir.

---

## 🔧 Kullanılan Array İşlemleri

Uygulamada aşağıdaki dizisel işlemler kullanılmaktadır:

### ✔️ Dizi Elemanlarını Yazdırma  
`foreach` kullanılarak dizinin tüm elemanları ekrana yazdırılır.

### ✔️ Array.Sort  
Diziyi küçükten büyüğe sıralar.

### ✔️ Array.Clear  
Belirtilen index aralığındaki elemanları **0** değerine çeker.

### ✔️ Array.Reverse  
Dizi elemanlarının yerini ters çevirir.

### ✔️ Array.IndexOf  
Dizideki belirli bir elemanın index numarasını döndürür.

### ✔️ Array.Resize  
Dizinin boyutunu artırır veya azaltır.

---

## 📂 Kod Açıklaması

### Sırasız Diziyi Yazdırma
```csharp
foreach (var sayi in sayiDizisi)
{
    Console.Write($" {sayi}");
}

Sıralama (Array.Sort)
```
Array.Sort(sayiDizisi);
```
Clear İşlemi
```csharp
Array.Clear(sayiDizisi, 2, 2);
```
Reverse İşlemi
```csharp
Array.Reverse(sayiDizisi);
```
IndexOf İşlemi
```csharp
int index = Array.IndexOf(sayiDizisi, 23);
```
Resize İşlemi
```csharp
Array.Resize<int>(ref sayiDizisi, 9);
```
📌 Programın Çıktısı (Örnek)
```
***** Sırasız Dizi *****
 23 12 4 86 72 3 11 17

***** Sıralı Dizi *****
 3 4 11 12 17 23 72 86

***** Array Clear *****
 3 4 0 0 17 23 72 86

***** Array Reverse *****
 86 72 23 17 0 0 4 3

***** Array IndexOf *****
23 sayısının indeksi: 5

***** Array Resize *****
 86 72 23 17 0 0 4 3 99
```

