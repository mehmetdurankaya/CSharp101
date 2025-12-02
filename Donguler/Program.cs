using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngüler birer static metoda dönüştürüldü
            
            forLoopExamle();//for loop örneği
            whileLoopExample();//while loop örneği
            foreachLoopExample();//foreach loop örneği
            
        }
    public static void forLoopExamle()
    {
      // for loop to print numbers from 1 to 10
      Console.WriteLine("********** For Loop Start **********");
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
                else{
                        Console.WriteLine($"Çift Sayıların Toplamı:{ciftToplam += i}");
                }
            }
          }
    public static void whileLoopExample()
    {
        /*while 
            1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp
            console a yazdıran program.
            */
            Console.WriteLine("********** While Loop Start **********");
            Console.Write("Lütfen Bir Sayı Giriniz:");  
            int sayi = int.Parse(Console.ReadLine());
            int sayac2 = 1;
            int toplam = 0;
            while (sayac2 <= sayi)
            {
               toplam += sayac2;
                sayac2++;
            }
            Console.WriteLine($"Ortalama : {toplam / sayi}");            
    }
    public static void foreachLoopExample()
    {
        // foreach loop
        Console.WriteLine("********** Foreach Loop Start **********");
        string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }       
    }
    }
}
