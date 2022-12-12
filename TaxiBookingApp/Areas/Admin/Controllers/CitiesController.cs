using Microsoft.AspNetCore.Mvc;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class CitiesController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
