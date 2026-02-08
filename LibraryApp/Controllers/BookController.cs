using LibraryApp.Database;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookController(BookContext bookContext) : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetAll()
        {
            //return Ok();
            dynamic obj = new { name = "lewis" };
            return obj;
        }
    }
}
