using Microsoft.EntityFrameworkCore;
using SkillShare.Models;

namespace SkillShare.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // "Seeding" = starter rows that go into the table
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Music" },
                new Category { Id = 3, Name = "Languages" },
                new Category { Id = 4, Name = "Cooking" },
                new Category { Id = 5, Name = "Art & Design" },
                new Category { Id = 6, Name = "Other" });
        }
    }
}
