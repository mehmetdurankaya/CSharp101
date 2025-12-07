namespace Encapsulation
{
  class Program
  {
    static void Main(string[] args)
    {

      Ogrenci ogrenci = new Ogrenci();
      ogrenci.Isim = "Mehmet Duran";
      ogrenci.Soyisim = "Kaya";
      ogrenci.OgrenciNo = 9999;
      ogrenci.Sinif = 4;
      ogrenci.OgrenciBilgileriniGetir();
      ogrenci.SinifDusur();
      ogrenci.OgrenciBilgileriniGetir();

      Ogrenci ogrenci2 = new Ogrenci("Nizamettin", "Kaya", 6666, 2);
      ogrenci2.SinifDusur();
      ogrenci2.SinifDusur();
      ogrenci2.OgrenciBilgileriniGetir();
    }
  }
  class Ogrenci
  {
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
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

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
      Isim = isim;
      Soyisim = soyisim;
      OgrenciNo = ogrenciNo;
      Sinif = sinif;
    }
    public Ogrenci() { }
    public void OgrenciBilgileriniGetir()
    {
      Console.WriteLine("****Öğrenci Bilgileri****");
      Console.WriteLine("Öğrenci adı:     " + this.Isim);
      Console.WriteLine("Öğrenci soyadı:  " + this.Soyisim);
      Console.WriteLine("Öğrenci no:      " + this.OgrenciNo);
      Console.WriteLine("Öğrenci sınıfı:  " + this.Sinif);
    }
    public void SinifAtlat()
    {
      this.Sinif = this.Sinif + 1;
    }
    public void SinifDusur()
    {
      this.Sinif = this.Sinif - 1;
    }

  }
}

