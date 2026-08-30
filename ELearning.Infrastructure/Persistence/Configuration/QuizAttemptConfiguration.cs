using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class QuizAttemptConfiguration : IEntityTypeConfiguration<QuizAttempt>
    {
        public void Configure(EntityTypeBuilder<QuizAttempt> builder)
        {
            builder.Property(qa => qa.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasOne(qa => qa.Quiz)
                   .WithMany(q => q.QuizAttempts)
                   .HasForeignKey(qa => qa.QuizId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(qa => qa.User)
                   .WithMany(u => u.QuizAttempts)
                   .HasForeignKey(qa => qa.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
