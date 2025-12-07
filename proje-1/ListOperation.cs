using System;
using System.Linq;
namespace Proje1
{


  public class ListOperation
  {
    private PhoneBook _book;

    public ListOperation(PhoneBook book)
    {
      _book = book;
    }

    public void ListPeople()
    {
      Console.WriteLine("(1) A-Z");
      Console.WriteLine("(2) Z-A");
      Console.Write("Seçim: ");
      string choice = Console.ReadLine();

      var list = _book.People;

      if (choice == "1")
        list = list.OrderBy(p => p.Name).ToList();
      else if (choice == "2")
        list = list.OrderByDescending(p => p.Name).ToList();

      Console.WriteLine("\nTelefon Rehberi");
      Console.WriteLine("**********************************************");

      foreach (var p in list)
      {
        Console.WriteLine($"İsim: {p.Name}  Soyisim: {p.Surname}  Telefon: {p.Phone}");
      }

      Console.WriteLine();
    }
  }
}
