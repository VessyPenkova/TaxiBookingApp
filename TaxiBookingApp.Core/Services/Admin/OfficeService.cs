using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Core.Models;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Services.Admin
{
    internal class OfficeService : IOfficeService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        private readonly ILogger logger;


        public OfficeService(
            IRepository _repo,
            IGuard _guard,
            ILogger<OfficeService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }

        public async Task<bool> OfficeExistsById(string officeId)
        {
            return await repo.AllReadonly<Office>()
               .AnyAsync(s => s.OfficeId == officeId);

        }
        public async Task Create(string officeId, string city, string country, string phone)
        {
            var office = new OfficeServiceModel()
            {
                OfficeId = officeId,
                City = city,
                Country = country,
                Phone = phone,
            };
            await repo.AddAsync(office);
            await repo.SaveChangesAsync();

        }
      
        public async Task<OfficeQueryModel> All(
            string? office = null,
            string ? searchTerm = null, 
            int currentPage = 1, 
            int citiesPerPage = 1)
            
        {
            var result = new OfficeQueryModel();

            var offices = repo.AllReadonly<Office>()
            .Where(o => o.IsActive);

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                offices = offices
                    .Where(o => EF.Functions.Like(o.City.ToLower(), searchTerm) ||
                        EF.Functions.Like(o.Country.ToLower(), searchTerm) ||
                        EF.Functions.Like(o.Phone.ToLower(), searchTerm));
            }

            result.Offices = await offices
               .Skip((currentPage - 1) * citiesPerPage)
               .Take(citiesPerPage)
               .Select(o => new OfficeServiceModel()
               {
                   OfficeId = o.OfficeId,
                   City = o.City,
                   Country = o.Country,
                   Phone = o.Phone,
               })
               .ToListAsync();

            result.AddedOfficesCaout = await offices.CountAsync();

            return result;
        }      
    }
}
