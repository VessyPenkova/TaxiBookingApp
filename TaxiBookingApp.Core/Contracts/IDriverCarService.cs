

namespace TaxiBookingApp.Core.Contracts
{
    internal interface IDriverCarService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string phoneNumber);

        Task<int> GetAgentId(string userId);
    }
}
