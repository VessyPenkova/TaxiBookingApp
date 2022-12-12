using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookingApp.Infrastucture.Data
{
    public  class City
    {
        [Key]
        public int CitiId { get; set; }
        public City()
        {
            TaxiRoutes = new List<TaxiRoute>();
        }

        [Required]
   
        public string Name { get; set; }

        public virtual ICollection<TaxiRoute> TaxiRoutes { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
