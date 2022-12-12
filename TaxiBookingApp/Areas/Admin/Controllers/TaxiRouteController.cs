
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Extensions;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Areas.Admin.Models;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class TaxiRouteController : BaseController
    {

       private readonly ITaxiRouteService taxiRouteService;
       private readonly IDriverCarService driverCarService;

        public TaxiRouteController(
            ITaxiRouteService _taxRouteService,
            IDriverCarService _driverCarService)
        {
            taxiRouteService = _taxRouteService;
            driverCarService = _driverCarService;
        }
        public async Task<IActionResult> Mine()
        {
            var myTaxiRoutes = new MyTaxiRoutesViewModel();
            var adminId = User.Id();
            myTaxiRoutes.RentedTaxiRoutes = await taxiRouteService.AllTaxiRouteByUserId(adminId);
            var driverCarId = await driverCarService.GetDriverCarId(adminId);
            myTaxiRoutes.AddedTaxiRoutes = await taxiRouteService.AllTaxiRoutesByDriverCarId(driverCarId);

            return View(myTaxiRoutes);
        }
    }
}
