namespace alan_hesapla
{
  class alan_hesapla
  {
    public static void Main(string[] args)
    {
      Console.Write("Şekil seçin (Daire, Kare, Dikdörtgen, Üçgen): ");
      string shapeType = Console.ReadLine();

      IShape shape = ShapeFactory.CreateShape(shapeType);

      Console.Write("Hesaplama türü (Alan, Çevre, Hacim): ");
      string operation = Console.ReadLine().ToLower();

      double result = operation switch
      {
        "alan" => shape.CalculateArea(),
        "çevre" => shape.CalculatePerimeter(),
        "cevre" => shape.CalculatePerimeter(),
        "hacim" => shape.CalculateVolume(),
        _ => throw new Exception("Geçersiz işlem!")
      };

      Console.WriteLine($"\nSonuç: {result}");
    }
  }
}
