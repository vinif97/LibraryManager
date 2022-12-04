using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class BookLendingConfiguration : IEntityTypeConfiguration<BookLending>
    {
        public void Configure(EntityTypeBuilder<BookLending> builder)
        {
            builder.HasKey(bookLending => bookLending.BookLendingId);
            builder.Property(bookLending => bookLending.CreationDate)
                   .HasColumnType("date")
                   .IsRequired()
                   .HasDefaultValue(DateTime.Now);
            builder.Property(bookLending => bookLending.DueDate)
                   .HasColumnType("date")
                   .IsRequired();
            builder.Property(bookLending => bookLending.ReturnDate)
                   .HasColumnType("date");
            builder.HasOne(bookLending => bookLending.BookItem)
                   .WithOne(bookItem => bookItem.BookLending)
                   .IsRequired()
                   .HasForeignKey<BookLending>(bookLending => bookLending.BookItemId);
            builder.HasOne(bookLending => bookLending.Member)
                   .WithMany(member => member.CheckedOutBooks)
                   .IsRequired();
        }
    }
}
