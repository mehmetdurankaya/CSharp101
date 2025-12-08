
using yanyana_iki_sessiz_harf.Models;
namespace yanyana_iki_sessiz_harf
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metinleri girin: ");
            string input = Console.ReadLine();

            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var checker = new ConsonantChecker();

            foreach (var w in words)
            {
                var word = new Word(w);
                Console.Write(checker.HasDoubleConsonant(word) + " ");
            }
        }
    }
}
