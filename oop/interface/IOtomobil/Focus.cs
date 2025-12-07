namespace inteface_example
{
  public class Focus : IOtomobil
  {
    public Marka HangiMarkaninAraci()
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
