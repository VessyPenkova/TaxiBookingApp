using TaxiBookingApp.Core.Models.OfficeM;



namespace TaxiBookingApp.Core.Contracts
{
    public interface IOfficeService
    {
        Task<IEnumerable<OfficeHomeModel>> LastThreeOffices();

        Task<bool> OfficeExistsById(string OfficeId);

       

        Task <int> Create(OfficeModel model, int driverId);

        Task<OfficeQueryModel> All(
          string? searchItem = null,
          int currentPage = 1,
          int officessPerPage = 3);

        Task<IEnumerable<OfficeServiceModel>> AllOfficesByCity(string city);

        Task<OfficeDetailsModel> OfficeDetailsById(string city);

        Task Edit(int OfficeId, OfficeModel model);

        Task Delete(int officeId);
    }
}
