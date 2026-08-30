namespace ELearning.Domain.Entities;

public class Section
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }

    public ICollection<Lesson> Lessons { get; set;} = new List<Lesson>();
    public int CourseId { get; set; }
    public Course Course { get; set; }
}