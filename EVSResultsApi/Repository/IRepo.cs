using System.Collections.Generic;
using System.Threading.Tasks;
using EVSResultsApi.Models;
using EVSResultsApi.Models.CreateModels;

namespace EVSResultsApi.Repository
{
    public interface IRepo
    {
        Team CreateTeam(CreateTeamModel teamToCreate);
        Team GetTeamById(int id);
        List<Team> GetTeams();
        void DeleteTeam(int id);
        void SaveMatchResult(string XmlData);
    }
}
