using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models
{
    public class CountryHomeModel : ICountryModel
    {
        public int CitiId { get; set; }

        public string Name { get; set; } = null!;
    }
}
