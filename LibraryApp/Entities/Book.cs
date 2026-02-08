namespace LibraryApp.Entities
{
    public class Book
    {
        public long Id { get; private set; }
        public string Title { get; private set; } = null!;
        public string Author { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public int Copies { get; private set; }
        public int CopiesAvailable { get; private set; }

        public int Category { get; private set; } 
        public string Img { get; private set; } = null!;

        public Book() { }
    }
}
