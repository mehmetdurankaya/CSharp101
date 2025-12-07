namespace abstract_example
{
  public class Civic : Otomobil
  {
    public override Marka HangiMakinaninAraci()
    {
      return Marka.Honda;
    }
    public override Renk StandartRengiNe()
    {
      return Renk.Gri;
    }
  }
}
