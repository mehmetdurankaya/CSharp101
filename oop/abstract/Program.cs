namespace abstract_example
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("********ABSTRACT EXAMPLE**********");
      Focus focus = new Focus();
      Console.WriteLine(focus.HangiMakinaninAraci().ToString());
      Console.WriteLine(focus.KactekerlektenOlusur().ToString());
      Console.WriteLine(focus.StandartRengiNe().ToString());
      Console.WriteLine("******************");
      Civic civic = new Civic();
      Console.WriteLine(civic.HangiMakinaninAraci().ToString());
      Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
      Console.WriteLine(civic.StandartRengiNe().ToString());
    }
  }
}
