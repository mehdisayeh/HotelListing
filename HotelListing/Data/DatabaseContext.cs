using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        //Seend data to db
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Morocco",
                    ShortName = "MA"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FR"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States",
                    ShortName = "USA"
                }
            );


            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Twin Keep Hotel & Spa",
                    Adress = "8867 Newcastle Street Deerfield Beach, Nice",
                    CountryId = 2,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Regal Mill Resort & Sp",
                    Adress = "924 Carson St. Odenton, MD 21113",
                    CountryId = 3,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Mellow Forest Hotel & Spa",
                    Adress = "82 Main St. Brownsburg, IN 46112",
                    CountryId = 3,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Pacific Courtyard Hotel & Spa",
                    Adress = "7270 Pennsylvania Street Fort Wayne, IN 46804",
                    CountryId = 3,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Brass Cosmos Hotel",
                    Adress = "7583 Railroad Avenue Suite 8 Roselle, Pa",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Sunny Emperor Resort & Spa",
                    Adress = "9 Andover Ave. Warminster, PA 18974",
                    CountryId = 3,
                    Rating = 3.9
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Ornate Resort & Spa",
                    Adress = "Hay Riad Street 123, Rabat",
                    CountryId = 1,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Epitome Hotel",
                    Adress = "444 North Lookout St. Fort Worth, TX 76110",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 9,
                    Name = "Opportunity Hotel",
                    Adress = "4 Second Ave. Clifton Park, NY 12065",
                    CountryId = 3,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Nature Hotel & Spa",
                    Adress = "7614 James Street Largo, FL 33771",
                    CountryId = 3,
                    Rating = 4.5
                }
            );
        }
    }
}
