namespace karakter_degistirme
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Metinleri girin: ");
      string input = Console.ReadLine();

      var processor = new WordProcessor();
      string result = processor.Process(input);

      Console.WriteLine(result);
    }
  }
}
