﻿using TaxiBookingApp.Core.Models.Admin;


namespace TaxiBookingApp.Models
{
    public class AllOfficesQueryModel
    {
        public const int OfficesPerPage = 3;

        public string Cities { get; set; } = null!;

        public string Countries { get; set; } = null!;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<UserServiceModel> TaxiRoutes { get; set; } = Enumerable.Empty<UserServiceModel>();
    }
}
