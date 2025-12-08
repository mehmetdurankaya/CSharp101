namespace mutlak_karealma.Utils
{
    public static class InputParser
    {
        public static int[] ParseNumbers(string input)
        {
            return input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
        }
    }
}
