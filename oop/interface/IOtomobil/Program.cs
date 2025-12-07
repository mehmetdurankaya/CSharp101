namespace inteface_example
{
  class Program
  {
    public static void Main(string[] args)
    {
      Focus focus = new Focus();
      Console.WriteLine(focus.HangiMarkaninAraci().ToString());
      Console.WriteLine(focus.KactekerlektenOlusur().ToString());
      Console.WriteLine(focus.StandartRengiNe().ToString());
      Console.WriteLine("******************");
      Civic civic = new Civic();
      Console.WriteLine(civic.HangiMarkaninAraci().ToString());
      Console.WriteLine(civic.KactekerlektenOlusur().ToString());
      Console.WriteLine(civic.StandartRengiNe().ToString());
    }
  }
}
