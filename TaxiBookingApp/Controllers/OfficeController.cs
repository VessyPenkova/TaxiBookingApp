using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Core.Constans;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Extensions;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Controllers
{

    [Authorize]
    public class OfficeController : Controller
    {
        private readonly IOfficeService officeservicse;

        private readonly IRepository repo;
        public OfficeController(IOfficeService _officeservicse, IRepository _repo)
        {
            officeservicse = _officeservicse;
            repo = _repo;
        }

      
        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<DriverCar>()
                .AnyAsync(u => u.UserId == userId);
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await officeservicse.OfficeExistsById(officeId. == false)
            {
                return RedirectToAction(nameof(OfficeController.Create), "Office");
            }

            var model = new OfficeServiceModel()
            {
                Offices = await officeservicse.All()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(OfficeServiceModel model)
        {
            if ((await model.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(DriverCarController.Become), "DriverCar");
            }

            if ((await taxiRouteService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exists");
            }

            if (!ModelState.IsValid)
            {
                model.TaxiRouteCategories = await taxiRouteService.AllCategories();
                return View(model);
            }

            int driverCarId = await driverCarService.GetDriverCarId(User.Id());

            int id = await taxiRouteService.Create(model, driverCarId);

            return RedirectToAction(nameof(Details), new { id = id, information = model.GetInformation() });
        }
    }
}
