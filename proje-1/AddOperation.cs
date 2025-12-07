using System;
namespace Proje1
{
  public class AddOperation
{
    private PhoneBook _book;

    public AddOperation(PhoneBook book)
    {
        _book = book;
    }

    public void AddPerson()
    {
        Console.Write("Lütfen isim giriniz            : ");
        string name = Console.ReadLine();

        Console.Write("Lütfen soyisim giriniz         : ");
        string surname = Console.ReadLine();

        Console.Write("Lütfen telefon numarası giriniz : ");
        string phone = Console.ReadLine();

        _book.People.Add(new Person(name, surname, phone));

        Console.WriteLine("Kişi başarıyla eklendi.\n");
    }
}
}
