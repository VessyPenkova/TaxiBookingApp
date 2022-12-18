using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Areas.Admin.Models;
using TaxiBookingApp.Controllers;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Core.Services.Admin;
using TaxiBookingApp.Extensions;
using TaxiBookingApp.Models;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class OfficeController : BaseController
    {
        private readonly IOfficeService officeservice;

        public OfficeController(IOfficeService _officeservice)
        {
            officeservice = _officeservice;
        }
        public async Task<IActionResult> All()
        {
            var ourOffices = new OurOfficesViewModel();
            var adminId = User.Id();
            ourOffices.AvailableOffices = await officeservice.LastThreeOffices();

            return View(ourOffices);
        }
    }
}
