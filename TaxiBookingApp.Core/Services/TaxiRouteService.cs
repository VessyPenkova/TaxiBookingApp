using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaxiBookingApp.Infrastucture.Data.Models;
using TaxiBookingApp.Core.Services;

namespace HouseRentingSystem.Core.Services
{
    public class TaxiRouteService : ITaxiRoutService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        private readonly ILogger logger;

        public TaxiRouteService(
            IRepository _repo,
            IGuard _guard,
            ILogger<TaxiRouteService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }
        //  TaxiRoutes
        public async Task<TaxiRoutesQueryModel> All(string? category = null, string? searchTerm = null, TaxiRouteSorting sorting = TaxiRouteSorting.Newest, int currentPage = 1, int taxiRoutesPerPage = 1)
        {
            var result = new TaxiRoutesQueryModel();
            var taxiRoute = repo.AllReadonly<TaxiRoute>()
                .Where(h => h.IsActive);

            if (string.IsNullOrEmpty(category) == false)
            {
                taxiRoute = taxiRoute
                    .Where(h => h.Category.Name == category);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                taxiRoute = taxiRoute
                    .Where(h => EF.Functions.Like(h.Title.ToLower(), searchTerm) ||
                        EF.Functions.Like(h.PickUpAddress.ToLower(), searchTerm) ||
                        EF.Functions.Like(h.Description.ToLower(), searchTerm));
            }

            //switch (sorting)
            //{
            //    case HouseSorting.Price:
            //        houses = houses
            //        .OrderBy(h => h.PricePerMonth);
            //        break;
            //    case HouseSorting.NotRentedFirst:
            //        houses = houses
            //        .OrderBy(h => h.RenterId);
            //        break;
            //    default:
            //        houses = houses.OrderByDescending(h => h.Id);
            //        break;
            //}

            taxiRoute = sorting switch
            {
                TaxiRouteSorting.Price => taxiRoutes
                    .OrderBy(h => h.PricePerMonth),
                TaxiRouteSorting.NotRentedFirst => taxiRoutes
                    .OrderBy(h => h.RenterId),
                _ => taxiRoutes.OrderByDescending(h => h.Id)
            };

            result.TaxiRoutes = await taxiRoutes
                .Skip((currentPage - 1) * taxiRoutesPerPage)
                .Take(housesPerPage)
                .Select(h => new TaxiRouteServiceModel()
                {
                    PickUpAddress = h.PickUpAddress,
                    TaxiRoutId = h.TaxiRoutId,
                    ImageUrlRouteGoogleMaps = h.ImageUrlRouteGoogleMaps,
                    IsRented = h.RenterId != null,
                    Price = h.PriceP,
                    Title = h.Title
                })
                .ToListAsync();

            result.TotalTaxiRoutesCount = await taxiRoutes.CountAsync();

            return result;
        }

        public async Task<IEnumerable<TaxiRouteCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new TaxiRouteCategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<TaxiRouteServiceModel>> AllTaxiRoutesByAgentId(int id)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(c => c.IsActive)
                .Where(c => c.AgentId == id)
                .Select(c => new TaxiRouteServiceModel()
                {
                    PickUpAddress = c.PickUpAddress,
                    TaxiRoutId = c.TaxiRoutId,
                    ImageUrlRouteGoogleMaps = c.ImageUrlRouteGoogleMaps,
                    IsRented = c.RenterId != null,
                    Price = c.Price,
                    Title = c.Title
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TaxiRouteServiceModel>> AlltaxiRoutesByUserId(string userId)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(c => c.RenterId == userId)
                .Where(c => c.IsActive)
                .Select(c => new TaxiRouteServiceModel()
                {
                    PickUpAddress = c.PickUpAddress,
                    TaxiRoutId = c.TaxiRoutId,
                    ImageUrlRouteGoogleMaps = c.ImageUrlRouteGoogleMaps,
                    IsRented = c.RenterId != null,
                    Price = c.Price,
                    Title = c.Title
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.CategoryId == categoryId);
        }

        public async Task<int> Create(TaxiRouteModel model, int agentId)
        {
            var taxiRoute = new TaxiRoute()
            {
                PickUpAddress = model.PickUpAddress,
                CategoryId = model.CategoryId,
                Description = model.Description,
                ImageUrlRouteGoogleMaps = model.ImageUrlRouteGoogleMaps,
                Price = model.Price,
                Title = model.Title,
                AgentId = agentId
            };

            try
            {
                await repo.AddAsync(taxiRoute);
                await repo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(nameof(Create), ex);
                throw new ApplicationException("Database failed to save info", ex);
            }

            return taxiRoute.Id;
        }

        public async Task Delete(int houseId)
        {
            var house = await repo.GetByIdAsync<TaxiRoute>(houseId);
            house.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int taxiRouteid, TaxiRouteModel model)
        {
            var taxiRoute = await repo.GetByIdAsync<TaxiRoute>(taxiRouteid);

            taxiRoute.Description = model.Description;
            taxiRoute.ImageUrlRouteGoogleMaps = model.ImageUrlRouteGoogleMaps;
            taxiRoute.Price = model.Price;
            taxiRoute.Title = model.Title;
            taxiRoute.PickUpAddress = model.PickUpAddress;
            taxiRoute.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .AnyAsync(t => t.TaxiRoutId == id && t.IsActive);
        }

        public async Task<int> GetTaxiRouteCategoryId(int taxiRouteId)
        {
            return (await repo.GetByIdAsync<TaxiRoute>(taxiRouteId)).CategoryId;
        }

        public async Task<bool> HasAgentWithId(int taxiRouteId, string currentUserId)
        {
            bool result = false;
            var taxiRoute = await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .Where(t => t.TaxiRouteId == taxiRouteId)
                .Include(t => t.Agent)
                .FirstOrDefaultAsync();

            if (taxiRoute?.Agent != null && taxiRoute.Agent.UserId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task<TaxiRouteDetailsModel> TaxiRouteDetailsById(int taxiRouteId)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .Where(t => t.Id == taxiRouteId)
                .Select(t => new TaxiRouteDetailsModel()
                {
                    PickUpAddress = t.PickUpAddress,
                    Category = t.Category.Name,
                    Description = t.Description,
                    TaxiRouteId = taxiRouteId,
                    ImageUrlRouteGoogleMaps = t.ImageUrlRouteGoogleMaps,
                    IsRented = t.RenterId != null,
                    Price = t.Price,
                    Title = t.Title,
                    DriverCar = new Models.DriverCar.DriverCarServiceModel()
                    {
                        Email = t.DriverCar.User.Email,
                        PhoneNumber = t.DriverCar.PhoneNumber
                    }

                })
                .FirstAsync();
        }

        public async Task<bool> IsRented(int taxiRouteId)
        {
            return (await repo.GetByIdAsync<TaxiRoute>(taxiRouteId)).RenterId != null;
        }

        public async Task<bool> IsRentedByUserWithId(int taxiRouteId, string currentUserId)
        {
            bool result = false;
            var taxiRoute = await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .Where(t => t.TaxiRouteId == taxiRouteId)
                .FirstOrDefaultAsync();

            if (taxiRoute != null && taxiRoute.RenterId == currentUserId)
            {
                result = true;
            }

            return result;
        }
        public Task<IEnumerable<LastThreeTaxiRoutes>> LastThreeTaxiRoutes()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<TaxiRouteHomeModel>> LastThreeTaxiRoutes()
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .OrderByDescending(t => t.TaxiRouteId)
                .Select(t => new TaxiRouteHomeModel()
                {
                    TaxiRouteId = t.TaxiRouteId,
                    ImageUrlRouteGoogleMaps = t.ImageUrlRouteGoogleMaps,
                    Title = t.Title,
                    PickUpAddress = t.PickUpAddress
                })
                .Take(3)
                .ToListAsync();
        }

        public async Task Leave(int taxiRouteId)
        {
            var taxiRoute = await repo.GetByIdAsync<TaxiRoute>(taxiRouteId);
            guard.AgainstNull(taxiRoute, "Route can not be found");
            taxiRoute.RenterId = null;

            await repo.SaveChangesAsync();
        }

        public async Task Rent(int taxiRouteId, string currentUserId)
        {
            var taxiRoute = await repo.GetByIdAsync<TaxiRoute>(taxiRouteId);

            if (taxiRoute != null && taxiRoute.RenterId != null)
            {
                throw new ArgumentException("TaxiRoute is full");
            }

            guard.AgainstNull(taxiRoute, "House can not be found");
            taxiRoute.RenterId = currentUserId;

            await repo.SaveChangesAsync();
        }

       

        Task<IEnumerable<TaxiRouteServiceModel>> ITaxiRoutService.AllTaxiRoutesByDriverCarId(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TaxiRouteServiceModel>> ITaxiRoutService.AllTaxiRouteByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<TaxiRouteDetailsModel> TaxiRouteDetailsByTaxiRouteId(int taxiRouteid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasDriverCarWithId(int taxiRouteid, string currentUserId)
        {
            throw new NotImplementedException();
        }
    }
}
