using System.Numerics;

namespace ELearning.Domain.Entities;
public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int PassingScore { get; set; }
    public int TimeLimitInMinutes { get; set; }
    public int MaxAttempts { get; set; }
    public bool IsPublished { get; set; }

    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<QuizAttempt> QuizAttempts { get; set; }
    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }
}