using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Core.Services.Admin;
using TaxiBookingApp.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class TaxiBookingAppServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ITaxiRouteService, TaxiRouteService>();
            services.AddScoped<IDriverCarService, DriverCarService>();
            services.AddScoped<IGuard, Guard>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOfficeService, OfficeService>();

            return services;
        }

    }
}
