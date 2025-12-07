namespace Projeler
{
   class AverageCalculator
    {
        public double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("Liste boş olamaz.");

            return numbers.Average();
        }
    }
}
