using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Models
{
    public class AlTaxiRoutesQueryModel
    {
        public const int TaxiRoutesPerPage = 3;

        public string? Category { get; set; }

        public string? SearchTerm { get; set; }

        public TaxiRouteSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalTaxiRouteCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<TaxiRouteServiceModel> TaxiRoutes { get; set; } = Enumerable.Empty<TaxiRouteServiceModel>();
    }
}
