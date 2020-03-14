using System.Collections.Generic;
using EVSResultsApi.Models;
using EVSResultsApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EVSResultsApi.Controllers
{
    [Route("[controller]")]

    public class HomeController : Controller
    {
        private static readonly IList<CommentModel> _comments;
        //private readonly IRepo _repo;

        static HomeController( )
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Kent Mossbäck",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            _repo.GetTeams()


            return Json(_comments);
        }


    }
}