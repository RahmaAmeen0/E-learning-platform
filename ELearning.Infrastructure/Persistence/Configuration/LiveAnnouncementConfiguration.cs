using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class LiveAnnouncementConfiguration : IEntityTypeConfiguration<LiveAnnouncement>
    {
        public void Configure(EntityTypeBuilder<LiveAnnouncement> builder)
        {
            builder.Property(la => la.Message).HasMaxLength(1000).IsRequired();

            builder.HasOne(la => la.LiveSession)
                   .WithMany(ls => ls.LiveAnnouncement)
                   .HasForeignKey(la => la.LiveSessionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(la => la.User)
                   .WithMany(u => u.LiveAnnouncements)
                   .HasForeignKey(la => la.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
