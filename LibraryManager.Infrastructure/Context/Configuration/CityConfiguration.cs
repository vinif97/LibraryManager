﻿using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManager.Infrastructure.Context.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(city => city.CityId);
            builder.Property(city => city.CityName)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(128);
            builder.HasOne(city => city.State)
                   .WithMany(state => state.Cities)
                   .IsRequired();
        }
    }
}
