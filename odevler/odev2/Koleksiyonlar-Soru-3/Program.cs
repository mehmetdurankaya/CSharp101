using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Cümleyi girin: ");
      string cumle = Console.ReadLine().ToLower();

      char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
      ArrayList bulunan = new ArrayList();

      foreach (char c in cumle)
        if (Array.IndexOf(sesliler, c) != -1)
          bulunan.Add(c);

      bulunan.Sort();

      Console.WriteLine("\nCümledeki sesli harfler:");
      foreach (var harf in bulunan)
        Console.Write(harf + " ");
    }

  }
}
