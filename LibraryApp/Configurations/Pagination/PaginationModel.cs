namespace LibraryApp.Configurations.Pagination
{
    public class PaginationModel<T>
    {
        public List<T> Data { get; set; }
        public int TotalSize { get; set; }

        public int TotalPages { get; set; }
    }
}
