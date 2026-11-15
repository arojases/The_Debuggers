using Microsoft.EntityFrameworkCore;
using SkillShare.Models;

namespace SkillShare.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<LearningRequest> LearningRequests => Set<LearningRequest>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LearningRequest>(entity =>
        {
            entity.ToTable("LearningRequests");

            entity.HasKey(request => request.Id);

            entity.Property(request => request.Status)
                .HasDefaultValue("Pending");

            entity.Property(request => request.CreatedAt)
                .HasDefaultValueSql("now()");
        });
    }
}