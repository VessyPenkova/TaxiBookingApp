using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Exceptions;
using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Infrastucture.Data;
using TaxiBookingApp.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TaxiBookingApp.Core.Services
{
    public class TaxiRouteService : ITaxiRouteService
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
        public async Task<TaxiRoutesQueryModel> All(string? category = null, string? searchTerm = null, 
        TaxiRouteSorting sorting = TaxiRouteSorting.Newest, int currentPage = 1, int taxiRoutesPerPage = 1)
        {
            var result = new TaxiRoutesQueryModel();
            var taxiRoutes = repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive);

            if (string.IsNullOrEmpty(category) == false)
            {
                taxiRoutes = taxiRoutes
                    .Where(h => h.Category.Name == category);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                taxiRoutes = taxiRoutes
                    .Where(tr => EF.Functions.Like(tr.Title.ToLower(), searchTerm) ||
                        EF.Functions.Like(tr.PickUpAddress.ToLower(), searchTerm) ||
                        EF.Functions.Like(tr.DeliveryAddress.ToLower(), searchTerm) ||
                        EF.Functions.Like(tr.Description.ToLower(), searchTerm));
            }

            taxiRoutes = sorting switch
            {
                TaxiRouteSorting.Price => taxiRoutes
                    .OrderBy(tr => tr.Price),
                TaxiRouteSorting.NotRentedFirst => taxiRoutes
                    .OrderBy(tr => tr.RenterId),
                _ => taxiRoutes.OrderByDescending(tr => tr.TaxiRouteId)
            };

            result.TaxiRoutes = await taxiRoutes
                .Skip((currentPage - 1) * taxiRoutesPerPage)
                .Take(taxiRoutesPerPage)
                .Select(tr => new TaxiRouteServiceModel()
                {
                    PickUpAddress = tr.PickUpAddress,
                    DeliveryAddress = tr.DeliveryAddress, 
                    TaxiRouteId = tr.TaxiRouteId,
                    ImageUrlRouteGoogleMaps = tr.ImageUrlRouteGoogleMaps,
                    IsRented = tr.RenterId != null,
                    Price = tr.Price,
                    Title = tr.Title
                })
                .ToListAsync();

            result.TotaltaxiRoutesCount = await taxiRoutes.CountAsync();

            return result;
        }
        public async Task<IEnumerable<TaxiRouteCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new TaxiRouteCategoryModel()
                {
                    CategoryId = c.CategoryId,
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
        public async Task<IEnumerable<TaxiRouteServiceModel>> AllTaxiRoutesByDriverCarId(int driverCarId)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(c => c.IsActive)
                .Where(c => c.DriverCarId == driverCarId)
                .Select(c => new TaxiRouteServiceModel()
                {
                    PickUpAddress = c.PickUpAddress,
                    DeliveryAddress = c.DeliveryAddress, 
                    TaxiRouteId = c.TaxiRouteId,
                    ImageUrlRouteGoogleMaps = c.ImageUrlRouteGoogleMaps,
                    IsRented = c.RenterId != null,
                    Price = c.Price,
                    Title = c.Title
                })
                .ToListAsync();
        }
        public async Task<IEnumerable<TaxiRouteServiceModel>> AllTaxiRouteByUserId(string userId)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(c => c.RenterId == userId)
                .Where(c => c.IsActive)
                .Select(c => new TaxiRouteServiceModel()
                {
                    PickUpAddress = c.PickUpAddress,
                    DeliveryAddress = c.DeliveryAddress,
                    TaxiRouteId = c.TaxiRouteId,
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
        public async Task<int> Create(TaxiRouteModel model, int driverCarId)
        {
            var taxiRoute = new TaxiRoute()
            {
                PickUpAddress = model.PickUpAddress,
                DeliveryAddress = model.DeliveryAddress,
                CategoryId = model.CategoryId,
                Description = model.Description,
                ImageUrlRouteGoogleMaps = model.ImageUrlRouteGoogleMaps,
                Price = model.Price,
                Title = model.Title,
                DriverCarId = driverCarId
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

            return taxiRoute.TaxiRouteId;
        }
        public async Task Delete(int taxiRouteId)
        {
            var taxiRoute = await repo.GetByIdAsync<TaxiRoute>(taxiRouteId);
            taxiRoute.IsActive = false;

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
            taxiRoute.DeliveryAddress = model.DeliveryAddress;
            taxiRoute.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }
        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .AnyAsync(t => t.TaxiRouteId == id && t.IsActive);
        }
        public async Task<int> GetTaxiRouteCategoryId(int taxiRouteId)
        {
            return (await repo.GetByIdAsync<TaxiRoute>(taxiRouteId)).CategoryId;
        }
        public async Task<bool> HasDriverCarWithId(int taxiRouteId, string currentUserId)
        {
            bool result = false;
            var taxiRoute = await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .Where(t => t.TaxiRouteId == taxiRouteId)
                .Include(t => t.DriverCar)
                .FirstOrDefaultAsync();

            if (taxiRoute?.DriverCar != null && taxiRoute.DriverCar.UserId == currentUserId)
            {
                result = true;
            }

            return result;
        }
        public async Task<TaxiRouteDetailsModel> TaxiRouteDetailsByTaxiRouteId(int taxiRouteId)
        {
            return await repo.AllReadonly<TaxiRoute>()
                .Where(t => t.IsActive)
                .Where(t => t.TaxiRouteId == taxiRouteId)
                .Select(t => new TaxiRouteDetailsModel()
                {
                    PickUpAddress = t.PickUpAddress,
                    DeliveryAddress = t.DeliveryAddress,
                    Category = t.Category.Name,
                    Description = t.Description,
                    TaxiRouteId = taxiRouteId,
                    ImageUrlRouteGoogleMaps = t.ImageUrlRouteGoogleMaps,
                    IsRented = t.RenterId != null,
                    Price = t.Price,
                    Title = t.Title,
                    DriverCar = new Models.DriverCarServiceModel()
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
                    PickUpAddress = t.PickUpAddress, 
                    DeliveryAddress = t.DeliveryAddress
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

    }
}
