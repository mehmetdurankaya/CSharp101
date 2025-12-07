namespace DaireCiz
{
  class Program
  {
    public static void Main(String[] args)
    {
      Circle circle = new Circle();

      Console.Write(" Dairenin yarıçapını giriniz: ");
      int radius = int.Parse(Console.ReadLine());

      circle.DrawCircle(radius);

      Console.ReadKey();
    }
  }
}
