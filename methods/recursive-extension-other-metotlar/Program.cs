using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace recursivemetot
{
  class Program
  {
    static void Main(string[] args)
    {
      
     
     Console.WriteLine("Recursive Metot ile sonuç: " + recursiveMetot(4));
      Console.WriteLine("**********");
      Console.WriteLine("Iterative metot ile sonuç: " + iterativeMetot(4));
       Console.WriteLine("**********");
       //Extension Metotlar
       Console.WriteLine("******Extension Metotlar******");

        string ifade = "Mehmet Duran Kaya";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if(sonuc)        
           Console.WriteLine(ifade.RemoveWhiteSpaces());
       Console.WriteLine(ifade.MakeUpperCase());
       Console.WriteLine(ifade.MakeLowerCase());

       int[] dizi = {9,3,6,2,1,5,0};
        Array.Sort(dizi);
        dizi = dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());
        Console.WriteLine(ifade.GetFirstCharacter());
     

    }



    static int recursiveMetot(int n)
    {
      //Recursive - Öz Yinelemeli Kendi kendini çağıran metotlardır.
      //Öğrenilemeyen durumlarda kullanılır.
      //Derinliği bilinemeyen durumlarda kullanılır.
      //Sonu bilinmeyen durumlarda kullanılabilir.
      /*
        F(4) = 4 + F(3)
        F(3) = 3 + F(2)
        F(2) = 2 + F(1)
        F(1) = 1
      */
      if(n == 1)
      {
        return 1;
      }
      int result = recursiveMetot(n-1) + n;
      Console.WriteLine(result);
      Console.WriteLine("**********");
      return result;
    }

    static int iterativeMetot(int n)
    {
      //Döngüsel
      //F(4) = 4 + 3 + 2 + 1
      int sonuc = 0;
      while (n > 0)
      {
        sonuc += n;
        n--;
      }
      return sonuc;
    }
  }
  public static class Extension
  {
    //Bu metotlar static olmalı ve static class içinde olmalı
    //İlk parametre this ile başlar ve bu parametre metotun genişletileceği tipi belirtir.
    
    public static bool CheckSpaces(this string param)
    {
      //Boşluk kontrolü yapar
      Console.WriteLine("Boşluk kontrolü yapılıyor...");
      return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
      //Boşlukları kaldırır
      Console.WriteLine("Boşluklar yerine * işareti koyuluyor...");
      string[] dizi = param.Split(" ");
      return string.Join("*",dizi);
    }
    public static string MakeUpperCase(this string param)
    {
      //Büyük harf yapar
      Console.WriteLine("Tüm harfler büyük harf yapılıyor...");
      return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
      //Küçük harf yapar
      Console.WriteLine("Tüm harfler küçük harf yapılıyor...");
      return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
      //Diziyi sıralar
      Console.WriteLine("dizi = [9,3,6,2,1,5,0]");      
      Console.WriteLine($"Dizi sıralanıyor...  ");
      Array.Sort(param);
      return param;
    } 
    public static void EkranaYazdir(this int[] param)
    {
      //Diziyi ekrana yazdırır
      Console.Write("Dizi ekrana yazdırılıyor...");
      foreach (int item in param)
      {
        Console.WriteLine(item);
        
      }
  }
  public static bool IsEvenNumber(this int param)
  {
    //Çift sayı mı kontrolü yapar
    Console.WriteLine("Sayı çift mi kontrol ediliyor...");
    return param % 2 == 0;
  }
  public static string GetFirstCharacter(this string param)
  {
    //İlk karakteri alır
    Console.WriteLine("İlk karakter alınıyor...");
    return param.Substring(0,1);
  }
}
}
