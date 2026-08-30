using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(q => q.Text).HasMaxLength(1000).IsRequired();
            builder.Property(q => q.QuestionType).HasConversion<string>().HasMaxLength(30);

            builder.HasOne(q => q.Quiz)
                   .WithMany(qz => qz.Questions)
                   .HasForeignKey(q => q.QuizId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
