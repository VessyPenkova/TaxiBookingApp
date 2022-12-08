using System.ComponentModel.DataAnnotations;
namespace TaxiBookingApp.Core.Models.DriverCar
{
    public class BecomeDriverCarModel
    {
        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
