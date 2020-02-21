using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EVSResultsApi.Models;
using EVSResultsApi.Models.CreateModels;
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
        public ActionResult GetById(int id)
        {
            var result = _repo.GetTeamById(id);
            
            if(result != null)
                return Ok(result);

            return NoContent();

        }

        // POST: api/Team
        [HttpPost]
        public IActionResult Post([FromBody] CreateTeamModel team)
        {
            var result = _repo.CreateTeam(team);

            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
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
