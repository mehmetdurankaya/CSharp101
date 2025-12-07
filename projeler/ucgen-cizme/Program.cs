namespace Ucgenciz
{
  class Program
  {
    public static void Main(String[] args)
    {
            var inputHandler = new InputHandler();
            var trianglePrinter = new TrianglePrinter();

            int height = inputHandler.GetTriangleHeight();
            trianglePrinter.PrintTriangle(height);
    }
  }
}
