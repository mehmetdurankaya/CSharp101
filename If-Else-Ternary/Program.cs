using System;
namespace if_else_if_statement_example
{
  class Program
  {
    static void Main(string[] args)
    {
      // Set the current time
      int time = DateTime.Now.Hour;
      if (time < 10) // If time is less than 10 AM, print "Good morning."
      {
        Console.WriteLine("Good morning.");
      }
      else if (time < 18)// If time is less than 6 PM, print "Good day."
      {
        Console.WriteLine("Good day.");// If time is greater than or equal to 6 PM, print "Good evening."
      }
      else
      {
        Console.WriteLine("Good evening.");// In other cases, print "Hello."

      }
      // Using Ternary Operator
      string result = time <=18 ? "Good day." : "Good evening.";
      result = time >=6 && time <11 ? "Good morning." : time<=18 ? "Good day." : "Good evening.";
      Console.WriteLine(result);
    }
  }
}
