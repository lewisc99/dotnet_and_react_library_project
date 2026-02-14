using LibraryApp.Configurations.Pagination;
using LibraryApp.Entities;

namespace LibraryApp.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        PaginationModel<Book> FindByCategory(string category);
    }
}
