# 🌐 Switch Case ile Ay ve Mevsim Belirleme

Bu proje, kullanıcıdan **1 ile 12 arasında bir sayı** alarak hem ilgili **ayı** hem de **mevsimi** ekrana yazdırır. C# dilinde `switch-case` yapısını öğretmek ve mevsim eşleştirmesi yapmak için hazırlanmıştır.

---

## 1. Program Açıklaması

* Kullanıcıdan bir **ay numarası** (1-12) alınır.
* `switch-case` yapısı ile hangi ayın seçildiği belirlenir ve ekrana yazdırılır.
* İkinci bir `switch-case` ile **ay mevsime eşleştirilir** ve ekrana yazdırılır.
* Geçersiz girişler için `default` bloğu çalışır.

---

## 2. Kullanılan Yapılar

* **switch-case**: Belirli durumlara göre kod çalıştırmak için kullanılır.
* **case blokları**: Her bir ay için ayrı mesaj içerir.
* **break**: Switch bloğundan çıkmak için kullanılır.
* **default**: Hiçbir case eşleşmediğinde çalışır.
* Çoklu case kullanımı: Aynı mevsime ait ayları tek blokta toplamak için.

---

## 3. Örnek Kod

```csharp
Console.WriteLine("Please select a numerical month between 1 and 12");
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 1: Console.WriteLine("January"); break;
    case 2: Console.WriteLine("February"); break;
    case 3: Console.WriteLine("March"); break;
    case 4: Console.WriteLine("April"); break;
    case 5: Console.WriteLine("May"); break;
    case 6: Console.WriteLine("June"); break;
    case 7: Console.WriteLine("July"); break;
    case 8: Console.WriteLine("August"); break;
    case 9: Console.WriteLine("September"); break;
    case 10: Console.WriteLine("October"); break;
    case 11: Console.WriteLine("November"); break;
    case 12: Console.WriteLine("December"); break;
    default: Console.WriteLine("Yanlış Seçim Yaptınız!"); break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Spring");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Summer");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Autumn");
        break;
}
```

---

## 4. Örnek Çıktılar

### Geçerli Giriş (month = 3)

```
Please select a numerical month between 1 and 12
March
Spring
```

### Geçersiz Giriş (month = 15)

```
Please select a numerical month between 1 and 12
Yanlış Seçim Yaptınız!
```

---

## 5. Notlar

* Çoklu case kullanımı sayesinde **mevsim ataması daha kısa ve okunabilir** hale gelir.
* `default` bloğu, kullanıcı hatalı giriş yaptığında mesaj vermek için kullanılır.
* `break` komutu, her case sonunda switch’den çıkmayı sağlar ve hatalı çalışmaları önler.
