using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public  class TaxiRouteDetailsModel : TaxiRouteServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public DriverCarServiceModel DriverCra { get; set; }
    }
}
