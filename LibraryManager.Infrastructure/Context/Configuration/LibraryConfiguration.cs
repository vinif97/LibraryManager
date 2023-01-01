using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class LibraryConfiguration : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(library => library.LibraryId);
            builder.HasOne(library => library.Address)
                   .WithOne(address => address.Library)
                   .HasForeignKey<Address>(address => address.LibraryId)
                   .IsRequired();
        }
    }
}
