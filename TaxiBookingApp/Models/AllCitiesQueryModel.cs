using TaxiBookingApp.Core.Models;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Models
{
    public class AllCitiesQueryModel
    {
        public const int CitiesPerPage = 3;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<UserServiceModel> TaxiRoutes { get; set; } = Enumerable.Empty<UserServiceModel>();
    }
}
