using System;
using Proje2.Core;
using Proje2.Services;


namespace Proje2.Commands
{
  public class DeleteCardCommand : ICommand
  {
    private readonly IBoardService _boardService;
    public DeleteCardCommand(IBoardService boardService) => _boardService = boardService;


    public void Execute()
    {
      Console.Write("Lütfen silmek istediğiniz kartın başlığını yazınız: ");
      var title = Console.ReadLine() ?? string.Empty;
      if (!_boardService.DeleteByTitle(title, out int deletedCount))
      {
        Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");
        var sec = Console.ReadLine();
        if (sec == "2") Execute();
        return;
      }
      Console.WriteLine($"{deletedCount} kart silindi.");
    }
  }
}
