namespace Projeler
{
  class FibonacciCalculator
  {
    public List<int> GenerateSeries(int length)
    {
      var series = new List<int>();

      if (length <= 0) return series;

      series.Add(0);
      if (length == 1) return series;

      series.Add(1);
      for (int i = 2; i < length; i++)
      {
        series.Add(series[i - 1] + series[i - 2]);
      }
      return series;
    }
  }
}
