using System.Collections.Generic;
using System.Linq;
using Proje2.Entities;
using Proje2.Repositories;


namespace Proje2.Services
{
  public class TeamService : ITeamService
  {
    private readonly ITeamRepository _repo;
    public TeamService(ITeamRepository repo)
    {
      _repo = repo;
    }


    public List<TeamMember> GetAll() => _repo.GetTeamMembers();


    public TeamMember? GetById(int id) => _repo.GetTeamMembers().FirstOrDefault(t => t.Id == id);
  }
}
