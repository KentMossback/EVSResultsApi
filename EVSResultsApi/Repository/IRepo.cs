using System.Collections.Generic;
using System.Threading.Tasks;
using EVSResultsApi.Models;

namespace EVSResultsApi.Repository
{
    public interface IRepo
    {
        Team CreateTeam(Team teamToCreate);
        Team GetTeamById(int id);
        List<Team> GetTeams();
        void DeleteTeam(int id);
    }
}
