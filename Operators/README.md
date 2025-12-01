# ⚙️ C# 101 – Operatörler (Patika.dev Notları)

Bu doküman, Patika.dev C# 101 eğitimi kapsamında öğrendiğim **operatörler konusunun özetini** ve örneklerini içerir. C# dilinde operatörler, değişkenler üzerinde işlem yapmamızı sağlayan temel yapılardır.

---

## 📌 1. Atama ve İşlemli Atama Operatörleri

Değişkenlere değer atamak veya mevcut değeri işlem yaparak güncellemek için kullanılır.

| Operatör | Açıklama |
|----------|----------|
| `=`  | Atama |
| `+=` | Toplayarak atama |
| `-=` | Çıkararak atama |
| `*=` | Çarparak atama |
| `/=` | Bölerek atama |

### **Örnek Kod:**

```csharp
int x = 3;
int y = 3;

y = y + 2; // 5
y += 2;    // 7
y /= 1;    // 7
x *= 2;    // 6

Console.WriteLine(x);
Console.WriteLine(y);
📌 2. Mantıksal Operatörler

Koşullar ile çalışırken sıkça kullanılır.

Operatör	Açıklama
&&	VE
`	
!	DEĞİL
bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect!");

if (isSuccess || isCompleted)
    Console.WriteLine("Great!");

if (isSuccess && !isCompleted)
    Console.WriteLine("Fine!");

📌 3. İlişkisel Operatörler

Değerleri karşılaştırmak için kullanılır. Sonuç olarak true veya false döner.

Operatör	Açıklama
<	Küçüktür
>	Büyüktür
<=	Küçük eşittir
>=	Büyük eşittir
==	Eşittir
!=	Eşit değildir
int a = 3;
int b = 4;

Console.WriteLine(a < b);   // True
Console.WriteLine(a > b);   // False
Console.WriteLine(a >= b);  // False
Console.WriteLine(a <= b);  // True
Console.WriteLine(a == b);  // False
Console.WriteLine(a != b);  // True

📌 4. Aritmetik Operatörler

Matematiksel işlemler için kullanılır.

Operatör	Açıklama
+	Toplama
-	Çıkarma
*	Çarpma
/	Bölme
%	Mod (Kalan)
int x = 10;
int y = 5;

Console.WriteLine(x + y); // 15
Console.WriteLine(x - y); // 5
Console.WriteLine(x * y); // 50
Console.WriteLine(x / y); // 2
Console.WriteLine(x % 3); // 1

int x = 10;
int y = 5;

Console.WriteLine(x + y); // 15
Console.WriteLine(x - y); // 5
Console.WriteLine(x * y); // 50
Console.WriteLine(x / y); // 2
Console.WriteLine(x % 3); // 1

🎯 Özet

Bu bölümde öğrendiğim operatörler:

✔ Atama Operatörleri

✔ İşlemli Atama Operatörleri

✔ Mantıksal Operatörler

✔ İlişkisel Operatörler

✔ Aritmetik Operatörler

✔ Mod Alma Operatörü

Hepsi C# 101 seviyesinin temel taşlarını oluşturur.

