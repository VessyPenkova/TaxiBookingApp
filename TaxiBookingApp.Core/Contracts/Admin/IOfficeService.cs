using TaxiBookingApp.Core.Models;
using TaxiBookingApp.Core.Models.Admin;

namespace TaxiBookingApp.Core.Contracts.Admin
{
    public interface IOfficeService
    {
        Task<bool> OfficeExistsById(string OfficeId);
        Task Create(string officeId, string city, string country, string phone);
        Task<OfficeQueryModel> All(string? office = null, string? searchTerm = null, int currentPage = 1, int citiesPerPage = 1);
    }
}
