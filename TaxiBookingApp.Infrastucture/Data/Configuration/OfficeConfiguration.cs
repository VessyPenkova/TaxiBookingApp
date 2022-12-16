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
                 Phone = "0035932111111",
                 OfficeImageUrl = "https://media.istockphoto.com/photos/outside-view-of-a-office-building-with-blue-windows-picture-id157439187"
                },

                new Office()
                {
                 OfficeId = "2",
                 City = "Plovdiv",
                 Country = "Sofia",
                 Phone = "0035932111111",
                 OfficeImageUrl = "https://th.bing.com/th/id/R.ea2068b541126d4df2a90dda8af3a849?rik=R7U0u2Gyiwjx6g&riu=http%3a%2f%2fwww.theboutiqueoffice.com%2fwp-content%2fuploads%2f2015%2f04%2fAked-Esplanad-For-Rent-in-Bukit-Jalil-03.png&ehk=4yTgJ6%2ftN%2f8PkOiP%2fsuwRbu2Qse0NDJ6p5QeCndFGeY%3d&risl=&pid=ImgRaw&r=0",
                },


                new Office()
                {
                 OfficeId = "3",
                 City = "Wien",
                 Country = "Austria",
                 Phone = "00431111111",
                 OfficeImageUrl = "https://www.s2architecture.com/uploads/gallery/Truman-Office-Building/02.jpg",
                },

                new Office()
                {
                 OfficeId = "4",
                 City = "Paris",
                 Country = "France", 
                 Phone = "00336111111",
                 OfficeImageUrl = "https://th.bing.com/th/id/R.71dc3e07a5b246f95b10290d63d07d76?rik=Evh2RFKPJOVltA&riu=http%3a%2f%2fwww.buildingbutler.com%2fimages%2fgallery%2flarge%2fbuilding-facades-3463-13832.jpg&ehk=DVp9ap9ScbrjzkKQi9SLz9RYrm82XS8RqsUgwYwmmSw%3d&risl=&pid=ImgRaw&r=0",
                },

            };
            return offices;
        }
    }
}




