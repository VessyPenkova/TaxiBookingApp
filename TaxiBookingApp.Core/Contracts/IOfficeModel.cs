using TaxiBookingApp.Core.Models.Admin;

namespace TaxiBookingApp.Core.Contracts
{
    public interface IOfficeModel
    {
        public string OfficeId { get; }
        public string City { get; }
        public string Country { get; }
        public string Phone { get; }
        public string OfficeImageUrl { get; }

    }
}
