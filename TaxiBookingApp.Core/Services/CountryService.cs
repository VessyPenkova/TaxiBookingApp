using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        private readonly ILogger logger;


        public CountryService(
            IRepository _repo,
            IGuard _guard,
            ILogger<TaxiRouteService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }

        public async Task AddAsync(string name)
        {
            await this.repo.AddAsync(new Country
            {
                CountryName = name,
            });
            await this.repo.SaveChangesAsync();
        }

        public  async Task DeleteAsync(string name)
        {
            var city = await repo.GetByIdAsync<Country>(name);
            city.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int countryIdId)
        {
            return await repo.AllReadonly<Country>()
                 .AnyAsync(c => c.CountyId == countryIdId && c.IsActive);
        }
    }
}
