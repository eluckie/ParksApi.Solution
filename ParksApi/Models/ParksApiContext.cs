using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public DbSet<User> Users { get; set; }

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
          new Park { ParkId = 5, Name = "Glacier National Park", City = "West Glacier", State = "Montana", NationalPark = true },
          new Park { ParkId = 6, Name = "Barr Lake State Park", City = "Commerce City", State = "Colorado", StatePark = true },
          new Park { ParkId = 7, Name = "Cheyenne Mountain State Park", City = "Colorado Springs", State = "Colorado", StatePark = true },
          new Park { ParkId = 8, Name = "Crawford State Park", City = "Crawford", State = "Colorado", StatePark = true },
          new Park { ParkId = 9, Name = "Eleven Mile State Park", City = "Lake George", State = "Colorado", StatePark = true },
          new Park { ParkId = 10, Name = "Jackson Lake State Park", City = "Orchard", State = "Colorado", StatePark = true },
          new Park { ParkId = 11, Name = "John Martin Reservoir State Park", City = "Hasty", State = "Colorado", StatePark = true },
          new Park { ParkId = 12, Name = "Lake Pueblo State Park", City = "Pueblo", State = "Colorado", StatePark = true },
          new Park { ParkId = 13, Name = "Mancos State Park", City = "Mancos", State = "Colorado", StatePark = true },
          new Park { ParkId = 14, Name = "Ridgway State Park", City = "Ridgway", State = "Colorado", StatePark = true },
          new Park { ParkId = 15, Name = "St. Vrain State Park", City = "Firestone", State = "Colorado", StatePark = true },
          new Park { ParkId = 16, Name = "Staunton State Park", City = "Pine", State = "Colorado", StatePark = true },
          new Park { ParkId = 17, Name = "Steamboat Lake State Park", City = "Clark", State = "Colorado", StatePark = true },
          new Park { ParkId = 18, Name = "Trinidad Lake State Park", City = "Trinidad", State = "Colorado", StatePark = true },
          new Park { ParkId = 19, Name = "Denali National Park", City = "Denali Park", State = "Alaska", NationalPark = true },
          new Park { ParkId = 20, Name = "Gates of the Arctic National Park", City = "Fairbanks", State = "Alaska", NationalPark = true },
          new Park { ParkId = 21, Name = "Glacier Bay National Park Preserve", City = "Gustavus", State = "Alaska", NationalPark = true },
          new Park { ParkId = 22, Name = "Katmai National Park", City = "King Salmon", State = "Alaska", NationalPark = true },
          new Park { ParkId = 23, Name = "Kenai Fjords National Park", City = "Seward", State = "Alaska", NationalPark = true },
          new Park { ParkId = 24, Name = "Kobuk Valley National Park", City = "Kotzebue", State = "Alaska", NationalPark = true },
          new Park { ParkId = 25, Name = "Lake Clark National Park and Preserve", City = "Anchorage", State = "Alaska", NationalPark = true },
          new Park { ParkId = 26, Name = "Wrangell-St. Elias National Park and Preserve", City = "Copper Center", State = "Alaska", NationalPark = true },
          new Park { ParkId = 27, Name = "Petrified Forest National Park", City = "Petrified Forest", State = "Arizona", NationalPark = true },
          new Park { ParkId = 28, Name = "Saguaro National Park", City = "Tucson", State = "Arizona", NationalPark = true },
          new Park { ParkId = 29, Name = "Hot Springs National Park", City = "Hot Springs", State = "Arkansas", NationalPark = true },
          new Park { ParkId = 30, Name = "Channel Islands National Park", City = "Ventura", State = "California", NationalPark = true },
          new Park { ParkId = 31, Name = "Death Valley National Park", City = "Furnace Creek", State = "California", NationalPark = true },
          new Park { ParkId = 32, Name = "Joshua Tree National Park", City = "Joshua Tree", State = "California", NationalPark = true },
          new Park { ParkId = 33, Name = "Kings Canyon National Park", City = "Three Rivers", State = "California", NationalPark = true },
          new Park { ParkId = 34, Name = "Lassen Volcanic National Park", City = "Mineral", State = "California", NationalPark = true },
          new Park { ParkId = 35, Name = "Pinnacles National Park", City = "Paicines", State = "California", NationalPark = true },
          new Park { ParkId = 36, Name = "Del Norte Coast Redwoods State Park", City = "Crescent City", State = "California", StatePark = true },
          new Park { ParkId = 37, Name = "Sequoia National Park", City = "Three Rivers", State = "California", NationalPark = true },
          new Park { ParkId = 38, Name = "Black Canyon of the Gunnison National Park", City = "Montrose", State = "Colorado", NationalPark = true },
          new Park { ParkId = 39, Name = "Great Sand Dunes National Park", City = "Mosca", State = "Colorado", NationalPark = true },
          new Park { ParkId = 40, Name = "Mesa Verde National Park", City = "Mesa Verde National Park", State = "Colorado", NationalPark = true },
          new Park { ParkId = 41, Name = "Biscayne National Park", City = "Homestead", State = "Florida", NationalPark = true },
          new Park { ParkId = 42, Name = "Dry Tortugas National Park", City = "Homestead", State = "Florida", NationalPark = true },
          new Park { ParkId = 43, Name = "Everglades National Park", City = "Homestead", State = "Florida", NationalPark = true },
          new Park { ParkId = 44, Name = "Haleakala National Park", City = "Makawao", State = "Hawaii", NationalPark = true },
          new Park { ParkId = 45, Name = "Hawaii Volcanoes National Park", City = "Hawaii National Park", State = "Hawaii", NationalPark = true },
          new Park { ParkId = 46, Name = "Yellowstone National Park", City = "Yellowstone National Park", State = "Wyoming", NationalPark = true },
          new Park { ParkId = 47, Name = "Indiana Dunes National Park", City = "Porter", State = "Indiana", NationalPark = true },
          new Park { ParkId = 48, Name = "Acadia National Park", City = "Bar Harbor", State = "Maine", NationalPark = true },
          new Park { ParkId = 49, Name = "Isle Royale National Park", City = "Houghton", State = "Michigan", NationalPark = true },
          new Park { ParkId = 50, Name = "Voyageurs National Park", City = "International Falls", State = "Minnesota", NationalPark = true },
          new Park { ParkId = 51, Name = "Gateway Arch National Park", City = "St. Louis", State = "Missouri", NationalPark = true },
          new Park { ParkId = 52, Name = "Cuyahoga Valley National Park", City = "Peninsula", State = "Ohio", NationalPark = true },
          new Park { ParkId = 53, Name = "Great Basin National Park", City = "Baker", State = "Nevada", NationalPark = true },
          new Park { ParkId = 54, Name = "Carlsbad Caverns National Park", City = "Carlsbad", State = "New Mexico", NationalPark = true },
          new Park { ParkId = 55, Name = "White Sands National Park", City = "Alamogordo", State = "New Mexico", NationalPark = true },
          new Park { ParkId = 56, Name = "Theodore Roosevelt National Park", City = "Medora", State = "North Dakota", NationalPark = true },
          new Park { ParkId = 57, Name = "Great Smoky Mountains", City = "Gatlinburg", State = "Tenneessee", NationalPark = true },
          new Park { ParkId = 58, Name = "Crater Lake National Park", City = "Crater Lake", State = "Oregon", NationalPark = true },
          new Park { ParkId = 59, Name = "Congaree National Park", City = "Hopkins", State = "South Carolina", NationalPark = true },
          new Park { ParkId = 60, Name = "Badlands National Park", City = "Interior", State = "South Dakota", NationalPark = true },
          new Park { ParkId = 61, Name = "Wind Cave National Park", City = "Hot Springs", State = "South Dakota", NationalPark = true },
          new Park { ParkId = 62, Name = "Arches National Park", City = "", State = "Utah", NationalPark = true },
          new Park { ParkId = 63, Name = "Redwood National Park", City = "Crescent City", State = "California", NationalPark = true }
        );
    }
  }
}