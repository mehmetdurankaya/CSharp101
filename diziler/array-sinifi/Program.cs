using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("***** Sırasız Dizi *****");

            foreach (var sayi in sayiDizisi)
            {
                Console.Write($" {sayi}");
            }
            Array.Sort(sayiDizisi);
            Console.WriteLine();
            Console.WriteLine("***** Sıralı Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.Write($" {sayi}");
            }
            //Clear
            Console.WriteLine();
            Console.WriteLine("***** Array Clear *****");
            //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write($" {sayi}");
            }
            //Reverse
            Console.WriteLine();
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write($" {sayi}");
            }
            //IndexOf
            Console.WriteLine();
            Console.WriteLine("***** Array IndexOf *****");
            int index = Array.IndexOf(sayiDizisi, 23);
            Console.WriteLine("23 sayısının indeksi: " + index);

            //Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.Write($" {sayi}");
            }

        }
    }
}
