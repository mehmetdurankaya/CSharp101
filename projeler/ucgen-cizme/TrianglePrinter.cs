namespace Ucgenciz
{
  class TrianglePrinter
  {
    public void PrintTriangle(int height)
    {
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(height - i);
        PrintStars(i);
        Console.WriteLine();
      }
    }

    private void PrintSpaces(int count)
    {
      Console.Write(new string(' ', count));
    }

    private void PrintStars(int count)
    {
      Console.Write(new string('*', count * 2 - 1));
    }
  }

}

