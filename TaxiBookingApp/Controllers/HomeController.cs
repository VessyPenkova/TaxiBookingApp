using TaxiBookingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static TaxiBookingApp.Areas.Admin.Constrains.AdminConstants;
using TaxiBookingApp.Core.Services;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaxiRouteService taxiRouteService;

        public HomeController(ITaxiRouteService _taxiRouteService)
        {
            taxiRouteService =_taxiRouteService;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }

            var model = await taxiRouteService.LastThreeTaxiRoutes();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}