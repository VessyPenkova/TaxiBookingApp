
using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data.Models;

namespace TaxiBookingApp.Core.Services
{
    public class DriverCarService : IDriverCarService
    {
        private readonly IRepository repo;

        public DriverCarService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, string phoneNumber)
        {
            var driverCar = new DriverCar()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await repo.AddAsync(driverCar);
            await repo.SaveChangesAsync();
        }


        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<DriverCar>()
                .AnyAsync(u => u.UserId == userId);
        }

      

        public async  Task<int> GetDriverCarId(int driverCarId)
        {
            return (await repo.AllReadonly<DriverCar>()
               .FirstOrDefaultAsync(d => d.DriverCarId == driverCarId))?.DriverCarId ?? 0;
        }

 
        public async Task<bool> UserHasRents(string userId)
        {
            return await repo.All<TaxiRoute>()
                .AnyAsync(t => t.RenterId == userId);
        }

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await repo.All<DriverCar>()
                 .AnyAsync(d => d.PhoneNumber == phoneNumber);
        }

      
    }
}
