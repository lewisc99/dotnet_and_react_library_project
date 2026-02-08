using LibraryApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryApp.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                   .ValueGeneratedOnAdd();

            builder.Property(b => b.Title)
                   .HasMaxLength(200);

            builder.Property(b => b.Author)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(b => b.Description)
                   .HasMaxLength(1000);

            builder.Property(b => b.Img);

            builder.Property(b => b.Copies)
                   .IsRequired();

            builder.Property(b => b.CopiesAvailable)
                   .IsRequired();

            builder.Property(b => b.Category)
                   .IsRequired();
        }
    }
}
