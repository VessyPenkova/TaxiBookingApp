using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Models.TaxiRoutes;
using TaxiBookingApp.Core.Extensions;
using TaxiBookingApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Extensions;
using static TaxiBookingApp.Areas.Admin.Constrains.AdminConstants;
using TaxiBookingApp.Core.Models;

namespace TaxiBookingApp.Controllers
{

    [Authorize]
    public class TaxiRouteController : Controller
    {
        private readonly ITaxiRouteService taxiRouteService;

        private readonly IDriverCarService driverCarService;

        private readonly ILogger logger;

        public TaxiRouteController(
           ITaxiRouteService _taxiRouteService,
           IDriverCarService _driverCarService,
            ILogger<TaxiRouteController> _logger)
        {
            taxiRouteService = _taxiRouteService;
            driverCarService = _driverCarService;
            logger = _logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllTaxiRoutesQueryModel query)
        {
            var result = await taxiRouteService.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllTaxiRoutesQueryModel.TaxiRoutesPerPage);



            query.TotalTaxiRoutesCount = result.TotaltaxiRoutesCount;
            query.Categories = await taxiRouteService.AllCategoriesNames();
            query.TaxiRoutes = result.TaxiRoutes;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Mine", "TaxiRoute", new { area = AreaName });
            }

            IEnumerable<TaxiRouteServiceModel> myTaxiRoutes;
            var userId = User.Id();

            if (await driverCarService.ExistsById(userId))
            {
                int taxiRouteId = await driverCarService.GetDriverCarId(userId);
                myTaxiRoutes = await taxiRouteService.AllTaxiRoutesByDriverCarId(taxiRouteId);
            }
            else
            {
                myTaxiRoutes = await taxiRouteService.AllTaxiRouteByUserId(userId);
            }

            return View(myTaxiRoutes);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if ((await taxiRouteService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await taxiRouteService.TaxiRouteDetailsByTaxiRouteId(id);

            if (information != model.GetInformation())
            {
                TempData["ErrorMessage"] = "Don't touch my slug!";

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await driverCarService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(DriverCarController.Become), "DriverCar");
            }

            var model = new TaxiRouteModel()
            {
                TaxiRouteCategories = await taxiRouteService.AllCategories()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TaxiRouteModel model)
        {
            if ((await driverCarService.ExistsById(User.Id())) == false)
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await taxiRouteService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await taxiRouteService.HasDriverCarWithId(id, User.Id())) == false)
            {
                logger.LogInformation("User with id {0} attempted to open other drivercar taxiRoute", User.Id());

                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var taxiRoute = await taxiRouteService.TaxiRouteDetailsByTaxiRouteId(id);
            var categoryId = await taxiRouteService.GetTaxiRouteCategoryId(id);

            var model = new TaxiRouteModel()
            {
                TaxiRouteId = taxiRoute.TaxiRouteId,
                PickUpAddress = taxiRoute.PickUpAddress,
                DeliveryAddress = taxiRoute.DeliveryAddress,
                CategoryId = categoryId,
                Description = taxiRoute.Description,
                ImageUrlRouteGoogleMaps = taxiRoute.ImageUrlRouteGoogleMaps,
                Price = taxiRoute.Price,
                Title = taxiRoute.Title,
                TaxiRouteCategories = await taxiRouteService.AllCategories()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaxiRouteModel model)
        {
           
            if (id != model.TaxiRouteId)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await taxiRouteService.Exists(model.TaxiRouteId)) == false)
            {
                ModelState.AddModelError("", "TaxiRoute does not exist");
                model.TaxiRouteCategories = await taxiRouteService.AllCategories();

                return View(model);
            }

            if ((await taxiRouteService.HasDriverCarWithId(model.TaxiRouteId, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await taxiRouteService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
                model.TaxiRouteCategories = await taxiRouteService.AllCategories();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.TaxiRouteCategories = await taxiRouteService.AllCategories();

                return View(model);
            }

            await taxiRouteService.Edit(model.TaxiRouteId, model);

            return RedirectToAction(nameof(Details), new { id = model.TaxiRouteId, information = model.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await taxiRouteService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await taxiRouteService.HasDriverCarWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var taxiRoute = await taxiRouteService.TaxiRouteDetailsByTaxiRouteId(id);
            var model = new TaxiRouteDetailsViewModel()
            {
                PickUpAddress = taxiRoute.PickUpAddress,
                DeliveryAddress = taxiRoute.DeliveryAddress,
                ImageUrlRouteGoogleMaps = taxiRoute.ImageUrlRouteGoogleMaps,
                Title = taxiRoute.Title
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id, TaxiRouteDetailsViewModel model)
        {
            if ((await taxiRouteService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await taxiRouteService.HasDriverCarWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await taxiRouteService.Delete(id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            if ((await taxiRouteService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if (!User.IsInRole(AdminRolleName) && await driverCarService.ExistsById(User.Id()))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (await taxiRouteService.IsRented(id))
            {
                return RedirectToAction(nameof(All));
            }

            await taxiRouteService.Rent(id, User.Id());

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            if ((await taxiRouteService.Exists(id)) == false ||
                (await taxiRouteService.IsRented(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await taxiRouteService.IsRentedByUserWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await taxiRouteService.Leave(id);

            return RedirectToAction(nameof(Mine));
        }
    }
}
