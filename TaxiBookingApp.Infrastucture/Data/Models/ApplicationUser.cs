using Microsoft.AspNetCore.Identity;

namespace TaxiBookingApp.Infrastucture.Data.Models
{
    public  class ApplicationUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
