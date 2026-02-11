using Microsoft.Identity.Client.Extensions.Msal;
using System.Runtime.Intrinsics.Arm;

namespace LibraryApp.Entities
{
    public class Book
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; }
        public int Copies { get; private set; }
        public int CopiesAvailable { get; private set; }

        public string Category { get; private set; } 
        public string Img { get; private set; }

        public Book() { }


        internal Book(string title, string author, string description, int copies, int copiesAvailable, string category, string img)
        {
            Title = title;
            Author = author;
            Description = description;
            Copies = copies;
            CopiesAvailable = copiesAvailable;
            Category = category;
            Img = img;
        }
    }

    public class BookBuilder
    {
        private string _title = "";
        private string _author = "";
        private string _description = "";
        private int _copies = 0;
        private int _copiesAvailable = 0;
        private string _category = "";
        private string _img = "";

        public BookBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }

        public BookBuilder WithAuthor(string author)
        {
            _author = author;
            return this;
        }

        public BookBuilder WithDescription(string description) {
            _description = description; return this; }

        public BookBuilder WithCopies(int copies)
        {
            _copies = copies;
            return this;
        }

        public BookBuilder WithCopiesAvailable(int copiesAvailable)
        {
            _copiesAvailable = copiesAvailable;
            return this;
        }

        public BookBuilder WithCategory(string category)
        {
            _category = category;
            return this;
        }

        public BookBuilder WithImg(string img) { _img = img; return this; }

        public Book Build()
        {
            return new Book(
              _title,
              _author,
              _description,
              _copies,
              _copiesAvailable,
              _category,
              _img
          );
        }
    }
}
