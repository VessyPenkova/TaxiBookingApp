using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasData(CreateCity());
        }

        public List<Office> CreateCity()
        {
            List<Office> offices = new List<Office>()
            {
                new Office()
                {
                OfficeId = "1",
                 City = "Plovdiv",
                 Country = "Bulgaria",
                 Phone = "0035932111111"
                },

                new Office()
                {
                 OfficeId = "2",
                 City = "Plovdiv",
                 Country = "Sofia",
                 Phone = "0035932111111"
                },

                new Office()
                {
                 OfficeId = "3",
                 City = "Wien",
                 Country = "Austria",
                 Phone = "00431111111"
                },

                new Office()
                {
                 OfficeId = "4",
                 City = "Paris",
                 Country = "France", 
                 Phone = "00336111111"
                },

            };
            return offices;
        }
    }
}




