using System;
using Proje2.Core;
using Proje2.Services;
using Proje2.Entities;
using Proje2.Enums;


namespace Proje2.Commands
{
  public class AddCardCommand : ICommand
  {
    private readonly IBoardService _boardService;
    private readonly ITeamService _teamService;


    public AddCardCommand(IBoardService boardService, ITeamService teamService)
    {
      _boardService = boardService;
      _teamService = teamService;
    }


    public void Execute()
    {
      Console.Write("Başlık Giriniz : ");
      var title = Console.ReadLine() ?? string.Empty;
      Console.Write("İçerik Giriniz : ");
      var content = Console.ReadLine() ?? string.Empty;
      Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
      if (!int.TryParse(Console.ReadLine(), out int sizeInput) || sizeInput < 1 || sizeInput > 5)
      {
        Console.WriteLine("Hatalı giriş yaptınız!");
        return;
      }


      Console.WriteLine("Takım Üyeleri:");
      foreach (var m in _teamService.GetAll()) Console.WriteLine($"{m.Id} - {m.Name}");


      Console.Write("Kişi Seçiniz (ID): ");
      if (!int.TryParse(Console.ReadLine(), out int personId)) { Console.WriteLine("Hatalı giriş!"); return; }


      var member = _teamService.GetById(personId);
      if (member == null) { Console.WriteLine("Hatalı girişler yaptınız!"); return; }


      var card = new Card { Title = title, Content = content, Assigned = member, Size = (SizeType)sizeInput };
      _boardService.AddCard(card);
      Console.WriteLine("Kart başarıyla eklendi!");
    }
  }
}
