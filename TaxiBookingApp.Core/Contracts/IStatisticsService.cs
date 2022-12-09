using TaxiBookingApp.Core.Models.Statistics;

namespace TaxiBookingApp.Core.Contracts
{
    public  interface IStatisticsService
    {
        Task<StatisticsServiceModel> Total();
    }
}
