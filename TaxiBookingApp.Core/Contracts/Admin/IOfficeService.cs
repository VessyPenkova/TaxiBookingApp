using TaxiBookingApp.Core.Models.OfficeM;



namespace TaxiBookingApp.Core.Contracts.Admin
{
    public interface IOfficeService
    {
        Task<bool> OfficeExistsById(string OfficeId);

        Task<IEnumerable<OfficeHomeModel>> LastThreeOffices();

        Task Create(string officeId, string city, string country, string phone);

        Task<OfficeQueryModel> All(
          string? searchItem = null,
          int currentPage = 1,
          int officessPerPage = 3);

        Task<IEnumerable<OfficeServiceModel>> AllOfficesByCity(string city);



      
    }
}
