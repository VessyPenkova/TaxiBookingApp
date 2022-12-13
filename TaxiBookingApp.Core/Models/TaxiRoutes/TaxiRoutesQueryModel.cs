

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public class TaxiRoutesQueryModel
    {
        public int TotaltaxiRoutesCount { get; set; }

        public IEnumerable<TaxiRouteServiceModel> TaxiRoutes { get; set; } = new List<TaxiRouteServiceModel>();
    }

}

