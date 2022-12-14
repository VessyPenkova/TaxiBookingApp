using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TaxiBookingApp.Infrastucture.Data.Configuration
{
    internal class TaxiRouteConfiguration : IEntityTypeConfiguration<TaxiRoute>
    {
        public void Configure(EntityTypeBuilder<TaxiRoute> builder)
        {
            //builder.HasData(CreateTaxiRoutes());
        }
        private List<TaxiRoute> CreateTaxiRoutes()
        {
            var taxiRoutes = new List<TaxiRoute>()
            {
                new TaxiRoute()
                {
                    TaxiRouteId = 11,
                    Title ="Pivate Luxury",
                    PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                    DeliveryAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                    Description = "Wheather you want a tourist tour from Plovdiv to Sofia, or simply buizness trip, this trip is private with a luxary limousine",
                    ImageUrlRouteGoogleMaps ="https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0",
                    Price = 316.80M,
                    CategoryId = 1,
                    DriverCarId = 1,
                    RenterId = "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                    CityId = 1,

                },
                 new TaxiRoute()
                {
                    TaxiRouteId = 22,
                    Title ="Sared",
                    PickUpAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                    DeliveryAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                    Description = "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine",
                    ImageUrlRouteGoogleMaps ="https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0",
                    Price = 316.80M,
                    CategoryId = 2,
                    DriverCarId = 1,
                    RenterId = "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                    CityId = 2,

                },
                    new TaxiRoute()
                {
                    TaxiRouteId = 33,
                    Title ="Sared with One",
                    PickUpAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                    DeliveryAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                    Description = "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine",
                    ImageUrlRouteGoogleMaps ="https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0",
                    Price = 158.40M,
                    CategoryId = 2,
                    DriverCarId = 1,
                    RenterId = "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                    CityId = 2,

                },
                   new TaxiRoute()
                {
                    TaxiRouteId = 44,
                    Title ="Sared",
                    PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                    DeliveryAddress = "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria",
                    Description = "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine",
                    ImageUrlRouteGoogleMaps ="https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.1462238,24.7489407,15.5z/data=!4m14!4m13!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!3e0",
                    Price = 6.20M,
                    CategoryId = 3,
                    DriverCarId = 1,
                    RenterId = "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                    CityId = 1,

                },
                        new TaxiRoute()
                {
                    TaxiRouteId = 55,
                    Title ="Sared",
                    PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                    DeliveryAddress = "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria",
                    Description = "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine",
                    ImageUrlRouteGoogleMaps ="https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.147763,24.751646,16z/data=!3m1!4b1!4m20!4m19!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0",
                    Price = 10.20M,
                    CategoryId = 4,
                    DriverCarId = 1,
                    RenterId ="6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                    CityId = 1,

                },
            };
            return taxiRoutes;
        }
    }
}
