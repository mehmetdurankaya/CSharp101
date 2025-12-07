namespace Proje1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      PhoneBook book = new PhoneBook();

        AddOperation add = new AddOperation(book);
        DeleteOperation delete = new DeleteOperation(book);
        UpdateOperation update = new UpdateOperation(book);
        ListOperation list = new ListOperation(book);
        SearchOperation search = new SearchOperation(book);

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            Console.Write("Seçim: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": add.AddPerson(); break;
                case "2": delete.DeletePerson(); break;
                case "3": update.UpdatePerson(); break;
                case "4": list.ListPeople(); break;
                case "5": search.Search(); break;
                default: Console.WriteLine("Geçersiz seçim.\n"); break;
            }
        }
    }
  }
}
