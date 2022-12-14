using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiBookingApp.Infrastucture.Data
{
    public class DriverCar
    {
        [Key]
        public int DriverCarId { get; set; } 

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

    }
}


