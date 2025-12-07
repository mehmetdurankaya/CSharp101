namespace Ucgenciz
{
  class InputHandler
    {
        public int GetTriangleHeight()
        {
            Console.Write("Üçgenin yüksekliğini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int height) || height <= 0)
            {
                Console.WriteLine("Geçerli bir pozitif sayı girin.");
                return GetTriangleHeight(); // Hatalı girişte tekrar sor
            }
            return height;
        }
    }
}


