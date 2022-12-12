using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Core.Contracts
{
    public  interface ICountryService
    {
        Task AddAsync(string name);

        Task DeleteAsync(string name);

        Task<bool> ExistsAsync(int countryIdId);
    }
}
