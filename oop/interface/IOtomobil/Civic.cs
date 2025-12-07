namespace inteface_example
{
  public class Civic : IOtomobil
  {
    public Marka HangiMarkaninAraci()
    {
      return Marka.Honda;
    }

    public int KactekerlektenOlusur()
    {
      return 4;
    }

    public Renk StandartRengiNe()
    {
      return Renk.Gri;
    }
  }
}
