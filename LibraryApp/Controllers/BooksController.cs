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

        [HttpGet("Search/FindByCategory")]
        public IActionResult FindByCategory([FromQuery] string category, [FromQuery] int page, [FromQuery] int size)
        {
            try
            {
                var pageFilter = new PaginationFilter<Book>();
                pageFilter.Page = page == 0 ? 1 : page;
                pageFilter.Size = size;

                var filterBy = new FilterBy
                {
                    PropertyName = "Category",
                    FilterValue = category
                };

                if (string.IsNullOrEmpty(category))
                {
                    return Ok(new PaginationModel<Book>
                    {
                        Data = [],
                        TotalSize = 0
                    });
                }

                pageFilter.FilterBy = [filterBy];

                var result = bookRepository.GetPaginatedData(pageFilter);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
