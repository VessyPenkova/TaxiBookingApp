using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Core.Models.DriverCar;

namespace TaxiBookingApp.Controllers
{
    [Authorize]
    public class DriverCarController : Controller
    {
        [HttpGet]
        public IActionResult Become()
        {
            return View();
        }

        public async Task<IActionResult>Become(BecomeDriverCarModel model)
        {
            return RedirectToAction("All", "TaxiRouteController");
        }
    }
}
