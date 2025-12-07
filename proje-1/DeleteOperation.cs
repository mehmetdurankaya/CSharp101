using System;
using System.Linq;
namespace Proje1
{
  

public class DeleteOperation
{
    private PhoneBook _book;

    public DeleteOperation(PhoneBook book)
    {
        _book = book;
    }

    public void DeletePerson()
    {
        while (true)
        {
            Console.Write("Silmek istediğiniz kişinin adını veya soyadını giriniz: ");
            string input = Console.ReadLine().ToLower();

            var person = _book.People
                .FirstOrDefault(p => p.Name.ToLower() == input || p.Surname.ToLower() == input);

            if (person == null)
            {
                Console.WriteLine("\nAradığınız kriterlere uygun kişi bulunamadı. Lütfen seçim yapınız.");
                Console.WriteLine("(1) Silmeyi sonlandır");
                Console.WriteLine("(2) Yeniden dene");
                string choice = Console.ReadLine();

                if (choice == "1") return;
                continue;
            }

            Console.WriteLine($"\n{person.Name} {person.Surname} rehberden silinecek. Onaylıyor musunuz? (y/n)");
            string confirm = Console.ReadLine();

            if (confirm.ToLower() == "y")
            {
                _book.People.Remove(person);
                Console.WriteLine("Kişi silindi.\n");
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi.\n");
            }

            return;
        }
    }
}
}
