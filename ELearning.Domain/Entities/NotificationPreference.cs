namespace ELearning.Domain.Entities;

public class NotificationPreference
{
    public int Id { get; set; }
    public string NotificationType { get; set; } = string.Empty;
    public bool InAppEnabled { get; set; } = true;
    public bool EmailEnabled { get; set; } = true;

    public int UserId { get; set; }
    public User User { get; set; }
}