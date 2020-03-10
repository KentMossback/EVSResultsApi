using System.Collections.Generic;
using System.Linq;
using EVSResultsApi.DataAccess;
using EVSResultsApi.Mappers;
using EVSResultsApi.Models;
using EVSResultsApi.Models.CreateModels;

namespace EVSResultsApi.Repository
{
    public class Repo : IRepo
    {
        private readonly ISQLiteDBContext _sqLiteDbContext;
        private readonly IXmlMapper _xmlMapper;

        public Repo(ISQLiteDBContext sqLiteDbContext, IXmlMapper xmlMapper)
        {
            _sqLiteDbContext = sqLiteDbContext;
            _xmlMapper = xmlMapper;
        }
        
        public Team CreateTeam(CreateTeamModel teamToCreate)
        {
            var teamModel = new Team()
            {
                Country = teamToCreate.Country,
                ImageUrl = teamToCreate.ImageUrl,
                Name = teamToCreate.Name
            };
            
            var result = _sqLiteDbContext.Teams.Add(teamModel);
                _sqLiteDbContext.SaveChanges();
            
                return result.Entity;
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

        public void SaveMatchResult(string XmlData)
        {
            var xmlResults = _xmlMapper.MatchXmlConvert(XmlData);
            var re = xmlResults;

        }
    }
}
