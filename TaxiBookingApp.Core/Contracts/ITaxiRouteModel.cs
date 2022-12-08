using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Contracts
{
    public   interface ITaxiRouteModel
    {
        public int TaxiRouteId { get; } 

        public string Title { get; }

       
        public string PickUpAddress { get; } 

       
        public string DeliveryAddress { get;} 

    }
}
