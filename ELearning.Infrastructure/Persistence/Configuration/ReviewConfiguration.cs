using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(r => r.Comment).HasMaxLength(2000);
            builder.Property(r => r.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasIndex(r => new { r.UserId, r.CourseId }).IsUnique();

            builder.HasOne(r => r.Course)
                   .WithMany(c => c.Reviews)
                   .HasForeignKey(r => r.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reviews)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
