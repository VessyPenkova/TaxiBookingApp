using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static TaxiBookingApp.Areas.Admin.Constrains.AdminConstants;

namespace TaxiBookingApp.Areas.Admin.Controllers
{

    [Area(AreaName)]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRolleName)]

    public class BaseController : Controller
    {
        
    }
}
