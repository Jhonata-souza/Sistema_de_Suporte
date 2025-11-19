using Microsoft.EntityFrameworkCore;
using SistemaSuporte.Api.Models;

namespace SistemaSuporte.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Comment> Comments => Set<Comment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(eb =>
        {
            eb.HasIndex(u => u.Email).IsUnique();
            eb.Property(u => u.Email).IsRequired();
            eb.Property(u => u.Name).IsRequired(false);
        });

        modelBuilder.Entity<Ticket>(eb =>
        {
            eb.Property(t => t.Title).IsRequired();
            eb.HasOne(t => t.User).WithMany(u => u.Tickets).HasForeignKey(t => t.UserId);
        });

        modelBuilder.Entity<Comment>(eb =>
        {
            eb.Property(c => c.Text).IsRequired();
            eb.HasOne(c => c.Ticket).WithMany(t => t.Comments).HasForeignKey(c => c.TicketId);
            eb.HasOne(c => c.Author).WithMany().HasForeignKey(c => c.AuthorId).OnDelete(DeleteBehavior.Restrict);
        });
    }
}

