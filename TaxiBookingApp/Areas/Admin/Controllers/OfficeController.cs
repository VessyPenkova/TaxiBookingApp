using HouseRentingSystem.Core.Services.Admin;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Controllers;
using TaxiBookingApp.Core.Contracts.Admin;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class OfficeController : BaseController
    {
        private readonly IOfficeService officeService;
        public OfficeController(IOfficeService _officeService)
        {
            officeService = _officeService;
        }

        public async Task<IActionResult> All()
        {
            var model = await officeService.All();

            return View(model);
        }
    }
}
