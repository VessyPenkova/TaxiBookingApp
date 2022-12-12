using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    public class CountyConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(CreateCity());
        }

        public  List<Country> CreateCity()
        {
            List<Country> ciies = new List<Country>()
            {
                new Country()
                {
                    CountyId = 1,
                    CountryName = "Sofia"
                },

                new Country()
                {
                 CountyId = 2,
                 CountryName = "Plovdiv"
                },

                new Country()
                {
                 CountyId = 3,
                 CountryName = "London"
                },

                new Country()
                {
                 CountyId = 4,
                 CountryName = "Paris"
                },

            };
            return ciies;
        }
    }
}
