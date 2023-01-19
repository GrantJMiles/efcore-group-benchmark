using Microsoft.EntityFrameworkCore;

namespace src;

public class ExampleContext : DbContext
{

    public DbSet<Service> Services { get; set; }
    public DbSet<MessageProvider> MessageProviders { get; set; }
    public DbSet<MyLogs> Logs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=db;Database=ExampleDb;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}