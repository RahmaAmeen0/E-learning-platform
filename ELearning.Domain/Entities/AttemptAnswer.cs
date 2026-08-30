namespace ELearning.Domain.Entities;

public class AttemptAnswer
{
    public int Id {  get; set; }
    public int pointsEarned { get; set; }
    public bool isCorrect { get; set; }

    public int AnswerOptionId { get; set; }
    public AnswerOption AnswerOption { get; set; }

    public int QuizAttemptId {  get; set; }
    public QuizAttempt QuizAttempt { get; set; }

    public int QuestionId { get; set; }
    public Question Question { get; set; }
}