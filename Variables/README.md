# ⚡ C# Tip Dönüşümleri – Örnekler ve Notlar

Bu repo, C# 101 kapsamında **tip dönüşümleri (type conversion)** konusunu örneklerle göstermektedir.  
Kodda hem **implicit (örtük)** hem de **explicit (açık)** dönüşümler, ayrıca **ToString**, **Convert** ve **Parse** metodları kullanılmıştır.

---

## 📌 1. Implicit Conversion (Bilinçsiz Dönüşüm)

- Küçük boyutlu veri tipleri **otomatik olarak** daha büyük veri tiplerine dönüştürülebilir.  
- Veri kaybı riski yoktur.

```csharp
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;   // byte, sbyte ve short -> int
Console.WriteLine("d: " + d);

long h = d;          // int -> long
Console.WriteLine("h: " + h);

float i = h;         // long -> float
Console.WriteLine("i: " + i);

string e = "Mehmet Duran Kaya";
char f = 'k';
object g = e + f + d; // string + char + int -> object
Console.WriteLine("g: " + g);
📌 2. Explicit Conversion (Bilinçli Dönüşüm / Casting)

Küçük veri tiplerine veya veri kaybı olabilecek dönüşümler için cast kullanılır.
int x = 4;
byte y = (byte)x;
Console.WriteLine("y: " + y);

int z = 100;
byte t = (byte)z;   // 100 byte içine sığar
Console.WriteLine("t: " + t);

float w = 10.3f;
byte v = (byte)w;    // Ondalık kısm kaybolur
Console.WriteLine("v: " + v);

📌 3. ToString() Metodu

Her veri tipinin .ToString() metodu vardır ve string tipine çevirmek için kullanılır.
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy: " + yy);

string zz = 12.5f.ToString();
Console.WriteLine("zz: " + zz);
📌 4. System.Convert Sınıfı
string s1 = "10", s2 = "20";
int sayi1 = Convert.ToInt32(s1);
int sayi2 = Convert.ToInt32(s2);
int toplam = sayi1 + sayi2;
Console.WriteLine("Toplam: " + toplam);
📌 5. Parse Metodu
String tipindeki sayısal değerleri ilgili sayısal tipe dönüştürmek için kullanılır.
string metin1 = "10";
string metin2 = "10.25";

int rakam1 = Int32.Parse(metin1);
double double1 = Double.Parse(metin2);

Console.WriteLine("rakam1: " + rakam1);
Console.WriteLine("double1: " + double1);

🎯 Özet
Dönüşüm Tipi	Açıklama
Implicit (örtük)	Küçük tip -> büyük tip, veri kaybı riski yok
Explicit (cast)	Veri kaybı riski olan dönüşümler için (tip) kullanılır
ToString()	Her tip -> string dönüşümü
Convert sınıfı	String ve diğer tipler arası dönüşüm sağlar
Parse	String -> sayısal tip dönüşümü


