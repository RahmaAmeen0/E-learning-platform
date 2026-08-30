namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public CourseStatus Status { get; set; } = CourseStatus.Draft;
    public string? Level { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }

    public ICollection<LiveSession> LiveSessions { get; set; }

    public ICollection<Review> Reviews { get; set; }

    public ICollection<Payment> Payments { get; set; }
    public ICollection<Section> Sections { get; set; }
}
