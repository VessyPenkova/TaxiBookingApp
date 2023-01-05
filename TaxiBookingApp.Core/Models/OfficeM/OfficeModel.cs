using System.ComponentModel.DataAnnotations;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models.OfficeM
{
    public class OfficeModel : IOfficeModel
    {
        [Key]
        public string OfficeId { get; set; } = null!;


        [Required]
        [StringLength(20, MinimumLength = 4)]

        public string City { get; set; } = null!;


        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Country { get; set; } = null!;

        [Required]
        [StringLength(15, MinimumLength = 6)]

        public string Phone { get; set; } = null!;
        [Required]
        public string OfficeImageUrl { get; set; } = null!;
    }
}
