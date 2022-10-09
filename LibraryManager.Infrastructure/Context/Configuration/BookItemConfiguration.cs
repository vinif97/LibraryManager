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
            builder.Property(bookItem => bookItem.PricePerDay)
                   .IsRequired()
                   .HasColumnType("decimal")
                   .HasPrecision(10, 2);
            builder.Property(bookItem => bookItem.Languague)
                   .IsRequired()
                   .HasColumnType("tinyint");
        }
    }
}
