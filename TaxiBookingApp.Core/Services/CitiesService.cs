using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Services
{
    internal class CitiesService : ICitiesService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        private readonly ILogger logger;


        public CitiesService(
            IRepository _repo,
            IGuard _guard,
            ILogger<TaxiRouteService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }

        public async Task<bool> ExistsAsync(int cityId)
        {
            return await repo.AllReadonly<City>()
               .AnyAsync(s => s.CitiId == cityId && s.IsActive);

        }

        public async Task AddAsync(string name)
        {
           
            await this.repo.AddAsync(new City
            {
                Name = name,
            });
            await this.repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(string name)
        {
            var city = await repo.GetByIdAsync<City>(name);
            city.IsActive = false;

            await repo.SaveChangesAsync();
        }


       
    }
}
