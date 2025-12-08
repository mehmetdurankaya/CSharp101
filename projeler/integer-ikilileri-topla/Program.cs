namespace integer_ikilileri_topla
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Sayıları girin: ");
      int[] numbers = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

      // Çift sayı kontrolü
      if (numbers.Length % 2 != 0)
      {
        Console.WriteLine("HATA: Lütfen çift sayıda değer giriniz. (Örn: 2 3 1 5)");
        return;
      }

      for (int i = 0; i < numbers.Length; i += 2)
      {
        int a = numbers[i];
        int b = numbers[i + 1];

        if (a != b)
        {
          Console.Write((a + b) + " ");
        }
        else
        {
          int kare = a * a;
          int kare2 = kare * kare;
          Console.Write(kare2 + " ");
        }
      }
    }
  }
}
