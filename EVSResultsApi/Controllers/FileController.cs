using System.Threading.Tasks;
using EVSResultsApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EVSResultsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IRepo _repo;


        public FileController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("EVS file upload get method");
        }

        //[HttpPost]
        //public ActionResult UploadFile()
        //{


        //    return Ok();
        //}

        //[HttpPost]
        //public async Task<IActionResult> OnPostUploadAsync()
        //{
        //    // Don't rely on or trust the FileName property without validation.

        //    //return Ok();
        //    return Ok("EVS file upload POST method " );
        //}


        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> OnPostUploadAsync([FromForm] string xmlFile)
        {
            //    // Process uploaded files
            //    // Don't rely on or trust the FileName property without validation.
            
            _repo.SaveMatchResult(xmlFile);
            return Ok();
            //    return Ok("EVS file upload get method " + new { count = files.Count, size});
        }
    }

    //[HttpPost]
    //    [Consumes("application/x-www-form-urlencoded")]
    //    public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
    //    {
    //        long size = files.Sum(f => f.Length);

    //        foreach (var formFile in files)
    //        {
    //            if (formFile.Length > 0)
    //            {
    //                var filePath = Path.GetTempFileName();

    //                using (var stream = System.IO.File.Create(filePath))
    //                {
    //                    await formFile.CopyToAsync(stream);
    //                }
    //            }
    //        }

    //        //    // Process uploaded files
    //        //    // Don't rely on or trust the FileName property without validation.

    //        return Ok();
    //        //    return Ok("EVS file upload get method " + new { count = files.Count, size});
    //        }
    //    }
}