## 🔒 Encapsulation (Kapsülleme)
Bu proje, C# dilinde encapsulation (kapsülleme) kavramını açıklamak ve uygulamak için hazırlanmış basit bir öğrenci yönetimi örneğidir. Amaç, verilerin doğrudan erişime kapatılması, kontrollü bir şekilde okunup yazılması ve sınıf içinde güvenli bir yapı oluşturulmasını göstermektir.
---
## 📌 Encapsulation Nedir?

**Encapsulation, nesne yönelimli programlamada (OOP):**

- Verilerin dışarıya doğrudan açılmamasını,

- Kontrollü bir şekilde yönetilmesini,

- Sınıf içindeki iş kurallarının dışarıya sızmamasını,

- Gereksiz erişimlerin engellenmesini sağlayan bir mekanizmadır.

Bu amaçla:

- Alanlar (fields) private yapılır

- Dışarıya property veya metotlar açılır

- Property set bloklarında kontroller uygulanabilir

## 🔐 Bu Projede Encapsulation Nasıl Kullanıldı?
✔ Private Alanlar

Ogrenci sınıfındaki tüm alanlar dış dünyaya kapalıdır:
```
private string isim;
private string soyisim;
private int ogrenciNo;
private int sinif;
```

Bu sayede bu alanlara doğrudan müdahale edilemez.

**✔ Property Üzerinden Kontrollü Erişim**

Alanlara erişim, property’ler üzerinden sağlanır.

**Basit property örneği:**
 ```
public string Isim { get => isim; set => isim = value; }

```
Ancak en kritik encapsulation örneği Sinif property’sinde uygulanmıştır.

## 🔎 İş Kuralı Uygulayan Property
```
public int Sinif
{
  get => sinif;
  set
  {
    if (value < 1)
    {
      Console.WriteLine("Sınıf 1 den küçük olamaz");
      sinif = 1;
    }
    else { sinif = value; }
  }
}
```

Bu yapı sayesinde:

- Kullanıcı sınıfı 0 veya -5 yapmak istese bile engellenir

- Hatalı veri girişinde kullanıcı uyarılır

- Veri tutarlılığı korunur

- **İşte encapsulation’ın özü budur.**

## 🧑‍🎓 Sınıf Üzerindeki Encapsulation Odaklı Metotlar
**✔ SinifAtlat()**

- Sınıf bir arttırılır — fakat artırılan değer property’e gider, orada kontrol edilmeye devam eder.

**✔ SinifDusur()**

- Sınıf bir azaltılır — eğer 1’in altına düşerse property otomatik olarak düzeltir.

- Bu metotlar iş kurallarının sınıfın içinde kalmasını sağlar.

## 🧪 Kullanım Örneği
```
Ogrenci ogrenci2 = new Ogrenci("Nizamettin", "Kaya", 6666, 2);
ogrenci2.SinifDusur();
ogrenci2.SinifDusur(); // Burada sınıf 1'in altına düşeceği için kontrol çalışır
ogrenci2.OgrenciBilgileriniGetir();
```

Örnek çıktı:
```
Sınıf 1 den küçük olamaz
Öğrenci sınıfı: 1
```

- Encapsulation sayesinde hatalı veri engellendi.

## 🎯 Encapsulation’dan Elde Edilen Kazanımlar

- Bu proje ile encapsulation şu şekilde sağlandı:

- Veriler doğrudan erişime kapatıldı

- Property üzerinden kontrollü set işlemleri uygulandı

- Sınıf içi iş kuralları saklandı

- Dış dünyadan gelen hatalı girişlerin önüne geçildi

- Nesne güvenilir bir yapıya kavuştu

## 📝 Sonuç

Bu örnek, Encapsulation’ın pratikte nasıl kullanıldığını net şekilde gösterir:

- Veriler gizlendi

- Doğru veri garanti edildi

- Hatalı veri girişleri engellendi

- Nesne davranışları sınıf içinde tutuldu
