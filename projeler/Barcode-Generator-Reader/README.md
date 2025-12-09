## 📦 Barcode Generator & Reader (C# Console App)

Bu proje, ZXing kütüphanesini kullanarak QR kod / barkod üreten ve daha sonra aynı dosyayı okuyabilen bir C# Console Application örneğidir.
Uygulama tamamen OOP mimarisi ile tasarlanmıştır ve 3 temel servis içerir:

- BarcodeGenerator → Barkod oluşturur

- FileService → Barkod dosyasını kaydeder

- BarcodeReaderService → Barkodu okur

## 🚀 Özellikler

- Console tabanlı çalışma

- ZXing.Net (3rd party library) kullanımı

- Dosyaya PNG olarak barkod kaydetme

Kaydedilen barkodu okuma

- OOP yapısına uygun katmanlı mimari

- Hata yönetimi

- Tamamen offline çalışır

## 📁 Proje Klasör Yapısı
```
Barcode-Generator-Reader/
│
├── Program.cs
├── Models/
│   └── BarcodeResult.cs
│
└── Services/
    ├── BarcodeGenerator.cs
    ├── BarcodeReaderService.cs
    └── FileService.cs
```
## 📦 Kullanılan NuGet Paketleri

Projeyi çalıştırmadan önce aşağıdaki paketleri yükle:
```
ZXing.Net
System.Drawing.Common
```

CLI ile yüklemek istersen:
```
dotnet add package ZXing.Net
dotnet add package System.Drawing.Common
```
## 🛠 Kurulum ve Çalıştırma

Projeyi klonla veya indir:
```
git clone https://github.com/kendin/Barcode-Generator-Reader.git

```
Proje klasörüne gir:
```
cd Barcode-Generator-Reader
```

NuGet bağımlılıklarını yükle:
```
dotnet restore
```

Çalıştır:
```
dotnet run
```
## 🧩 Kullanım Akışı
1️⃣ **Barkod İçeriği Girilir**

Program senden bir metin ister:
```
Barcode içeriği girin:
```

Örnek:
```
HELLO-WORLD-123
```
2️⃣ **Barkod Oluşturulur**

- İçerik barcode’a dönüştürülür

- "Belgelerim/Barcodes/barcode.png" yoluna kaydedilir

3️⃣ **Barcode Okunur**

- Uygulama oluşturduğu PNG dosyasını açar

- İçeriği çözer

- Konsola yazdırır

## 📷 Örnek Çıktı
```
Barcode içeriği girin: TURAN123

Barcode oluşturuldu ve kaydedildi.

Barcode Başarıyla Okundu:
İçerik: TURAN123
Dosya: C:\Users\...\Documents\Barcodes\barcode.png
```
## 🧱 OOP Yapısına Genel Bakış
**BarcodeGenerator**

- Girilen string'den QR Code üretir

- byte[] olarak döndürür

**FileService**

- Byte verisini belirtilen klasöre kaydeder

- Klasör yoksa oluşturur

**BarcodeReaderService**

- PNG dosyasını okur

- ZXing ile decode eder

- BarcodeResult döner

**BarcodeResult Model**

- Okunan içerik

- Dosya yolu
## ⚠️ Bilinen Platform Notları

Windows üzerinde System.Drawing desteklenir.
Linux/Mac’te kullanacaksan libgdiplus kurulmalıdır.

## 📝 Lisans

Bu proje tamamen eğitim ve demo amaçlıdır. Dilediğiniz gibi kullanabilirsiniz.
