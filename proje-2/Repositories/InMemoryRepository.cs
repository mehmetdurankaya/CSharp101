using System.Collections.Generic;
using Proje2.Entities;
using Proje2.Enums;


namespace Proje2.Repositories
{
public class InMemoryRepository : IBoardRepository, ITeamRepository
{
private Board _board;
private List<TeamMember> _team;


public InMemoryRepository()
{
// Varsayılan takım üyeleri
_team = new List<TeamMember>
{
new TeamMember { Id = 1, Name = "Ahmet" },
new TeamMember { Id = 2, Name = "Mehmet" },
new TeamMember { Id = 3, Name = "Ayşe" },
new TeamMember { Id = 4, Name = "Fatma" }
};


// Varsayılan board ve kartlar
_board = new Board();
_board.Todo.Add(new Card { Title = "Alışveriş", Content = "Market alışverişi", Assigned = _team[0], Size = SizeType.M });
_board.InProgress.Add(new Card { Title = "Rapor", Content = "Aylık rapor", Assigned = _team[1], Size = SizeType.L });
_board.Done.Add(new Card { Title = "Temizlik", Content = "Ofis temizliği", Assigned = _team[2], Size = SizeType.S });
}


public Board GetBoard() => _board;


public void SaveBoard(Board board) => _board = board;


public List<TeamMember> GetTeamMembers() => _team;
}
}
