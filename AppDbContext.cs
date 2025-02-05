using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "Canada", Capital = "Ottawa", Region = "North America", Population = 38000000, Area = 9984670, Currency = "CAD", Language = "English, French", TimeZone = "UTC-5 to UTC-8", Continent = "North America" }
  );
    }
}