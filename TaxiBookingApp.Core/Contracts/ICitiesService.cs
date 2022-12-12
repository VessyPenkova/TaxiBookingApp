
namespace TaxiBookingApp.Core.Contracts
{
    public  interface ICitiesService
    {
       
        Task AddAsync(string name);

        Task DeleteAsync(string name);

        Task<bool> ExistsAsync(int cityId);

    }
}
