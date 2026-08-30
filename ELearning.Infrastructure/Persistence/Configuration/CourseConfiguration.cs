using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(4000);
            builder.Property(c => c.Price).HasPrecision(18, 2);
            builder.Property(c => c.Level).HasMaxLength(50);
            builder.Property(c => c.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasOne(c => c.User)
                   .WithMany(u => u.Courses)
                   .HasForeignKey(c => c.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
