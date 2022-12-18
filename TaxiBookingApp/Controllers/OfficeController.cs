using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Core.Contracts.Admin;
using TaxiBookingApp.Core.Models.Admin;
using TaxiBookingApp.Core.Models.OfficeM;
using TaxiBookingApp.Infrastructure.Data.Common;
using TaxiBookingApp.Infrastucture.Data;
using TaxiBookingApp.Models;

namespace TaxiBookingApp.Controllers
{

    [Authorize]
    public class OfficeController : Controller
    {
        private readonly IOfficeService officeservicse;

        private readonly IRepository repo;
        public OfficeController(IOfficeService _officeservicse, IRepository _repo)
        {
            officeservicse = _officeservicse;
            repo = _repo;
        }


        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<DriverCar>()
                .AnyAsync(u => u.UserId == userId);
        }

        public async Task Create(string officeId, string city, string country, string phone)
        {

            var office = new OfficeServiceModel()
            {
                OfficeId = officeId,
                City = city,
                Country = country,
                Phone = phone,
            };
            await repo.AddAsync(office);
            await repo.SaveChangesAsync();

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllOfficesQueryModel query)
        {
            var result = await officeservicse.All(
               query.SearchTerm,
               query.CurrentPage,
               AllOfficesQueryModel.OfficesPerPage);

            query.Officees = result.Offices;

            return View(query);
        }
    }   
}
