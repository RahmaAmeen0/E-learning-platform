using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class AttemptAnswerConfiguration : IEntityTypeConfiguration<AttemptAnswer>
    {
        public void Configure(EntityTypeBuilder<AttemptAnswer> builder)
        {
            builder.HasOne(aa => aa.QuizAttempt)
               .WithMany(qa => qa.AttemptAnswers)
               .HasForeignKey(aa => aa.QuizAttemptId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(aa => aa.Question)
                   .WithMany(q => q.AttemptAnswers)
                   .HasForeignKey(aa => aa.QuestionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(aa => aa.AnswerOption)
                   .WithMany(ao => ao.AttemptAnswers)
                   .HasForeignKey(aa => aa.AnswerOptionId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
