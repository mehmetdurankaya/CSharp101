namespace abstract_example
{
  public class Focus : Otomobil
  {
    public override Marka HangiMakinaninAraci()
    {
      return Marka.Ford;
    }

    public int KactekerlektenOlusur()
    {
      return 4;
    }

    public Renk StandartRengiNe()
    {
      return Renk.Beyaz;
    }
  }
}
