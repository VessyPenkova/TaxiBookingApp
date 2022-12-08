

namespace TaxiBookingApp.Core.Contracts
{
    public  interface IStatisticsService
    {
        Task<StatisticsServiceModel> Total();
    }
}
