using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class AnswerOptionConfiguration : IEntityTypeConfiguration<AnswerOption>
    {
        public void Configure(EntityTypeBuilder<AnswerOption> builder)
        {
            builder.Property(a => a.Text).HasMaxLength(500).IsRequired();

            builder.HasOne(a => a.question)
                   .WithMany(q => q.AnswerOptions)
                   .HasForeignKey(a => a.QuestionId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
