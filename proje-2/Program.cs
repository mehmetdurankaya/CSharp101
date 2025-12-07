using System;
using System.Collections.Generic;
using Proje2.Core;
using Proje2.Repositories;
using Proje2.Services;
using Proje2.Commands;
using Proje2.UI;


namespace Proje2
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // DI-like simple wiring (manual)
      var repo = new InMemoryRepository();
      var teamService = new TeamService(repo);
      var boardService = new BoardService(repo, teamService);


      // Register commands
      var commands = new Dictionary<string, ICommand>
{
    { "1", new ListBoardCommand(boardService) },
    { "2", new AddCardCommand(boardService, teamService) },
    { "3", new DeleteCardCommand(boardService) },
    { "4", new MoveCardCommand(boardService) }
};


      var menu = new Menu(commands);
      menu.Run();
    }
  }
}
