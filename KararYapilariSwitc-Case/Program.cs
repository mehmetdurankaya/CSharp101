using System;
namespace Switch_Case_Statement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please select a numerical month between 1 and 12");
      int month = Convert.ToInt32(Console.ReadLine());
      
      switch (month)
      {
        case 1:
          Console.WriteLine("January");
          break;
        case 2:
          Console.WriteLine("February");
          break;
        case 3:
          Console.WriteLine("March");
          break;
        case 4:
          Console.WriteLine("April");
          break;
        case 5:
          Console.WriteLine("June");
          break;
        case 6:
          Console.WriteLine("July");
          break;
        case 7:
          Console.WriteLine("August");
          break;
        case 8:
          Console.WriteLine("September");
          break;
        case 9:
          Console.WriteLine("October"); 
          break;
        case 10:
          Console.WriteLine("November");
          break;
        case 11:
          Console.WriteLine("December");
          break;
          case 12:
          Console.WriteLine("December");  
          break;
        default:
          Console.WriteLine("Yanlış Seçim Yaptınız!");
          break;
      }
      // Print the season of the month
      switch (month)
      {
        case 12:
        case 1:
        case 2:
          Console.WriteLine("Winter");
          break;
        case 3:
        case 4:
        case 5:
          Console.WriteLine("Spring");
          break;
        case 6:
        case 7:
        case 8:
          Console.WriteLine("Summer");
          break;
        case 9:
        case 10:
        case 11:
          Console.WriteLine("Autumn");
          break;       
      }
    }
  }
}
