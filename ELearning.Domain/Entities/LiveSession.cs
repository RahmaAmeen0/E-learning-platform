namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;
public class LiveSession
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string MeetingUrl { get; set; } = string.Empty;
    public LiveSessionStatus Status { get; set; } = LiveSessionStatus.Scheduled;
    public DateTime ScheduledStartAt { get; set; }
    public DateTime ScheduledEndAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<LiveAnnouncement> LiveAnnouncement { get; set; } = new List<LiveAnnouncement>();   

    public int CourseId { get; set; }
    public Course Course { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}