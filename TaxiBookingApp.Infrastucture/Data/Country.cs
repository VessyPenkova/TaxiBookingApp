using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Infrastucture.Data
{
    public  class Country
    {
        public int CountyId { get; set; }
        public string CountryName{ get; set; }

        public bool IsActive { get; set; } = true;
    }
}
