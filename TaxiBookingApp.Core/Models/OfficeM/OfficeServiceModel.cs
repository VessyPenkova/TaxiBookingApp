using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaxiBookingApp.Core.Contracts.Admin;

namespace TaxiBookingApp.Core.Models.OfficeM
{
    public class OfficeServiceModel : IOfficeModel
    {
        public string OfficeId { get; init; } = null!;

        public string City { get; init; } = null!;

        public string Country { get; init; } = null!;
        [Display(Name = "Phone")]
        public string Phone { get; init; } = null!;
        [Display(Name = "Image URL")]
        public string OfficeImageUrl { get; init; } = null!;
    }
}
