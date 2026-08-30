using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class NotificationPreferenceConfiguration : IEntityTypeConfiguration<NotificationPreference>
    {
        public void Configure(EntityTypeBuilder<NotificationPreference> builder)
        {
            builder.Property(np => np.NotificationType).HasMaxLength(50).IsRequired();

            builder.HasOne(np => np.User)
                   .WithOne(u => u.NotificationPreference)
                   .HasForeignKey<NotificationPreference>(np => np.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
