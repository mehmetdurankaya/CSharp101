using System;
using Proje2.Core;
using Proje2.Services;


namespace Proje2.Commands
{
  public class MoveCardCommand : ICommand
  {
    private readonly IBoardService _boardService;
    public MoveCardCommand(IBoardService boardService) => _boardService = boardService;


    public void Execute()
    {
      Console.Write("Lütfen taşımak istediğiniz kartın başlığını yazınız: ");
      var title = Console.ReadLine() ?? string.Empty;
      var found = _boardService.FindByTitle(title);
      if (found.Count == 0)
      {
        Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
        Console.WriteLine("* İşlemi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");
        var sec = Console.ReadLine();
        if (sec == "2") Execute();
        return;
      }


      var (line, card) = found[0];
      Console.WriteLine("\nBulunan Kart Bilgileri:\n**************************************");
      Console.WriteLine($"Başlık : {card.Title}");
      Console.WriteLine($"İçerik : {card.Content}");
      Console.WriteLine($"Atanan Kişi : {card.Assigned?.Name}");
      Console.WriteLine($"Büyüklük : {card.Size}");
      Console.WriteLine($"Line : {(line == _boardService.GetBoard().Todo ? "TODO" : line == _boardService.GetBoard().InProgress ? "IN PROGRESS" : "DONE")} ");


      Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz:");
      Console.WriteLine("(1) TODO");
      Console.WriteLine("(2) IN PROGRESS");
      Console.WriteLine("(3) DONE");


      var sel = Console.ReadLine();
      if (sel != "1" && sel != "2" && sel != "3") { Console.WriteLine("Hatalı bir seçim yaptınız!"); return; }


      int target = int.Parse(sel);
      if (_boardService.MoveCard(card, target))
      {
        Console.WriteLine("Kart başarıyla taşındı!");
        // list board
        var listCmd = new ListBoardCommand(_boardService);
        listCmd.Execute();
      }
      else Console.WriteLine("Taşıma işlemi başarısız oldu.");
    }
  }
}
