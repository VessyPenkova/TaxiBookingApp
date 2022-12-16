using TaxiBookingApp.Core.Models;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.OfficeM;
using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Core.Contracts.Admin
{
    public interface IOfficeService
    {
        Task<bool> OfficeExistsById(string OfficeId);

        Task<IEnumerable<OfficeServiceModel>> LastThreeOffices();

        Task Create(string officeId, string city, string country, string phone);
      
    }
}
