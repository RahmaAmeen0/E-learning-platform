using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.Property(m => m.FileName).HasMaxLength(255).IsRequired();
            builder.Property(m => m.StorageKey).HasMaxLength(500).IsRequired();
            builder.Property(m => m.ContentType).HasMaxLength(100).IsRequired();
            builder.Property(m => m.MediaType).HasMaxLength(50).IsRequired();

            builder.HasOne(m => m.User)
                   .WithMany(u => u.Medias)
                   .HasForeignKey(m => m.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Lesson)
                   .WithOne(l => l.Media)
                   .HasForeignKey<Media>(m => m.LessonId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
