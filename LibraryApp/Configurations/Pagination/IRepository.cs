namespace LibraryApp.Configurations.Pagination
{
    public interface IRepository<T>
    {
        PaginationModel<T> GetPaginatedData(PaginationFilter<T> filter);
    }
}
