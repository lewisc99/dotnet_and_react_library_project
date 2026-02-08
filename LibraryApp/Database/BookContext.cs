using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Database
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public BookContext(DbContextOptions<BookContext> options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
