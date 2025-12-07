# ToDo Console Application

Bu proje, C# kullanılarak geliştirilmiş, profesyonel mimariye sahip çok dosyalı bir **ToDo Yönetim Uygulamasıdır**. Uygulama; kart ekleme, güncelleme, silme, taşıma ve board listeleme özelliklerini içerirken aynı zamanda güçlü bir katmanlı mimari ve SOLID prensiplerine uygun olarak tasarlanmıştır.

---

## 🚀 Özellikler

* Kart Ekleme
* Kart Güncelleme
* Kart Silme
* Kart Taşıma (TODO → IN PROGRESS → DONE)
* Board Listeleme
* Takım üyeleri yönetimi
* Katmanlı mimari
* Repository Pattern
* Service Layer
* Command Pattern (Menü yapısı)
* Enum tabanlı kart büyüklükleri

---

## 📁 Proje Mimarisi

```
ToDoConsoleApp/
│
├── Core/
│   └── ICommand.cs
│
├── Enums/
│   └── CardSize.cs
│
├── Entities/
│   ├── Card.cs
│   ├── TeamMember.cs
│   └── Board.cs
│
├── Interfaces/
│   ├── ICardRepository.cs
│   ├── ITeamRepository.cs
│   ├── IBoardService.cs
│   └── ITeamService.cs
│
├── Repositories/
│   ├── CardRepository.cs
│   ├── TeamRepository.cs
│   └── MockData.cs
│
├── Services/
│   ├── BoardService.cs
│   └── TeamService.cs
│
├── Commands/
│   ├── AddCardCommand.cs
│   ├── ListBoardCommand.cs
│   ├── DeleteCardCommand.cs
│   ├── MoveCardCommand.cs
│   └── UpdateCardCommand.cs
│
├── UI/
│   └── Menu.cs
│
└── Program.cs
```

---

## 🔧 Kurulum

### 1. Projeyi İndir

```
git clone <repo-url>
```

### 2. Proje Klasörüne Girin

```
cd ToDoConsoleApp
```

### 3. Bağımlılık yok — direkt çalıştırabilirsiniz

```
dotnet run
```

---

## 🧩 Kullanım

Uygulama çalıştığında ana menü karşınıza çıkacak ve aşağıdaki işlemleri yapabileceksiniz:

* **1** → Board Listele
* **2** → Kart Ekle
* **3** → Kart Sil
* **4** → Kart Taşı
* **5** → Kart Güncelle
* **0** → Çıkış

Her işlem kendi command sınıfı tarafından çalıştırılır.

---

## 📌 Mimarinin Temeli

### 1. Repository Pattern

Tüm veri operasyonları soyutlanır ve daha sonra veritabanına geçmek kolaylaşır.

### 2. Service Layer

İş kuralları repository üzerinden yönetilir.

### 3. Command Pattern

Menüdeki her işlem ayrı bir komut sınıfıdır.

### 4. SOLID Uygulaması

* **S**: Tek sorumluluk — her sınıf tek iş yapar.
* **O**: Genişlemeye açık, değişikliğe kapalı.
* **L**: Liskov prensibine uygun interface yapısı.
* **I**: Ayrık interface’ler.
* **D**: Bağımlılıkların soyut üzerinden yönetilmesi.

---

## 📄 Örnek Çıktı

```
=== BOARD LISTESI ===
TODO Line:
- Başlık: Rapor Hazırlama | Atanan: Mehmet Duran Kaya | Boyut: M

IN PROGRESS Line:
(boş)

DONE Line:
(boş)
```

---

## 🤝 Katkıda Bulunma

Pull request gönderebilir veya issue açabilirsiniz.

---

## 📜 Lisans

Bu proje MIT lisansı ile yayınlanmıştır.
