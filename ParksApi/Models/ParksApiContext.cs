using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Grand Canyon National Park", City = "Grand Canyon Village", State = "Arizona", NationalPark = true },
          new Park { ParkId = 2, Name = "Cherry Creek State Park", City = "Aurora", State = "Colorado", StatePark = true },
          new Park { ParkId = 3, Name = "Chatfield State Park", City = "Littleton", State = "Colorado", StatePark = true },
          new Park { ParkId = 4, Name = "Yosemite National Park", City = "Yosemite National Park", State = "California", NationalPark = true },
          new Park { ParkId = 5, Name = "Glacier National Park", City = "West Glacier", State = "Montana", NationalPark = true }
        );
    }
  }
}