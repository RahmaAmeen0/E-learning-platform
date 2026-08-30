namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;

public class Enrollment
{
    public int Id { get; set; }
    public EnrollmentStatus Status { get; set; } = EnrollmentStatus.Active;
    public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedAt { get; set; }
    public DateTime? CancelledAt { get; set; }

    public Certificate? Certificate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public ICollection<LessonProgress> LessonProgresses { get; set; } = new List<LessonProgress>();
}