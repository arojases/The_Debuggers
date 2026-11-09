using Microsoft.EntityFrameworkCore;
using SkillShare.Data;
using SkillShare.Models;

namespace SkillShare.Services
{
    public class SkillService(IDbContextFactory<ApplicationDbContext> dbFactory)
    {
        public async Task<List<Skill>> GetAllAsync()
        {
            using var db = await dbFactory.CreateDbContextAsync();
            return await db.Skills.Include(s => s.Category)   // also load the category
                                  .OrderByDescending(s => s.CreatedAt).ToListAsync();
        }

        public async Task<Skill?> GetByIdAsync(Guid id)
        {
            using var db = await dbFactory.CreateDbContextAsync();
            return await db.Skills.Include(s => s.Category).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            using var db = await dbFactory.CreateDbContextAsync();
            return await db.Categories.OrderBy(c => c.Name).ToListAsync();
        }

        public async Task CreateAsync(Skill skill)
        {
            using var db = await dbFactory.CreateDbContextAsync();
            // TODO(auth): skill.OwnerId = currentUserId;
            skill.CreatedAt = DateTime.UtcNow;
            db.Skills.Add(skill);
            await db.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Skill updated)
        {
            using var db = await dbFactory.CreateDbContextAsync();
            var skill = await db.Skills.FindAsync(updated.Id);
            if (skill is null) return false;
            // TODO(auth): if (skill.OwnerId != currentUserId) return false;
            skill.Title = updated.Title;          // copy only the editable fields,
            skill.Description = updated.Description; // so nobody can change OwnerId
            skill.CategoryId = updated.CategoryId;
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using var db = await dbFactory.CreateDbContextAsync();
            var skill = await db.Skills.FindAsync(id);
            if (skill is null) return false;
            // TODO(auth): if (skill.OwnerId != currentUserId) return false;
            db.Skills.Remove(skill);
            await db.SaveChangesAsync();
            return true;
        }
    }
}
