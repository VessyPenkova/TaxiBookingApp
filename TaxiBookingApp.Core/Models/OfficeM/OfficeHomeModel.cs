using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models.OfficeM
{
    public class OfficeHomeModel : IOfficeModel
    {
        public string OfficeId { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string OfficeImageUrl { get; set; } = null!;
    }
}
