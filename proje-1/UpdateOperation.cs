using System;
using System.Linq;
namespace Proje1
{
  

public class UpdateOperation
{
    private PhoneBook _book;

    public UpdateOperation(PhoneBook book)
    {
        _book = book;
    }

    public void UpdatePerson()
    {
        while (true)
        {
            Console.Write("Güncellemek istediğiniz kişinin adını veya soyadını giriniz: ");
            string input = Console.ReadLine().ToLower();

            var person = _book.People
                .FirstOrDefault(p => p.Name.ToLower() == input || p.Surname.ToLower() == input);

            if (person == null)
            {
                Console.WriteLine("\nAradığınız kriterlere uygun kişi bulunamadı.");
                Console.WriteLine("(1) Güncellemeyi sonlandır");
                Console.WriteLine("(2) Yeniden dene");

                string choice = Console.ReadLine();
                if (choice == "1") return;
                continue;
            }

            Console.Write("Yeni isim: ");
            person.Name = Console.ReadLine();

            Console.Write("Yeni soyisim: ");
            person.Surname = Console.ReadLine();

            Console.Write("Yeni telefon numarası: ");
            person.Phone = Console.ReadLine();

            Console.WriteLine("Kişi güncellendi.\n");
            return;
        }
    }
}
}
