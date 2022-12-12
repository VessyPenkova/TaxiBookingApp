using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Core.Contracts
{
    internal interface ICityModel
    {
       
        public int CitiId { get; }
      
        public string Name { get; set; }

    }
}
