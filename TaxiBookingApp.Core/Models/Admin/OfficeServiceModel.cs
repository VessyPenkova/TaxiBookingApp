using TaxiBookingApp.Core.Contracts.Admin;

namespace TaxiBookingApp.Core.Models.Admin
{
    public class OfficeServiceModel : IOfficeModel
    {
        public string OfficeId { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone { get; set; } = null!;

       
    }
}
