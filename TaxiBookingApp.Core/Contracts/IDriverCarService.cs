namespace TaxiBookingApp.Core.Contracts
{
    public interface IDriverCarService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string phoneNumber);

        Task<int> GetDriverCarId(int driverCarId);
    }
}
