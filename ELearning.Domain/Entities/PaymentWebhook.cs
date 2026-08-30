namespace ELearning.Domain.Entities;

public class PaymentWebhook
{
    public int Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ProviderEventId { get; set; } = string.Empty;
    public string EventType { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
    public DateTime ProcessedAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }

    public int PaymentId { get; set; }
    public Payment Payment { get; set; }
}