using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public class TaxiRouteServiceModel : ITaxiRouteModel
    {
        public int TaxiRouteId { get; init; }

        public string Title { get; init; } = null!;


        public string PickUpAddress { get; init; } = null!;

        public string DeliveryAddress { get; init; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrlRouteGoogleMaps { get; init; } = null!;


        [Display(Name = "Price for trip")]
        public decimal Price { get; init; }

        [Display(Name = "Is Rented")]
        public bool IsRented { get; init; }

    }
}
