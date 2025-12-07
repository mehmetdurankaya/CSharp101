using System.Collections.Generic;
using System.Linq;
using Proje2.Entities;
using Proje2.Repositories;


namespace Proje2.Services
{
  public class BoardService : IBoardService
  {
    private readonly IBoardRepository _repo;
    private readonly ITeamService _teamService;


    public BoardService(IBoardRepository repo, ITeamService teamService)
    {
      _repo = repo;
      _teamService = teamService;
    }


    public Board GetBoard() => _repo.GetBoard();


    public void AddCard(Card card)
    {
      var board = _repo.GetBoard();
      board.Todo.Add(card);
      _repo.SaveBoard(board);
    }


    public List<(List<Card> line, Card card)> FindByTitle(string title)
    {
      var board = _repo.GetBoard();
      var result = new List<(List<Card>, Card)>();
      result.AddRange(board.Todo.Where(c => c.Title == title).Select(c => (board.Todo, c)));
      result.AddRange(board.InProgress.Where(c => c.Title == title).Select(c => (board.InProgress, c)));
      result.AddRange(board.Done.Where(c => c.Title == title).Select(c => (board.Done, c)));
      return result;
    }


    public bool DeleteByTitle(string title, out int deletedCount)
    {
      deletedCount = 0;
      var board = _repo.GetBoard();
      var todoMatches = board.Todo.Where(c => c.Title == title).ToList();
      var inMatches = board.InProgress.Where(c => c.Title == title).ToList();
      var doneMatches = board.Done.Where(c => c.Title == title).ToList();


      deletedCount += todoMatches.Count + inMatches.Count + doneMatches.Count;


      foreach (var c in todoMatches) board.Todo.Remove(c);
      foreach (var c in inMatches) board.InProgress.Remove(c);
      foreach (var c in doneMatches) board.Done.Remove(c);


      _repo.SaveBoard(board);
      return deletedCount > 0;
    }


    public bool MoveCard(Card card, int targetLine)
    {
      var board = _repo.GetBoard();
      // remove from any line
      if (board.Todo.Remove(card) || board.InProgress.Remove(card) || board.Done.Remove(card))
      {
        switch (targetLine)
        {
          case 1: board.Todo.Add(card); break;
          case 2: board.InProgress.Add(card); break;
          case 3: board.Done.Add(card); break;
          default: return false;
        }
        _repo.SaveBoard(board);
        return true;
      }
      return false;
    }
  }
}
