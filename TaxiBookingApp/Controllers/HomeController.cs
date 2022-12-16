using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static TaxiBookingApp.Areas.Admin.Constrains.AdminConstants;

namespace TaxiBookingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaxiRouteService taxiRouteService;

        private readonly ILogger logger;

        public HomeController(
            ITaxiRouteService _taxiRouteService,
            ILogger<HomeController> _logger)
        {
            taxiRouteService = _taxiRouteService;
            logger = _logger;
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
            var feature = this.HttpContext.Features.Get<IExceptionHandlerFeature>();

            logger.LogError(feature.Error, "TraceIdentifier: {0}", Activity.Current?.Id ?? HttpContext.TraceIdentifier);

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}