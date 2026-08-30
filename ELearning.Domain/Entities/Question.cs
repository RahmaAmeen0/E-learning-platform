namespace ELearning.Domain.Entities;
using ELearning.Domain.Enums;
public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Points { get; set; }
    public QuestionType QuestionType { get; set; } = QuestionType.MultipleChoice;

    public int QuizId { get; set; }
    public Quiz Quiz { get; set; }

    public ICollection<AnswerOption> AnswerOptions { get; set; } = new List<AnswerOption>();
    public ICollection<AttemptAnswer> AttemptAnswers { get; set; } = new List<AttemptAnswer>();

}