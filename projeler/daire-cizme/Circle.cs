namespace DaireCiz
{
  class Circle
  {
    public void DrawCircle(int radius)
    {
      double aspect = 2.2;       // En iyi sonuç  
      double thickness = 0.5;    // Kenar kalınlığı

      for (double y = -radius; y <= radius; y++)
      {
        for (double x = -radius * aspect; x <= radius * aspect; x++)
        {
          double dx = x / aspect;
          double distance = Math.Sqrt(dx * dx + y * y);

          if (Math.Abs(distance - radius) < thickness)
            Console.Write("•");
          else
            Console.Write(" ");
        }
        Console.WriteLine();
      }
    }
  }
}
