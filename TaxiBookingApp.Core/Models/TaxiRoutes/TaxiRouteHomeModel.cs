using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Core.Contracts;

namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public class TaxiRouteHomeModel : ITaxiRouteModel
    {
        public int TaxiRouteId { get; init; }

        public string Title { get; set; } = null!;

        public string PickUpAddress { get; set; } = null!;

        public string DeliveryAddress { get; set; } = null!;

        public string ImageUrlRouteGoogleMaps { get; init; } = null!;
    }
}
