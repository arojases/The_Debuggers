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
    public DbSet<Skill> Skills => Set<Skill>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skills", "public");
            entity.HasKey(skill => skill.Id);

            entity.Property(skill => skill.Title)
                .IsRequired();

            entity.Property(skill => skill.Description)
                .IsRequired();

            entity.Property(skill => skill.CategoryId)
                .HasDefaultValue(0);

            entity.Property(skill => skill.CreatedAt)
                .IsRequired();
        });

        modelBuilder.Entity<LearningRequest>(entity =>
        {
            entity.ToTable("LearningRequests", "public");

            entity.HasKey(request => request.Id);

            entity.Property(request => request.LearnerId)
                .IsRequired();

            entity.Property(request => request.Status)
                .HasDefaultValue("Pending");

            entity.Property(request => request.CreatedAt)
                .HasDefaultValueSql("now()");

            entity.HasOne(request => request.Skill)
                .WithMany(skill => skill.LearningRequests)
                .HasForeignKey(request => request.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}