using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //ArrayList sınıfu kullanıldı
      ArrayList asal = new ArrayList();
      ArrayList asalDegil = new ArrayList();

      int sayac = 0;

      while (sayac < 20)
      {
        Console.WriteLine(
        "Uygulama sizden 20 adet pozitif sayı girmenizi ister \n"
        + "Giriş yapılan sayıların asal olup olmadığını kontrol eder\n"
        + "Asal olan ve Asal olmayan sayıları büyükten küçüğe sıralar ve ekrana yazdırır.\n"
        + "Asal ve Asal olmayan iki dizinin de eleman sayısını ve ortalamasını hesaplar ekrana yazdırır.");
        Console.Write($"{sayac + 1}. sayıyı girin: ");
        string giris = Console.ReadLine();

        if (int.TryParse(giris, out int sayi) && sayi > 0)
        {
          if (AsalMi(sayi)) asal.Add(sayi);
          else asalDegil.Add(sayi);

          sayac++;
        }
        else
        {
          Console.WriteLine("Lütfen pozitif bir sayı girin!");
        }
      }

      asal.Sort();
      asal.Reverse();
      asalDegil.Sort();
      asalDegil.Reverse();

      Console.WriteLine("\n--- ASAL SAYILAR ---");
      YazdirVeIstatistik(asal);

      Console.WriteLine("\n--- ASAL OLMAYAN SAYILAR ---");
      YazdirVeIstatistik(asalDegil);
    }

    static bool AsalMi(int sayi)
    {
      if (sayi < 2) return false;
      for (int i = 2; i <= Math.Sqrt(sayi); i++)
      {
        if (sayi % i == 0) return false;
      }
      return true;
    }

    static void YazdirVeIstatistik(ArrayList liste)
    {
      foreach (var x in liste)
        Console.Write(x + " ");

      Console.WriteLine($"\nEleman sayısı: {liste.Count}");

      int toplam = 0;
      foreach (var x in liste) toplam += (int)x;

      Console.WriteLine($"Ortalama: {(double)toplam / liste.Count}");
    }
  }

}


