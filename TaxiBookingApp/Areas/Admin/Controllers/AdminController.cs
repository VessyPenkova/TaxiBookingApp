using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
