using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(CreateCity());
        }

        public List<City> CreateCity()
        {
            List<City> ciies = new List<City>()
            {
                new City()
                {
                    CitiId = 1,
                    Name = "Sofia"
                },

                new City()
                {
                 CitiId = 2,
                 Name = "Plovdiv"
                },

                new City()
                {
                 CitiId = 3,
                 Name = "London"
                },

                new City()
                {
                 CitiId = 4,
                 Name = "Paris"
                },

            };
            return ciies;
        }
    }
}



