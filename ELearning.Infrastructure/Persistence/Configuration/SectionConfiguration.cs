using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(150).IsRequired();

            builder.HasOne(s => s.Course)
                   .WithMany(c => c.Sections)
                   .HasForeignKey(s => s.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
