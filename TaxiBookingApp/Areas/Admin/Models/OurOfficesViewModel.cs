using TaxiBookingApp.Core.Models.OfficeM;

namespace TaxiBookingApp.Areas.Admin.Models
{
    public class OurOfficesViewModel
    {
        public IEnumerable<OfficeServiceModel> AvailableOffices { get; set; }
           = new List<OfficeServiceModel>();
    }
}
