namespace inheritance
{
  class Program
  {
    public static void Main(string[] args)
    {
      //                   Canlılar
      //                     |
      //         Bitkiler                Hayvanlar
      //      |           |           |             |
      //   Tohumlu     Tohumsuz   Sürüngenler     Kuşlar

      TohumluBitkiler tohumluBitki = new TohumluBitkiler();
      tohumluBitki.TohumlaCogalma();
      Console.WriteLine("*********************");
      Kuslar marti = new Kuslar();
      marti.Ucmak();

    }
  }
}
