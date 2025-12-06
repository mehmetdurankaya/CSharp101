using System.Security.Cryptography.X509Certificates;

namespace Name
{
  public class GenericCollection
  {
    public static void Main(string[] args)
    {
      //Generic Collection Kullanımı

      List<int> sayiListesi = new List<int>();// int tipinde bir liste oluşturuyoruz.
      // Liste içerisine eleman eklemek için Add metodunu kullanıyoruz. 
      sayiListesi.Add(23);
      sayiListesi.Add(10); sayiListesi.Add(23);
      sayiListesi.Add(4);
      sayiListesi.Add(5);
      sayiListesi.Add(92);
      sayiListesi.Add(34);

      List<string> renkListesi = new List<string>();
      renkListesi.Add("Kırmızı");
      renkListesi.Add("Mavi");
      renkListesi.Add("Turuncu");
      renkListesi.Add("Sarı");
      renkListesi.Add("Yeşil");

      //Count
      Console.WriteLine("Sayi Listesi Eleman Sayısı: " + sayiListesi.Count);
      Console.WriteLine("Sayi Listesi Eleman Sayısı: " + renkListesi.Count);

      foreach (var sayi in sayiListesi)
        Console.Write($"- {sayi}");

      Console.WriteLine(" ");
      foreach (var renk in renkListesi)
        Console.Write($"- {renk}");

      //ForEach
      Console.WriteLine(" ");

      sayiListesi.ForEach(sayi => Console.Write($" - {sayi}"));
      Console.WriteLine(" ");
      renkListesi.ForEach(renk => Console.Write($" - {renk}"));

      //Listeden Eleman Silme
      Console.WriteLine(" ");

      sayiListesi.Remove(4);
      renkListesi.Remove("Yeşil");

      sayiListesi.ForEach(sayi => Console.Write($" - {sayi}"));
      Console.WriteLine(" ");
      renkListesi.ForEach(renk => Console.Write($" - {renk}"));
      Console.WriteLine(" ");


      sayiListesi.RemoveAt(0);
      renkListesi.RemoveAt(1);

      sayiListesi.ForEach(sayi => Console.Write($" - {sayi}"));
      Console.WriteLine(" ");
      renkListesi.ForEach(renk => Console.Write($" - {renk}"));
      Console.WriteLine(" ");

      //Liste içerisinde arama
      if (sayiListesi.Contains(10))
      {
        Console.WriteLine("10 Sayısı Listede Mevcut");
      }
      // Eleman ile indexe erişim
      renkListesi.BinarySearch("Mavi"); // İkili Arama
      // Diziyi List'e çevirme
      string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
      List<string> hayvanListesi = new List<string>(hayvanlar);

      //Listeyi Nasıl temizleriz?
      hayvanListesi.Clear();

      //List içerisinde nesne tutmak
      List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
      Kullanicilar kullanici1 = new Kullanicilar();
      kullanici1.Isim = "Mehmet Duran";
      kullanici1.Soyisim = "Kaya";
      kullanici1.Yas = 48;

      Kullanicilar kullanici2 = new Kullanicilar();
      kullanici2.Isim = "Turan";
      kullanici2.Soyisim = "Kaya";
      kullanici2.Yas = 40;

      kullaniciListesi.Add(kullanici1);
      kullaniciListesi.Add(kullanici2);

      List<Kullanicilar> yeniListe = new List<Kullanicilar>();

      yeniListe.Add(new Kullanicilar()
      {
        Isim = "Nizamettin",
        Soyisim = "Kaya",
        Yas = 20
      });
      foreach (var kullanici in kullaniciListesi)
      {
        Console.WriteLine("Kullanıcı Adı:" + kullanici.Isim);
        Console.WriteLine("Kullanıcı Soyisim" + kullanici.Soyisim);
        Console.WriteLine("Kullanıcı Yaş: " + kullanici.Yas);
      }
    }
  }
  public class Kullanicilar
  {
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
  }
}

