using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class BookItemConfiguration : IEntityTypeConfiguration<BookItem>
    {
        public void Configure(EntityTypeBuilder<BookItem> builder)
        {
            builder.HasKey(bookItem => bookItem.BookItemId);
            builder.Property(bookItem => bookItem.IsReferenceOnly)
                   .IsRequired();
            builder.Property(bookItem => bookItem.IsVirtual)
                   .IsRequired();
            builder.Property(bookItem => bookItem.Barcode)
                   .HasColumnType("varchar")
                   .HasMaxLength(128);
            builder.Property(bookItem => bookItem.PricePerDay)
                   .IsRequired()
                   .HasColumnType("decimal")
                   .HasPrecision(10, 2);
            builder.Property(bookItem => bookItem.Languague)
                   .IsRequired()
                   .HasColumnType("tinyint");
            builder.HasMany(bookItem => bookItem.BookReservation)
                   .WithOne(bookReservation => bookReservation.BookItem);
            builder.HasOne(bookItem => bookItem.BookLending)
                   .WithOne(bookLending => bookLending.BookItem)
                   .HasForeignKey<BookLending>(book => book.BookItemId);
            builder.HasOne(bookItem => bookItem.Library)
                   .WithMany(library => library.BookItems)
                   .IsRequired();
            builder.HasOne(bookItem => bookItem.Book)
                   .WithMany(book => book.BookItems)
                   .IsRequired();
        }
    }
}
