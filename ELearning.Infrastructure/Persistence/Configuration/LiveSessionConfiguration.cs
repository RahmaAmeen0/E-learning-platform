using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class LiveSessionConfiguration : IEntityTypeConfiguration<LiveSession>
    {
        public void Configure(EntityTypeBuilder<LiveSession> builder)
        {
            builder.Property(l => l.Title).HasMaxLength(200).IsRequired();
            builder.Property(l => l.Description).HasMaxLength(2000);
            builder.Property(l => l.MeetingUrl).HasMaxLength(500).IsRequired();
            builder.Property(l => l.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasOne(l => l.Course)
                   .WithMany(c => c.LiveSessions)
                   .HasForeignKey(l => l.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.User)
                   .WithMany(u => u.LiveSessions)
                   .HasForeignKey(l => l.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
