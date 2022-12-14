﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiBookingApp.Infrastucture.Data;

namespace TaxiBookingApp.Infrastucture.Data
{
    public class Office
    {
        [Key]
        public string OfficeId { get; set; } = null!;
        public Office()
        {
            TaxiRoutes = new List<TaxiRoute>();
        }

        [Required]

        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public  List<TaxiRoute> TaxiRoutes { get; set; }
        public bool IsActive { get; set; } = true;
    }
}


