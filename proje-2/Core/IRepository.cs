using System.Collections.Generic;
using Proje2.Entities;


namespace Proje2.Core
{
public interface IRepository
{
List<TeamMember> GetTeamMembers();
Board GetBoard();
void SaveBoard(Board board);
}
}
