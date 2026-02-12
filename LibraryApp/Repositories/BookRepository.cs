using LibraryApp.Configurations.Pagination;
using LibraryApp.Database;
using LibraryApp.Entities;

namespace LibraryApp.Repositories
{
    public class BookRepository : Repository<Book>
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context) : base(context)
        {
            _context = context;
        }
    }
}
