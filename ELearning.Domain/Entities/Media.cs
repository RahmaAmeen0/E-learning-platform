namespace ELearning.Domain.Entities;

public class Media
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string StorageKey { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public string MediaType { get; set; } = string.Empty;
    public long SizeInBytes { get; set; }
    public DateTime? DeletedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    public User User { get; set; }
    public int? LessonId { get; set; }
    public Lesson Lesson { get; set; }
}