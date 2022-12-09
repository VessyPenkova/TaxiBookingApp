using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Areas.Admin.Views
{
    public class MyTaxiRoutesViewModel
    {

        public IEnumerable<TaxiRouteServiceModel> AddedTaxiRoutes { get; set; }
           = new List<TaxiRouteServiceModel>();

        public IEnumerable<TaxiRouteServiceModel> RentedTaxiRoutes { get; set; }
            = new List<TaxiRouteServiceModel>();
    }
}
