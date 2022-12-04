using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(publisher => publisher.PublisherId);
            builder.Property(publisher => publisher.PublisherName)
                   .HasColumnType("varchar")
                   .HasMaxLength(128)
                   .IsRequired();
        }
    }
}
