using ELearning.Domain.Entities;
using ELearning.Domain.Enums;
public class Certificate
{
    public int Id { get; set; }
    public string CertificateNumber { get; set; } = string.Empty;
    public DateTime IssuedAt { get; set; } = DateTime.UtcNow;
    public string VerificationCode { get; set; } = string.Empty;
    public CertificateStatus Status { get; set; } = CertificateStatus.Issued;

    public int EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; } = null!;
}