using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class LessonProgressConfiguration : IEntityTypeConfiguration<LessonProgress>
    {
        public void Configure(EntityTypeBuilder<LessonProgress> builder)
        {
            builder.HasIndex(lp => new { lp.EnrollmentId, lp.LessonId }).IsUnique();

            builder.HasOne(lp => lp.Enrollment)
                   .WithMany(e => e.LessonProgresses)
                   .HasForeignKey(lp => lp.EnrollmentId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(lp => lp.Lesson)
                   .WithMany()
                   .HasForeignKey(lp => lp.LessonId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
