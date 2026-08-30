namespace ELearning.Domain.Entities;

public class LessonProgress
{
    public int Id { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime LastAccessedAt { get; set; } = DateTime.UtcNow;

    public int EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; }

    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }


}