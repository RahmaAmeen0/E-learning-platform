namespace ELearning.Infrastructure.Persistence.Configurations;

using ELearning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LessonProgressConfiguration : IEntityTypeConfiguration<LessonProgress>
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