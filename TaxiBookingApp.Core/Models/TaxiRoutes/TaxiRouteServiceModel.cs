using System.ComponentModel.DataAnnotations;
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

        
        public string OfficeId { get; set; } = null!;

    }
}
