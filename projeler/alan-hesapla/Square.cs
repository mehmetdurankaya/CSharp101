namespace alan_hesapla
{
  public class Square : IShape
  {
    public double Side { get; }

    public Square(double side)
    {
      Side = side;
    }

    public double CalculateArea() => Side * Side;

    public double CalculatePerimeter() => 4 * Side;

    public double CalculateVolume() => 0; // Karede hacim yok
  }

}
