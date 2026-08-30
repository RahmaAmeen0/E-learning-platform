namespace ELearning.Domain.Entities;

public class AnswerOption
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
    public int DisplayOrder { get; set; }

    public int QuestionId { get; set; }
    public Question question { get; set; }

    public ICollection<AttemptAnswer> AttemptAnswers { get; set; } = new List<AttemptAnswer>();
}