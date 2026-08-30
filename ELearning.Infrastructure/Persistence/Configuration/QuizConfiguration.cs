using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.Property(q => q.Title).HasMaxLength(200).IsRequired();

            builder.HasOne(q => q.Lesson)
                   .WithOne(l => l.Quiz)
                   .HasForeignKey<Quiz>(q => q.LessonId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
