using Proje2.Entities;
using System.Collections.Generic;


namespace Proje2.Repositories
{
public interface IBoardRepository
{
Board GetBoard();
void SaveBoard(Board board);
}
}
