
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models
{
    public class CityHomeModel : ICityModel
    {
        public int CitiId { get; set; }

        public string Name { get; set; }
    }
}
