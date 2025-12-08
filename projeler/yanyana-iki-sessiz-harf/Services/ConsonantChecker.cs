using yanyana_iki_sessiz_harf.Models;

namespace yanyana_iki_sessiz_harf
{  

public class ConsonantChecker
    {
        private readonly string _vowels = "aeıioöuüAEIİOÖUÜ";

        public bool HasDoubleConsonant(Word word)
        {
            string text = word.Text;

            for (int i = 0; i < text.Length - 1; i++)
            {
                bool currentIsConsonant = !_vowels.Contains(text[i]);
                bool nextIsConsonant = !_vowels.Contains(text[i + 1]);

                if (currentIsConsonant && nextIsConsonant)
                    return true;
            }

            return false;
        }
    }
}
