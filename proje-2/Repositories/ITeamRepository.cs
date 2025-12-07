using System.Collections.Generic;
using Proje2.Entities;


namespace Proje2.Repositories
{
public interface ITeamRepository
{
List<TeamMember> GetTeamMembers();
}
}
