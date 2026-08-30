using Microsoft.EntityFrameworkCore;
using ELearning.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELearning.Infrastructure.Persistence.Configuration
{
    internal class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.Property(c => c.CertificateNumber).HasMaxLength(50).IsRequired();
            builder.HasIndex(c => c.CertificateNumber).IsUnique();

            builder.Property(c => c.VerificationCode).HasMaxLength(100).IsRequired();
            builder.HasIndex(c => c.VerificationCode).IsUnique();

            builder.Property(c => c.Status).HasConversion<string>().HasMaxLength(20);

            builder.HasOne(c => c.Enrollment)
                   .WithOne(e => e.Certificate)
                   .HasForeignKey<Certificate>(c => c.EnrollmentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
