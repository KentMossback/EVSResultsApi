using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVSResultsApi.Models;
using EVSResultsApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EVSResultsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IRepo _repo;


        public TeamController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Team>> Get()
        {
            return Ok(_repo.GetTeams());
        }

        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            var result = _repo.GetTeamById(id);
            
            if(result != null)
                return Ok(result);

            return NoContent();

        }

        // POST: api/Team
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            var team = new Team()
            {
                Country = "Sverige"
            };
            return Ok(_repo.CreateTeam(team));
        }

        // PUT: api/Team/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
         
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
}
