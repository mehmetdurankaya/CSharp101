namespace dateTimeAndMath
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      Console.WriteLine(DateTime.Now);//Günün tarihini getirir      
      Console.WriteLine(DateTime.Now.Date);//
      Console.WriteLine(DateTime.Now.Day);//
      Console.WriteLine(DateTime.Now.Month);
      Console.WriteLine(DateTime.Now.Year);
      Console.WriteLine(DateTime.Now.Hour);
      Console.WriteLine(DateTime.Now.Minute);
      Console.WriteLine(DateTime.Now.Second);

      Console.WriteLine(DateTime.Now.DayOfWeek);
      Console.WriteLine(DateTime.Now.DayOfYear);

      Console.WriteLine(DateTime.Now.ToLongDateString());
      Console.WriteLine(DateTime.Now.ToShortDateString());
      Console.WriteLine(DateTime.Now.ToLongTimeString());
      Console.WriteLine(DateTime.Now.ToShortTimeString());

      Console.WriteLine(DateTime.Now.AddDays(2));
      Console.WriteLine(DateTime.Now.AddHours(3));
      Console.WriteLine(DateTime.Now.AddSeconds(30));
      Console.WriteLine(DateTime.Now.AddMonths(5));
      Console.WriteLine(DateTime.Now.AddYears(10));
      Console.WriteLine(DateTime.Now.AddMilliseconds(50));

      //Datetime Format
      Console.WriteLine(DateTime.Now.ToString("dd"));//24
      Console.WriteLine(DateTime.Now.ToString("ddd"));//Sun
      Console.WriteLine(DateTime.Now.ToString("dddd"));//Sunday

      Console.WriteLine(DateTime.Now.ToString("MM"));//08
      Console.WriteLine(DateTime.Now.ToString("MMM"));//Aug
      Console.WriteLine(DateTime.Now.ToString("MMMM"));//August

      Console.WriteLine(DateTime.Now.ToString("yy"));//25
      Console.WriteLine(DateTime.Now.ToString("yyyy"));//2025

      Console.WriteLine("******** Math Kütüphanesi **********"); // Mutlak Değer
      //Math Kütüphanesi
      Console.WriteLine(Math.Abs(-25)); // Mutlak Değer
      Console.WriteLine(Math.Sin(10));
      Console.WriteLine(Math.Cos(10));
      Console.WriteLine(Math.Tan(10));

      Console.WriteLine(Math.Ceiling(22.3)); // Yukarı Yuvarlama
      Console.WriteLine(Math.Round(22.3));// 22
      Console.WriteLine(Math.Round(22.7));// 23
      Console.WriteLine(Math.Floor(22.7)); // Aşağı Yuvarlama

      Console.WriteLine(Math.Max(2,6)); // Max Değer
      Console.WriteLine(Math.Min(2,6)); // Min Değer

      Console.WriteLine(Math.Pow(3,4)); // 
      Console.WriteLine(Math.Sqrt(9));// Karekök
      Console.WriteLine(Math.Log(9)); // Logaritma 9 un etanına göre logaritması
      Console.WriteLine(Math.Exp(3)); // E tabanı üzeri 3 ü verir
      Console.WriteLine(Math.Log10(10));// 10'un logaritması












    }
  }
}
