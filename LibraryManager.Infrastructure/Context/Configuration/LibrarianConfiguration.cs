using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class LibrarianConfiguration : IEntityTypeConfiguration<Librarian>
    {
        public void Configure(EntityTypeBuilder<Librarian> builder)
        {
            builder.HasKey(librarian => librarian.LibrarianId);
            builder.HasOne(librarian => librarian.User)
                   .WithOne(user => user.Librarian)
                   .IsRequired()
                   .HasForeignKey<Librarian>(librarian => librarian.UserId);
        }
    }
}
