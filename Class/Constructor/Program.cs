namespace Class
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Söz dizimi
      // class sinifAdi
      //{
      //[Erişim belirleyici] [Veri tipi] OzellikAdi;
      //[Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
      //{
      //Metot komutları
      //}
      //}

      //Erişim belirleyiciler
      // * Public
      // * Private
      // * Internal
      // * Protected
      Console.WriteLine("*****Çalışan 1******");
      Console.WriteLine("**Tam Parametreli Constructor ile Çalışan Oluşturma**");
      Calisan calisan1 = new Calisan("Mehmet Duran", "Kaya", 1111111, "Bilgi İşlem");
      calisan1.CalisanBilgileri();

      Console.WriteLine("*****Çalışan 2******");
      Console.WriteLine("**Parametresiz Constructor ile Çalışan Oluşturma**");
      Calisan calisan2 = new Calisan();
      calisan1.Ad = "Nizamettin";
      calisan1.Soyad = "Kaya";
      calisan1.No = 22222222;
      calisan1.Departman = "Muhasebe";
      calisan1.CalisanBilgileri();

      Console.WriteLine("*****Çalışan 3******");
      Console.WriteLine("**İki Parametreli Constructor ile Çalışan Oluşturma**");
      Calisan calisan3 = new Calisan("Ertuğrul", "Kaya");
      Console.WriteLine($"{calisan3.Ad} {calisan3.Soyad}");
    }

    class Calisan
    {
      public string Ad;
      public string Soyad;
      public int No;
      public string Departman;

      public Calisan(string ad, string soyad, int no, string departman) // Constructor 
      {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
      }
      public Calisan() { } //Constructor 2

      public Calisan(string ad, string soyad)
      {
        this.Ad = ad;
        this.Soyad = soyad;
      } // Constructor 3
      public void CalisanBilgileri()
      {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}", No);
        Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
      }


    }
  }
}
