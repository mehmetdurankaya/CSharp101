using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop to print numbers from 1 to 10
            Console.Write("Lütfen Bir Sayı Giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            int tekTpolam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= sayac; i++)
            {
              if (i % 2 == 1)
               {
                  Console.WriteLine($"Tek sayıların Tpolamı : {tekTpolam += i}");
               }
        else
        {
                  Console.WriteLine($"Çift Sayıların Toplamı:{ciftToplam += i}");
        }
            }
        }
    }
}
