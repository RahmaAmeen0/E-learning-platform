namespace ELearning.Domain.Entities;

public class LiveAnnouncement
{
    public int Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int LiveSessionId { get; set; }
    public LiveSession LiveSession { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}