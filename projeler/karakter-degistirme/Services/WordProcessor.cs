namespace karakter_degistirme
{
   public class WordProcessor
    {
        public string Process(string input)
        {
            string[] wordsArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var resultList = new List<string>();

            foreach (var w in wordsArray)
            {
                var word = new Word(w);
                resultList.Add(word.SwapFirstAndLast());
            }

            return string.Join(" ", resultList);
        }
    }
}
