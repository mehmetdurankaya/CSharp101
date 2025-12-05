📘 C# Hazır Metotlar – String İşlemleri (Örnek Kod Açıklamaları)

Bu proje, C# dilinde string veri tipi üzerinde kullanılan hazır metotları örneklerle gösterir.
Kullanılan tüm string fonksiyonları program içinde tek tek çalıştırılır ve sonuçları ekrana yazdırılır.

🚀 Çalıştırma

Proje içerisindeki Program.cs dosyasını bir C# çalışma ortamında (VS, VS Code, Rider, dotnet CLI) çalıştırarak tüm metot örneklerini inceleyebilirsiniz.

📚 İçerik

Kodda işlenen konu başlıklarının listesi:

Length

ToUpper / ToLower

Concat

Compare / CompareTo

Contains / EndsWith / StartsWith

IndexOf / LastIndexOf

Insert

PadLeft / PadRight

Remove

Replace

Split

Substring

Her bölümün örneği aşağıda açıklamalarıyla birlikte verilmiştir.

🔍 Kullanılan Metotlar ve Açıklamaları
1️⃣ Length

Bir string’in karakter sayısını verir.

degisken.Length;

2️⃣ ToUpper / ToLower

Metni tamamen büyük ya da küçük harfe çevirir.

degisken.ToUpper();
degisken.ToLower();

3️⃣ Concat

İki string’i birleştirir.

string.Concat(degisken, " Merhaba!");

4️⃣ Compare & CompareTo

İki string’i karşılaştırır.

degisken.CompareTo(degisken2);
string.Compare(degisken, degisken2, true);

5️⃣ Contains / EndsWith / StartsWith

Alt string var mı, belirli string ile bitiyor/baslıyor mu kontrol eder.

degisken.Contains(degisken2);
degisken.EndsWith("Hoşgeldiniz!");
degisken.StartsWith("Merhaba");

6️⃣ IndexOf / LastIndexOf

Alt string’in ilk veya son geçtiği yerin indeksini verir.

degisken.IndexOf("CS");
degisken.LastIndexOf("i");

7️⃣ Insert

Belirtilen konuma yeni metin ekler.

degisken.Insert(10, "Merhaba! ");

8️⃣ PadLeft / PadRight

String’i sağa veya sola belirli karakterlerle genişletir.

degisken2.PadLeft(30);
degisken.PadRight(50, '-');

9️⃣ Remove

Belirtilen indexten itibaren metni siler.

degisken.Remove(10);
degisken.Remove(5, 3);

🔟 Replace

Belirli karakter veya metni başka bir metinle değiştirir.

degisken.Replace("CSharp", "C#");

1️⃣1️⃣ Split

String’i ayırıcıya göre böler ve dizide tutar.

degisken.Split(' ')[0];

1️⃣2️⃣ Substring

Metnin belirli bir bölümünü alır.

degisken.Substring(5);
degisken.Substring(4, 6);

🧪 Örnek Stringler

Kodun başlangıcında kullanılan örnek metinler:

string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "Dersimiz CSharp";


Bu metinler tüm işlemlerde örnek olarak kullanılır.

✔️ Sonuç

Bu proje, C# string metotlarını öğrenmek isteyenler için pratik bir başvuru niteliğindedir.
Her metot, gerçek örneklerle gösterilmiş ve ekrana yazdırılarak sonuçları test edilmiştir.
