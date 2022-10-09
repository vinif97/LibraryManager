using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(author => author.AuthorId);
            builder.Property(author => author.Name)
                   .IsRequired()
                   .HasMaxLength(256);
            builder.HasMany(author => author.Books)
                   .WithOne();
        }
    }
}
