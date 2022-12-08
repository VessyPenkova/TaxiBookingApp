using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Core.Services
{
    public interface ITaxiRoutService
    {
        Task<IEnumerable<TaxiRouteHomeModel>> LastThreeTaxiRoutes();

        Task<IEnumerable<TaxiRouteCategoryModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(TaxiRouteModel model, int agentId);

        Task<TaxiRoutesQueryModel> All(
            string? category = null,
            string? searchTerm = null,
            TaxiRouteSorting sorting = TaxiRouteSorting.Newest,
            int currentPage = 1,
            int taxiRoutePerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<TaxiRouteServiceModel>> AllTaxiRoutesByDriverCarId(int id);

        Task<IEnumerable<TaxiRouteServiceModel>> AllTaxiRouteByUserId(string userId);

        Task<TaxiRouteDetailsModel> TaxiRouteDetailsByTaxiRouteId(int taxiRouteid);

        Task<bool> Exists(int taxiRouteid);

        Task Edit(int taxiRouteid, TaxiRouteModel model);

        Task<bool> HasDriverCarWithId(int taxiRouteid, string currentUserId);

        Task<int> GetTaxiRouteCategoryId(int taxiRouteid);

        Task Delete(int taxiRouteid);

        Task<bool> IsRented(int taxiRouteid);

        Task<bool> IsRentedByUserWithId(int taxiRouteid, string currentUserId);

        Task Rent(int taxiRouteid, string currentUserId);

        Task Leave(int taxiRouteid);
    }
}
