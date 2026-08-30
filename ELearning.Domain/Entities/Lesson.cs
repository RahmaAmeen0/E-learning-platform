namespace ELearning.Domain.Entities;

public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public int DurationInMinutes { get; set; }
    public int DisplayOrder { get; set; }
    public bool IsReview { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public Quiz? Quiz { get; set; }

    public Media? Media { get; set; }
    public int SectionId { get; set; }
    public Section Section { get; set; }
}
