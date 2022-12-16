using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Controllers;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Core.Services.Admin;
using TaxiBookingApp.Models;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class OfficeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
