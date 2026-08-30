namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;

public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public Currency Currency { get; set; } = Currency.EGP;
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public string Provider { get; set; } = string.Empty;
    public string? ProviderTransactionId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; }
    public PaymentWebhook PaymentWebhook { get; set; }

}