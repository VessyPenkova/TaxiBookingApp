using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Models.OfficeM
{
    public class OfficeDetailsModel : OfficeServiceModel
    {
        public string OfficeCity { get; set; } = null!;
        public string OfficeCountry { get; set; } = null!;

        public DriverCarServiceModel DriverCar { get; set; } = null!;



    }
}
