using System;

namespace odev1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0; // döngünün başlaması için başlangıç değeri

            while (x != 5)
            {
                Console.Write(
                    "\nLütfen bir seçenek seçin: \n" +
                    "1. Çift Sayıları Yazdır\n" +
                    "2. Tam bölünenleri Yazdır\n" +
                    "3. Kelimeleri Tersten Yazdır\n" +
                    "4. Kelime ve Harf Sayisini Hesapla\n" +
                    "5. Çıkış Yap\n" +
                    "Seçiminiz: ");

                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        ciftSayilariYazdir();
                        break;

                    case 2:
                        tamBolunenleriYazdir();
                        break;

                    case 3:
                        kelimeleriTerstenYazdir();
                        break;

                    case 4:
                        KelimeVeHarfSayisiniHesapla();
                        break;

                    case 5:
                        Console.WriteLine("Programdan çıkılıyor...");
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }
            }
        }

        public static void ciftSayilariYazdir()
        {
            // 1. Uygulama
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];

            Console.WriteLine($"{n} adet pozitif sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Çift sayılar:");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                    Console.Write($" {sayi} ");
            }
            Console.WriteLine("");
        }

        public static void tamBolunenleriYazdir()
        {
            // 2. Uygulama
            Console.Write("Pozitif bir sayı giriniz (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Pozitif bir sayı daha giriniz (m): ");
            int m = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];

            Console.WriteLine($"{n} adet pozitif sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"m'e eşit veya tam bölünen sayılar (m = {m}):");
            foreach (int sayi in sayilar)
            {
                if (sayi == m || sayi % m == 0)
                    Console.WriteLine(sayi);
            }
        }
        static void kelimeleriTerstenYazdir()
        {
            // 3. Uygulama
            Console.Write("Pozitif bir sayı giriniz (n): ");
            int n = int.Parse(Console.ReadLine());

            string[] kelimeler = new string[n];

            Console.WriteLine($"{n} adet kelime giriniz:");
            for (int i = 0; i < n; i++)
            {
                kelimeler[i] = Console.ReadLine();
            }

            Console.WriteLine("Kelimelerin tersten yazılışı:");
            Array.Reverse(kelimeler);

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
        static void KelimeVeHarfSayisiniHesapla()
        {
            // 4. Uygulama
            Console.Write("Bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int kelimeSayisi = kelimeler.Length;

            int harfSayisi = 0;
            foreach (var kelime in kelimeler)
            {
                harfSayisi += kelime.Length;
            }

            Console.WriteLine($"Toplam kelime sayısı: {kelimeSayisi}");
            Console.WriteLine($"Toplam harf sayısı: {harfSayisi}");
        }
    }

}




