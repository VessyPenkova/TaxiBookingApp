using TaxiBookingApp.Core.Models.Admin;

namespace TaxiBookingApp.Core.Contracts.Admin
{
    public interface IUserService
    {
        Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();

        Task<bool> Forget(string userId);
    }
}
