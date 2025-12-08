namespace alan_hesapla
{
  public class Circle : IShape
  {
    public double Radius { get; }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;

    public double CalculatePerimeter() => 2 * Math.PI * Radius;

    public double CalculateVolume() => 0; // Dairede hacim yok
  }

}
