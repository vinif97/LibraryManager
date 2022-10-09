using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(address => address.AddressId);
            builder.Property(address => address.StreetAddress)
                   .IsRequired()
                   .HasMaxLength(256);
            builder.Property(address => address.City)
                   .IsRequired()
                   .HasMaxLength(32);
            builder.Property(address => address.State)
                   .IsRequired()
                   .HasMaxLength(32);
            builder.Property(address => address.Number)
                   .IsRequired()
                   .HasColumnType("smallint")
                   .HasPrecision(4);
            builder.Property(address => address.Complement)
                   .HasMaxLength(128);
            builder.Property(address => address.Reference)
                   .HasMaxLength(256);
        }
    }
}
