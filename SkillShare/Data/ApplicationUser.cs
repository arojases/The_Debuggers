using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SkillShare.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;
    }
}
