namespace Ucgenciz
{
  class Program
  {
    public static void Main(String[] args)
    {
        Console.Write("Metin ve index girin (örn: Algoritma,3): ");
        string input = Console.ReadLine();

        // "Algoritma,3" → ["Algoritma", "3"]
        string[] parts = input.Split(',');

        if (parts.Length != 2)
        {
            Console.WriteLine("Hatalı format! Örnek kullanım: Kelime,3");
            return;
        }

        string text = parts[0];
        if (!int.TryParse(parts[1], out int index))
        {
            Console.WriteLine("Index bir sayı olmalı!");
            return;
        }

        // Index kontrolü
        if (index < 0 || index >= text.Length)
        {
            Console.WriteLine(text); // Değişmeden yazılır
            return;
        }

        // Karakteri çıkartma
        // Örn: "Algoritma" ve index=3 → "Alg" + "ritma"
        string result = text.Remove(index, 1);

        Console.WriteLine(result);
    }
  }
}
