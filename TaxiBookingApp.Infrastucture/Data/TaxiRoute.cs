using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiBookingApp.Infrastucture.Data
{
    public class TaxiRoute
    {
        [Key]
        public int TaxiRoutId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string PickUpAddress { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string DeliveryAddress { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrlRouteGoogleMaps { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int DriverCarId { get; set; }

        [ForeignKey(nameof(DriverCarId))]
        public DriverCar DriverCar { get; set; } = null!;

        public string? RenterId { get; set; }

        [ForeignKey(nameof(RenterId))]
        public ApplicationUser? Renter { get; set; }

        public bool IsActive { get; set; } = true;
        [Required]
        public int CityId { get; set; }
        [Required]
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

    }
}
