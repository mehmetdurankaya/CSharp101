namespace Ucgenciz
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.Write("Metin girin: ");
      string input = Console.ReadLine();

      if (string.IsNullOrEmpty(input))
      {
        Console.WriteLine();
        return;
      }

      string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      for (int i = 0; i < words.Length; i++)
      {
        char[] arr = words[i].ToCharArray();
        Array.Reverse(arr);
        words[i] = new string(arr);
      }

      string output = string.Join(" ", words);
      Console.WriteLine(output);

    }
  }
}

