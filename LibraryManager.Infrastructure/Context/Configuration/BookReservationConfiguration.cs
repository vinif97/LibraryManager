using LibraryManager.Domain.Enums;
using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class BookReservationConfiguration : IEntityTypeConfiguration<BookReservation>
    {
        public void Configure(EntityTypeBuilder<BookReservation> builder)
        {
            builder.HasKey(bookReservation => bookReservation.BookReservationId);
            builder.Property(bookReservation => bookReservation.BookReservationStatus)
                   .HasColumnType("tinyint")
                   .IsRequired()
                   .HasDefaultValue(BookReservationStatus.Pending);
            builder.Property(bookReservation => bookReservation.CreationDate)
                   .HasColumnType("date")
                   .IsRequired()
                   .HasDefaultValue(DateTime.Now);
            builder.Property(bookReservation => bookReservation.EndDate)
                   .HasColumnType("date")
                   .IsRequired();
            builder.HasOne(bookReservation => bookReservation.BookItem)
                   .WithMany(bookItem => bookItem.BookReservation)
                   .IsRequired();
        }
    }
}
