namespace Projeler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Fibonacci serisi uzunluğunu girin: ");
      if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
      {
        Console.WriteLine("Geçerli bir pozitif sayı girin.");
        return;
      }

      var fibonacciCalculator = new FibonacciCalculator();
      var averageCalculator = new AverageCalculator();

      var series = fibonacciCalculator.GenerateSeries(length);
      double average = averageCalculator.CalculateAverage(series);

      Console.WriteLine($"Fibonacci Serisi: {string.Join(", ", series)}");
      Console.WriteLine($"Ortalama: {average}");
    }
  }


}
