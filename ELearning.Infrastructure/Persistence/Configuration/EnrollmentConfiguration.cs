using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.Property(e => e.Status).HasConversion<string>().HasMaxLength(20);
            builder.HasIndex(e => new { e.UserId, e.CourseId }).IsUnique();

            builder.HasOne(e => e.User)
                   .WithMany(u => u.Enrollments)
                   .HasForeignKey(e => e.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Course)
                   .WithMany(c => c.Enrollments)
                   .HasForeignKey(e => e.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
