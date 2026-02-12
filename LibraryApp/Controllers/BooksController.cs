using LibraryApp.Configurations.Pagination;
using LibraryApp.Database;
using LibraryApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController(IRepository<Book> bookRepository) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromRoute] PaginationFilter<Book> filter)
        {
            try
            {
                var result = bookRepository.GetPaginatedData(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
