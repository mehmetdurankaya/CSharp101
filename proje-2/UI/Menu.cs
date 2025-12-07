using System;
using System.Collections.Generic;
using Proje2.Core;


namespace Proje2.UI
{
  public class Menu
  {
    private readonly Dictionary<string, ICommand> _commands;
    public Menu(Dictionary<string, ICommand> commands)
    {
      _commands = commands;
    }


    public void Run()
    {
      while (true)
      {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Taşımak");
        Console.WriteLine("(0) Çıkış");


        var choice = Console.ReadLine();
        if (choice == "0") break;


        if (_commands.TryGetValue(choice ?? string.Empty, out var cmd))
        {
          cmd.Execute();
        }
        else
        {
          Console.WriteLine("Geçersiz seçim!");
        }
      }
    }
  }
}
