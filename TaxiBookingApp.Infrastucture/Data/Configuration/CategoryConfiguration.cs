using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaxiBookingApp.Infrastucture.Data.Models;

namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
                    Name = "InerCitySingle"
                },

                new Category()
                {
                 CategoryId = 2,
                 Name = "InerCityShared"
                },

                new Category()
                {
                 CategoryId = 3,
                 Name = "OneWayLocal"
                },

                new Category()
                {
                 CategoryId = 4,
                 Name = "RoundTripLocal"
                },

            };
            return categories;
        }
    }
}
