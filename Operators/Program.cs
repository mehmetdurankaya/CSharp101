
using System;
namespace Operatorlar
{
  class Program
  {
    static void Main(string[] args)
    {
      // Atama ve işlemli atama
      Console.WriteLine("********* Atama ve İşlemli Atama Operatörleri *********");
      int x = 3;
        Console.WriteLine($" x : {x}");
      int y = 3;
      Console.WriteLine($" y : {y}");
      y = y + 2;
     Console.WriteLine($" y = y + 2 : {y}");
      y += 2;
      Console.WriteLine($"  y +=2 : {y}");
      y /= 1;
      Console.WriteLine($" y = y / 1 or y/=1 : {y} ");

      x *= 2;
      Console.WriteLine($"x = x*2 or x *= 2 : {x} ");


      // Mantıksal Operatörler
      // ||, &&, !
      Console.WriteLine("********* Mantıksal Operatörler *********");
      bool isSuccess = true;
      bool isCompleted = false;

      if (isSuccess && isCompleted)
        Console.WriteLine(" isSuccess && isCompleted : Perfect! ");

      if (isSuccess || isCompleted)
        Console.WriteLine(" isSuccess || isCompleted : Great! ");

      if (isSuccess && !isCompleted)
        Console.WriteLine(" isSuccess && !isCompleted : Fine! ");

      // İlişkisel Operatörler
      // <, >, <=, >=, ==, !=
      Console.WriteLine("********* İlişkisel Operatörler *********");
      int a = 3;
      int b = 4;
      bool sonuc = a < b;
      Console.WriteLine($" a = {a}, b = {b} ");
      Console.WriteLine($" a < b : {sonuc} ");
      sonuc = a > b;
      Console.WriteLine($" a > b : {sonuc} ");
      sonuc = a >= b;
      Console.WriteLine($" a >= b : {sonuc} ");
      sonuc = a <= b;
      Console.WriteLine($" a <= b : {sonuc} ");
      sonuc = a == b;
      Console.WriteLine($" a == b : {sonuc} ");
      sonuc = a != b;
      Console.WriteLine($" a != b : {sonuc} ");
      Console.WriteLine("********* Aritmetik Operatörler *********");
      // /, *, +, -
      int sayi1 = 10;
      int sayi2 = 5;
      Console.WriteLine($" a = {a}, b = {b} ");
      int sonuc1 = sayi1 / sayi2;
      Console.WriteLine($" sayi1 / sayi2 : {sonuc1} ");
      sonuc1 = sayi1 * sayi2;
      Console.WriteLine($" sayi1 * sayi2 : {sonuc1} ");
      sonuc1 = sayi1 + sayi2;
      Console.WriteLine($" sayi1 + sayi2 : {sonuc1} ");
      sonuc1 = sayi1 - sayi2;
      Console.WriteLine($" sayi1 - sayi2 : {sonuc1} ");
      Console.WriteLine("********* Atama Operatörleri *********");
      // =, +=, -=, *=, /=
      int sayi3 = 20;
       Console.WriteLine($" sayi3 = {sayi3} ");
      sayi3 += 10;
      Console.WriteLine($" sayi3 +=10 : {sayi3} ");
      sayi3 -= 5;
      Console.WriteLine($" sayi3 -=5 : {sayi3} ");
      sayi3 *= 2;
      Console.WriteLine($" sayi3 *=2 : {sayi3} ");
      sayi3 /= 4;
      Console.WriteLine($" sayi3 /=4 : {sayi3} ");
   
     // % Mod alma
      Console.WriteLine("********* Mod Alma Operatörü *********");
      int sayi8 = 20;
      int sayi9 = 3;
      int sonuc5 = sayi8 % sayi9;
      Console.WriteLine($" sayi8: {sayi8} sayi9 : {sayi9} ");
      Console.WriteLine($" % Mod Alma: Sayi8 % Sayi9 : {sonuc5} ");
      
    }
  }

  
}
