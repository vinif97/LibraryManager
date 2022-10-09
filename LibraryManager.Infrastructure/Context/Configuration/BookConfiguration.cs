using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(book => book.BookId);
            builder.Property(book => book.BookId)
                   .ValueGeneratedOnAdd();
            builder.Property(book => book.Title)
                   .IsRequired();
            builder.HasIndex(book => book.Title)
                   .IsUnique();
            builder.Property(book => book.PublishedYear)
                   .IsRequired();
            builder.Property(book => book.Publisher)
                   .IsRequired();
            builder.Property(book => book.Authors)
                   .IsRequired();
            builder.Property(book => book.Category)
                   .IsRequired();
        }
    }
}
