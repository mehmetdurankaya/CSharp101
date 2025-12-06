using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);

            int[] enKucuk = { sayilar[0], sayilar[1], sayilar[2] };
            int[] enBuyuk = { sayilar[17], sayilar[18], sayilar[19] };

            double ortKucuk = Ortalama(enKucuk);
            double ortBuyuk = Ortalama(enBuyuk);

            Console.WriteLine($"\nEn küçük 3 sayı ortalaması: {ortKucuk}");
            Console.WriteLine($"En büyük 3 sayı ortalaması: {ortBuyuk}");
            Console.WriteLine($"Ortalama toplamı: {ortKucuk + ortBuyuk}");
        }

        static double Ortalama(int[] dizi)
        {
            int toplam = 0;
            foreach (var x in dizi) toplam += x;
            return (double)toplam / dizi.Length;
        }
    }

  }


