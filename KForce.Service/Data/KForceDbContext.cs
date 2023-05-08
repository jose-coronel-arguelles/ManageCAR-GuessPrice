using KForce.Service.Model;
using Microsoft.EntityFrameworkCore;

namespace KForce.Service.Data;

public class KForceDbContext : DbContext
{
    public KForceDbContext(DbContextOptions<KForceDbContext> options) : base(options) 
        => Database.EnsureCreated();

    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasKey(c => c.Id);
        modelBuilder.Entity<Car>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Car>()
            .Property(c => c.Price)
            .HasColumnType("decimal(18,4)");

        // Seed database with authors and books for demo
        new DbInitializer(modelBuilder).Seed();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var result = optionsBuilder.UseSqlServer("server = PE-IT001610\\SQLEXPRESS; database = KForce; Trusted_Connection = true;TrustServerCertificate=True;");
    }
}