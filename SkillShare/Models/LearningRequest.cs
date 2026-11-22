namespace SkillShare.Models;

public class LearningRequest
{
    public Guid Id { get; set; }
    public Guid SkillId { get; set; }
    public string LearnerId { get; set; } = string.Empty;
    public string? Message { get; set; }
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; }
    public DateTime? RespondedAt { get; set; }

    public Skill? Skill { get; set; }
}