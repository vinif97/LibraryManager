using LibraryManager.Domain.Enums;
using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder.Property(user => user.AccountStatus)
                   .IsRequired()
                   .HasDefaultValue(AccountStatus.Active);
            builder.HasOne(user => user.Member)
                   .WithOne(member => member.User)
                   .HasForeignKey<Member>(member => member.UserId);
            builder.HasOne(user => user.Librarian)
                   .WithOne(librarian => librarian.User)
                   .HasForeignKey<Librarian>(librarian => librarian.UserId);
            builder.HasOne(user => user.Address)
                   .WithOne(address => address.User)
                   .HasForeignKey<Address>(address => address.UserId)
                   .IsRequired();
        }
    }
}
