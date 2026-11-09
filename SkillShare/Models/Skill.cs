using System.ComponentModel.DataAnnotations;

namespace SkillShare.Models
{
    public class Skill
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a category")]        
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? OwnerId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}