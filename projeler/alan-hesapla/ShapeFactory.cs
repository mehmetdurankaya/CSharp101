namespace alan_hesapla
{
  public static class ShapeFactory
  {
    public static IShape CreateShape(string type)
    {
      switch (type.ToLower())
      {
        case "daire":
          Console.Write("Yarıçap: ");
          return new Circle(double.Parse(Console.ReadLine()));

        case "kare":
          Console.Write("Kenar: ");
          return new Square(double.Parse(Console.ReadLine()));

        case "dikdörtgen":
          Console.Write("Genişlik: ");
          double w = double.Parse(Console.ReadLine());
          Console.Write("Yükseklik: ");
          double h = double.Parse(Console.ReadLine());
          return new Rectangle(w, h);

        case "üçgen":
        case "ucgen":
          Console.Write("1. Kenar: ");
          double a = double.Parse(Console.ReadLine());
          Console.Write("2. Kenar: ");
          double b = double.Parse(Console.ReadLine());
          Console.Write("3. Kenar: ");
          double c = double.Parse(Console.ReadLine());
          return new Triangle(a, b, c);

        default:
          throw new Exception("Geçersiz şekil!");
      }
    }
  }

}
