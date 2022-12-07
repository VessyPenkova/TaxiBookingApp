using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaxiBookingApp.Core.Models.TaxiRoutes;

namespace TaxiBookingApp.Controllers
{
    [Authorize]
    public class TaxiRouteController : Controller
    {
        [AllowAnonymous]
        public async Task< IActionResult> All()
        {
            var model = new TaxiRoutesQueryModel();

            return View(model);

        }

       
        public async Task<IActionResult> Mine()
        {
            var model = new TaxiRoutesQueryModel();

            return View(model);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Details (int id)
        {
            var model = new TaxiRouteDetailsModel();
            return View(model);
        }
      
        [HttpGet]
        public IActionResult Add() => View();

  
        [HttpPost]
        public async Task<IActionResult> Add(TaxiRouteModel model)
        {
            int id = 1;
            return RedirectToAction(nameof(Details), new { id });
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new TaxiRouteModel();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaxiRouteModel model)
        {
            return RedirectToAction(nameof(Details), new { id });
        }
        [HttpPost]
        public async Task<IActionResult> Delete (int id)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }


        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
