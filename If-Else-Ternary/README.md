# 🔧 If-Else Yapısı ve Ternary Operatörü

Bu doküman, C# dilinde **if-else** yapısı ile **ternary operatörünün** nasıl çalıştığını, hangi durumlarda tercih edildiğini ve örnek kullanım senaryolarını açıklamaktadır.

---

## 1. If-Else Yapısı

`if-else` yapısı, bir koşula göre farklı kod bloklarını çalıştırmak için kullanılır. Kodun okunabilirliği yüksektir ve özellikle karmaşık koşullarda tercih edilir.

### **Örnek Kullanım:**

```csharp
bool condition = true;

if (condition)
{
    Console.WriteLine("Değişken: true");
}
else
{
    Console.WriteLine("Değişken: false");
}
```

### **Ne Zaman Kullanılır?**

* Koşullar karmaşıksa
* Birden fazla koşul kontrol edilecekse
* Kodun akışı açık ve anlaşılır olmalıysa

---

## 2. Ternary If (Üçlü Operatör)

Ternary operatörü, `if-else` yapısının daha kısa yazım şeklidir.

### **Sözdizimi:**

```csharp
koşul ? durum_true : durum_false;
```

### **Örnek Kullanım:**

```csharp
bool condition = true;
string result = condition ? "Değişken: true" : "Değişken: false";
Console.WriteLine(result);
```

### **Ne Zaman Kullanılır?**

* Koşul basitse
* Tek satırda hızlı bir karar vermek isteniyorsa
* Kod kısaltılmak isteniyorsa

---

## 3. İki Yapının Karşılaştırması

| Özellik           | If-Else                | Ternary                 |
| ----------------- | ---------------------- | ----------------------- |
| Okunabilirlik     | Yüksek                 | Basit durumlarda yüksek |
| Kod Uzunluğu      | Daha uzun              | Daha kısa               |
| Karmaşık Koşullar | Uygun                  | Uygun değil             |
| Kullanım Amacı    | Açıklık, kontrol akışı | Kısalık, hız            |

---

## 4. Özet

* `if-else` **okunabilir**, detaylı karar yapıları için idealdir.
* `ternary` daha **kısa** ve **pratik** kararlar için tercih edilir.
* İkisi de aynı işlevi görür; seçim tamamen **duruma** ve **kod stiline** bağlıdır.

---

## 5. Ek Örnekler

### Çoklu If-Else Örneği

```csharp
int number = 10;

if (number == 0)
    Console.WriteLine("Sıfır");
else if (number > 0)
    Console.WriteLine("Pozitif");
else
    Console.WriteLine("Negatif");
```

### Ternary ile Basit Örnek

```csharp
int number = 10;
string message = number > 0 ? "Pozitif" : "Pozitif değil";
Console.WriteLine(message);
```
