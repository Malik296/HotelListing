using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Jamaica", ShortName = "JM" },
                new Country { Id = 2, Name = "Bahamas", ShortName = "BS" },
                new Country { Id = 3, Name = "Cayman Island", ShortName = "CI" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Sandal Resourt And Spa", Adress = "Negril", CountryId = 1, Rating = 4.5 },
                new Hotel { Id = 2, Name = "Comfort Suites", Adress = "George Town", CountryId = 3, Rating = 4.0 },
                new Hotel { Id = 3, Name = "Grand Palladium", Adress = "Nassua", CountryId = 2, Rating = 4.5 }
                );
        }
    }
}
