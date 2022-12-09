using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Exceptions
{
    public  class TaxiRouteException : ApplicationException
    {
        public TaxiRouteException()
        {
                
        }

        public TaxiRouteException(string errorMessage)
            : base(errorMessage)
        {

        }

    }
}
