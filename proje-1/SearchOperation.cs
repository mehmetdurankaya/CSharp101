using System;
using System.Linq;
namespace Proje1
{
    public class SearchOperation
    {
        private PhoneBook _book;

        public SearchOperation(PhoneBook book)
        {
            _book = book;
        }

        public void Search()
        {
            Console.WriteLine("Arama türünü seçiniz:");
            Console.WriteLine("(1) İsim/soyisim ile arama");
            Console.WriteLine("(2) Telefon numarası ile arama");
            Console.Write("Seçim: ");
            string choice = Console.ReadLine();

            Console.Write("Arama değeri: ");
            string input = Console.ReadLine().ToLower();

            var results = choice switch
            {
                "1" => _book.People.Where(p =>
                       p.Name.ToLower() == input || p.Surname.ToLower() == input),
                "2" => _book.People.Where(p => p.Phone == input),
                _ => Enumerable.Empty<Person>()
            };

            Console.WriteLine("\nArama Sonuçlarınız:");
            Console.WriteLine("**********************************************");

            foreach (var p in results)
            {
                Console.WriteLine($"İsim: {p.Name}  Soyisim: {p.Surname}  Telefon: {p.Phone}");
            }

            Console.WriteLine();
        }
    }
}
