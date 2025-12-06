namespace hazir_metotlar_string
{
  class Program
  {
    static void Main(string[] args)
    {
      string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
      string degisken2 = "Dersimiz CSharp";

      //Length:
      Console.WriteLine("****Length*****");
      Console.WriteLine(degisken.Length); // 30

      //ToUpper ve ToLower:
      Console.WriteLine("******ToUpper ve ToLower******");
      Console.WriteLine(degisken.ToUpper()); // DERSIMIZ CSHARP

      //Concat
      Console.WriteLine("******Concat******");
      Console.WriteLine(string.Concat(degisken, " Merhaba!")); // Dersimiz CSharp

      //Compare, CompareTo:
      Console.WriteLine("******Compare ve CompareTo******");
      Console.WriteLine(degisken.CompareTo(degisken2)); /* karakter sayısına göre karşılaştırır ve sonucu 0 (eşitse 0 döner) 1 (büyükse 1 döner) -1 (küçükse -1 döner)*/
      Console.WriteLine(string.Compare(degisken, degisken2, true));// true ise büyük küçük harf farkını görmez.
      Console.WriteLine(string.Compare(degisken, degisken2, false));// false ise büyük küçük harf farkını görür.

      //Contains:
      Console.WriteLine("******Contains, EndsWith ve Start With******");
      Console.WriteLine(degisken.Contains(degisken2));// degiskenin içinde degisken2 var mı? true veya false döner.
      Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));// degiskenin sonunda belirtilen string var mı? true veya false döner
      Console.WriteLine(degisken.StartsWith("Merhaba")); //degiskenin başında belirtilen string var mı? true veya false döner

      //IndexOf:
      Console.WriteLine("******IndexOf ve LastIndexOf******");
      Console.WriteLine(degisken.IndexOf("CS"));// degisken içinde belirtilen stringin ilk karakterinin index numarasını verir.
      Console.WriteLine(degisken.IndexOf("Mehmet Duran Kaya"));// degisken içinde belirtilen stringin ilk karakterinin index numarasını verir.
      Console.WriteLine(degisken.LastIndexOf("i")); // degisken içinde belirtilen stringin son karakterinin index numarasını verir.

      //Insert
      Console.WriteLine("******Insert******");
      Console.WriteLine(degisken.Insert(10, "Merhaba! "));// degiskenin belirli bir indexinden itibaren belirtilen stringi ekler. yeni string döner.
      //PadLeft , PadRight
      Console.WriteLine("******PadLeft ve PadRight******");
      Console.WriteLine(degisken + degisken2.PadLeft(30)); // degiskenin soluna belirli bir karakterle dolu alan ekler.
      Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));// degis kenin sağına belirli bir karakterle dolu alan ekler.
      Console.WriteLine(degisken.PadRight(50) + degisken2);// degiskenin sağına belirli bir karakterle dolu alan ekler.
      Console.WriteLine(degisken.PadRight(50, '-') + degisken2);// degikenin soluna belirli bir karakterle dolu alan ekler.
      //Remove
      Console.WriteLine("******Remove******");
      Console.WriteLine(degisken.Remove(10)); //degiskenin belirli bir indexinden itibaren belirli bir uzunlukta olan stringi siler ve yeni string döner.
      Console.WriteLine(degisken.Remove(5, 3)); //degiskenin belirli bir indexinden itibaren sonuna kadar olan stringi siler ve yeni string döner.
      Console.WriteLine(degisken.Remove(0, 1));

      //Replace
      Console.WriteLine("******Replace******");
      Console.WriteLine(degisken.Replace("CSharp", "C#")); //degisken içinde belirtilen stringin tüm örneklerini başka bir string ile değiştirir. yeni string döner.
      Console.WriteLine(degisken.Replace("", "*"));

      //Split
      Console.WriteLine("******Split******");

      Console.WriteLine(degisken.Split(' ')[0]); // belirli bir karaktere göre stringi parçalar ve array olarak döner.
      //Substring
      Console.WriteLine("******Substring******");
      Console.WriteLine(degisken.Substring(5)); //belirli bir indexinden itibaren sonuna kadar olan stringi alır ve yeni string döner.
      Console.WriteLine(degisken.Substring(4, 6));// belirli bir indexden başlayarak belirli uzunlukta olan stringi alır ve yeni string döner. 

    }
  }
}
