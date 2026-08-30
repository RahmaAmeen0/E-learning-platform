namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;
public class QuizAttempt
{
    public int Id { get; set; }
    public int Score { get; set; }
    public QuizAttemptStatus Status { get; set; } = QuizAttemptStatus.InProgress;
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime? SubmittedAt { get; set; }

    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }
    public ICollection<AttemptAnswer> AttemptAnswers { get; set; } = new List<AttemptAnswer>();

    public int UserId { get; set; }
    public User User { get; set; }
}