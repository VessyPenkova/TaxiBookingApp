using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.OfficeM;

namespace TaxiBookingApp.Models
{
    public class AllOfficesQueryModel
    {
        public const int OfficesPerPage = 3;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;
        public string OfficePhone { get; set; } = null!;

        public string? SearchTerm { get; set; }

        public int OfficeesRoutesCount { get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<OfficeServiceModel> Officees { get; set; } = Enumerable.Empty<OfficeServiceModel>();
    }
}
