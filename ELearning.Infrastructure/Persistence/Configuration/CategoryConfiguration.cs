using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500);

            builder.HasMany(c => c.courses)
                   .WithOne(c => c.Category)
                   .HasForeignKey(c => c.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
