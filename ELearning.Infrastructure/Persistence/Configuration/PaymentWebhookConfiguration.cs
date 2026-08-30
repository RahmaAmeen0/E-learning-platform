using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class PaymentWebhookConfiguration : IEntityTypeConfiguration<PaymentWebhook>
    {
        public void Configure(EntityTypeBuilder<PaymentWebhook> builder)
        {
            builder.Property(pw => pw.Status).HasMaxLength(50).IsRequired();
            builder.Property(pw => pw.ProviderEventId).HasMaxLength(150).IsRequired();
            builder.Property(pw => pw.EventType).HasMaxLength(100).IsRequired();
            builder.Property(pw => pw.Payload).HasColumnType("nvarchar(max)");

            builder.HasOne(pw => pw.Payment)
                   .WithOne(p => p.PaymentWebhook)
                   .HasForeignKey<PaymentWebhook>(pw => pw.PaymentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
