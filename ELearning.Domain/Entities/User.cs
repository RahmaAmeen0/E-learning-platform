namespace ELearning.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class User : IdentityUser<int>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    public NotificationPreference NotificationPreference { get; set; }
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<LiveSession> LiveSessions { get; set; } = new List<LiveSession>();
    public ICollection<Media> Medias { get; set; } = new List<Media>();
    public ICollection<LiveAnnouncement> LiveAnnouncements { get; set; } = new List<LiveAnnouncement>();
    public ICollection<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();
}