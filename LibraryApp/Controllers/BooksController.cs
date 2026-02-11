using LibraryApp.Database;
using LibraryApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BooksController(BookContext bookContext) : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetAll()
        {
            BookBuilder builder = new();

            builder
                .WithTitle("Deep Work")
                .WithDescription("From a New York Times bestselling author, learn to master one of our economy's rarest skills-the ability to focus-and achieve groundbreaking results.")
                .WithCategory("SelfHelp")
                .WithCopies(2)
                .WithCopiesAvailable(1);

            Book book = builder.Build();    

            bookContext.Add(book);

            bookContext.SaveChanges();

            dynamic obj = new { name = "lewis" };
            return obj;
        }
    }
}
