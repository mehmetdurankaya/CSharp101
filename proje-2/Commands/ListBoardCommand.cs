using System;
using Proje2.Core;
using Proje2.Services;


namespace Proje2.Commands
{
public class ListBoardCommand : ICommand
{
private readonly IBoardService _boardService;
public ListBoardCommand(IBoardService boardService) => _boardService = boardService;


public void Execute()
{
var board = _boardService.GetBoard();


void Print(System.Collections.Generic.List<Proje2.Entities.Card> cards)
{
if (cards.Count == 0) { Console.WriteLine("~ BOŞ ~"); return; }
foreach (var c in cards)
{
Console.WriteLine($"Başlık : {c.Title}");
Console.WriteLine($"İçerik : {c.Content}");
Console.WriteLine($"Atanan Kişi : {c.Assigned?.Name}");
Console.WriteLine($"Büyüklük : {c.Size}");
Console.WriteLine("-");
}
}


Console.WriteLine("\nTODO Line\n************************");
Print(board.Todo);
Console.WriteLine("\nIN PROGRESS Line\n************************");
Print(board.InProgress);
Console.WriteLine("\nDONE Line\n************************");
Print(board.Done);
}
}
}
