using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Core.Constans;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Models;
using TaxiBookingApp.Extensions;

namespace TaxiBookingApp.Controllers
{
    [Authorize]
    public class DriverCarController : Controller
    {
        private readonly IDriverCarService driverCarService;

        public DriverCarController(IDriverCarService _driverCarService)
        {
            driverCarService = _driverCarService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await driverCarService.ExistsById(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "Вие вече сте шофьор";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeDriverCarModel();

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Become(BecomeDriverCarModel model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await driverCarService.ExistsById(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You are already driver";

                return RedirectToAction("Index", "Home");
            }

            if (await driverCarService.UserWithPhoneNumberExists(model.PhoneNumber))
            {
                TempData[MessageConstant.ErrorMessage] = "The phon already exist";

                return RedirectToAction("Index", "Home");
            }

            if (await driverCarService.UserHasRents(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "You must not have a booking to become driver";

                return RedirectToAction("Index", "Home");
            }

            await driverCarService.Create(userId, model.PhoneNumber);

            return RedirectToAction("All", "TaxiRoute");
        }
    }
}
