
using KForce.Service.Model;
using Microsoft.EntityFrameworkCore;

namespace KForce.Service.DbEFContext;

public class EFDbContext : DbContext
{
    public DbSet<Car> Cars => Set<Car>();

    public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"server=PE-IT001610\SQLEXPRESS; database = KForce; Trusted_Connection = true;TrustServerCertificate=True;MultipleActiveResultSets=True");
    }
    
}