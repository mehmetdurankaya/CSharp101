using System.Collections.Generic;
using Proje2.Entities;



namespace Proje2.Services
{
public interface ITeamService
{
List<TeamMember> GetAll();
TeamMember? GetById(int id);
}
}
