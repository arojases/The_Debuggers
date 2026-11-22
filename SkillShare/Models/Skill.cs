namespace SkillShare.Models;

public class Skill
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public string? OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<LearningRequest> LearningRequests { get; set; } =
        new List<LearningRequest>();
}
