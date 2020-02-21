using System.Collections.Generic;
using System.Linq;
using EVSResultsApi.DataAccess;
using EVSResultsApi.Models;

namespace EVSResultsApi.Repository
{
    public class Repo : IRepo
    {
        private readonly ISQLiteDBContext _sqLiteDbContext;

        public Repo(ISQLiteDBContext sqLiteDbContext)
        {
            _sqLiteDbContext = sqLiteDbContext;
        }
        
        public Team CreateTeam(Team teamToCreate)
        {
            var createdTeam = new Team();
             
                 _sqLiteDbContext.Teams.Add(teamToCreate);
                _sqLiteDbContext.SaveChanges();

                createdTeam = _sqLiteDbContext.Teams
                    .OrderBy(b => b.Id)
                    .First();

                return createdTeam;
        }

        public Team GetTeamById(int id)
        {
            return  _sqLiteDbContext.Teams.FirstOrDefault(x => x.Id == id);
        }
        
        public List<Team> GetTeams()
        {
            return _sqLiteDbContext.Teams.ToList();
        }

        public void DeleteTeam(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
