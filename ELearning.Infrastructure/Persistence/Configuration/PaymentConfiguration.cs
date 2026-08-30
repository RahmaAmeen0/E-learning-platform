using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(p => p.Amount).HasPrecision(18, 2);
            builder.Property(p => p.Currency).HasConversion<string>().HasMaxLength(10);
            builder.Property(p => p.Status).HasConversion<string>().HasMaxLength(20);
            builder.Property(p => p.Provider).HasMaxLength(50).IsRequired();
            builder.Property(p => p.ProviderTransactionId).HasMaxLength(150);

            builder.HasOne(p => p.User)
                   .WithMany(u => u.Payments)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Course)
                   .WithMany(c => c.Payments)
                   .HasForeignKey(p => p.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Enrollment)
                   .WithMany()
                   .HasForeignKey(p => p.EnrollmentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
