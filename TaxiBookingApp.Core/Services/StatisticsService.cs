using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Models.Statistics;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Services
{
    internal class StatisticsService : IStatisticsService
    {
        private readonly IRepository repo;

        public StatisticsService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<StatisticsServiceModel> Total()
        {
            int totalTaxiRoute = await repo.AllReadonly<TaxiRoute>()
                .CountAsync(t => t.IsActive);
            int TotalRents = await repo.AllReadonly<TaxiRoute>()
                .CountAsync(t => t.IsActive && t.RenterId != null);

            return new StatisticsServiceModel()
            {
                TotalTaxiRoutes = totalTaxiRoute,
                TotalRents = TotalRents
            };
        }
    }
}
