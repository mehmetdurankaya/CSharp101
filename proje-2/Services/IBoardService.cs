using Proje2.Entities;
using System.Collections.Generic;


namespace Proje2.Services
{
public interface IBoardService
{
Board GetBoard();
void AddCard(Card card); // adds to TODO
List<(System.Collections.Generic.List<Card> line, Card card)> FindByTitle(string title);
bool DeleteByTitle(string title, out int deletedCount);
bool MoveCard(Card card, int targetLine);
}
}
