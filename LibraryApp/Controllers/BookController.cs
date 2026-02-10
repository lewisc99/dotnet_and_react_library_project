using LibraryApp.Database;
using LibraryApp.Entities;
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
            Book book = new Book
            {
            };

            bookContext.Add(book);

            dynamic obj = new { name = "lewis" };
            return obj;
        }
    }
}
