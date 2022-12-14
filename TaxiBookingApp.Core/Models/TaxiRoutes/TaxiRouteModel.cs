using System.ComponentModel.DataAnnotations;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public class TaxiRouteModel : ITaxiRouteModel
    {
        public int TaxiRouteId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string Title { get; set; } = null!;


        [Required]
        [StringLength(150, MinimumLength = 30)]

        public string PickUpAddress { get; set; } = null!;


        [Required]
        [StringLength(150, MinimumLength = 30)]

        public string DeliveryAddress { get; set; } = null!;

        [Required]
        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrlRouteGoogleMaps { get; set; } = null!;

        [Required]
        [Display(Name = "Price per trip")]
        [Range(0.00, 2000.00, ErrorMessage = "Price for trip must be a positive number and less than {2} leva")]
        public decimal Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<TaxiRouteCategoryModel> TaxiRouteCategories { get; set; } = new List<TaxiRouteCategoryModel>();
    }
}
