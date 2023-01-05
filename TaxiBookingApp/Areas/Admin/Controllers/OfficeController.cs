using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Areas.Admin.Models;
using TaxiBookingApp.Controllers;
using TaxiBookingApp.Core.Contracts;
using TaxiBookingApp.Core.Models.OfficeM;
using TaxiBookingApp.Core.Services;
using TaxiBookingApp.Core.Services.Admin;
using TaxiBookingApp.Extensions;
using TaxiBookingApp.Models;

namespace TaxiBookingApp.Areas.Admin.Controllers
{
    public class OfficeController : BaseController
    {
        private readonly IOfficeService officeservice;

        private readonly IDriverCarService driverCarService;

        public OfficeController(IOfficeService _officeservice,
                                IDriverCarService _driverCarService)
        {
            officeservice = _officeservice;
            driverCarService = _driverCarService;
        }
        public async Task<IActionResult> MineOurOffices()
        {
            var ourOffices = new OfficeServiceModel();
            var adminId = User.Id();
            ourOffices.RentedHouses = await officeservice.AllOfficesByCity(city);
            var agentId = await agentService.GetAgentId(adminId);
            ourOffices.AddedHouses = await houseService.AllHousesByAgentId(agentId);

            return View(ourOffices);
        }
    }
}
