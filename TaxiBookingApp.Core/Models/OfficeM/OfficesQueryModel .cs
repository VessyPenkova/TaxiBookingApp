using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Core.Models.OfficeM
{
    public class OfficeQueryModel
    {
        public int AddedOfficesCaout { get; set; }
        public IEnumerable<OfficeServiceModel> Offices { get; set; } = new List<OfficeServiceModel>();
    }

}

