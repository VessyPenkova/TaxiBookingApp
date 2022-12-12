using TaxiBookingApp.Core.Models;

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public  class TaxiRouteDetailsModel : TaxiRouteServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public DriverCarServiceModel DriverCar { get; set; } = null!;
    }
}
