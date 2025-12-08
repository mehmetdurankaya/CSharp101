namespace karakter_degistirme
{
  public class Word
    {
        public string Text { get; private set; }

        public Word(string text)
        {
            Text = text;
        }

        public string SwapFirstAndLast()
        {
            if (Text.Length <= 1)
                return Text;

            char first = Text[0];
            char last = Text[Text.Length - 1];
            string middle = Text.Substring(1, Text.Length - 2);

            return last + middle + first;
        }
    }
}
