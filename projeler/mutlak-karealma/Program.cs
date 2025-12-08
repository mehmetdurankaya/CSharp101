using mutlak_karealma.Services;
using mutlak_karealma.Utils;

namespace mutlak_karealma
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Sayıları girin: ");
      string input = Console.ReadLine();

      int[] numbers = InputParser.ParseNumbers(input);
      var processor = new NumberProcessor();

      var result = processor.ProcessNumbers(numbers);

      Console.WriteLine(result);
    }
  }
}
