using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.OfficeM;
using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Services
{
    public class OfficeService : IOfficeService
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
               .AnyAsync(o => o.OfficeId == officeId);

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




        public async Task<IEnumerable<OfficeServiceModel>> LastThreeOffices()
        {
            return await repo.AllReadonly<Office>()

                .OrderByDescending(o => o.OfficeId)
                .Select(o => new OfficeServiceModel()
                {
                    OfficeId = o.OfficeId,
                    City = o.City,
                    Country = o.Country,
                    OfficeImageUrl = o.OfficeImageUrl,
                    Phone = o.Phone,

                })
                .Take(3)
                .ToListAsync();
        }


        public async Task<OfficeQueryModel> All(string? searchItem = null, int currentPage = 1, int officessPerPage = 1)
        {
            var result = new OfficeQueryModel();
            var offices = repo.AllReadonly<Office>()
                .Where(t => t.IsActive);

            result.Offices = await offices
                .Skip((currentPage - 1) * officessPerPage)
                .Take(officessPerPage)
                .Select(of => new OfficeServiceModel()
                {
                    City = of.City,
                    Country = of.Country,
                    OfficeImageUrl = of.OfficeImageUrl,
                    Phone = of.Phone,
                    OfficeId = of.OfficeId,
                })
                .ToListAsync();

            result.AddedOfficesCaout = await offices.CountAsync();

            return result;
        }

        Task<IEnumerable<OfficeHomeModel>> IOfficeService.LastThreeOffices()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OfficeServiceModel>> AllOfficesByCity(string city)
        {
            throw new NotImplementedException();
        }
    }
}
