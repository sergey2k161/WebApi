using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ApplicatianDbContext(DbContextOptions<ApplicatianDbContext> options) : DbContext(options)
{
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>()
            .HasKey(n => n.Id);

        modelBuilder.Entity<Note>()
            .Property(n => n.Text)
            .HasMaxLength(300);

    }
}
