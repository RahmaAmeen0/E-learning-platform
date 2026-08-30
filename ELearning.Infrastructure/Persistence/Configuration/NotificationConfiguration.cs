using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(n => n.Title).HasMaxLength(150).IsRequired();
            builder.Property(n => n.Type).HasMaxLength(50).IsRequired();
            builder.Property(n => n.Message).HasMaxLength(1000).IsRequired();

            builder.HasOne(n => n.User)
                   .WithMany(u => u.Notifications)
                   .HasForeignKey(n => n.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
