using System;

namespace mutlak_karealma.Services
{
    public class NumberProcessor
    {
        private const int ComparisonValue = 67;

        public NumberResult ProcessNumbers(int[] numbers)
        {
            var result = new NumberResult();

            foreach (int number in numbers)
            {
                if (number < ComparisonValue)
                {
                    result.KucukToplam += (ComparisonValue - number);
                }
                else if (number > ComparisonValue)
                {
                    int diff = Math.Abs(number - ComparisonValue);
                    result.BuyukToplam += diff * diff;
                }
            }

            return result;
        }
    }
}
