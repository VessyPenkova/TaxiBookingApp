using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Contracts
{
    public  class ICountryModel
    {
        public int CountryId { get; }

        public string CountryName { get; set; } = null!;
    }
}
