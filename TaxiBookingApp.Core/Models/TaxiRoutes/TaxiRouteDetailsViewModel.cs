namespace TaxiBookingApp.Core.Models.TaxiRoutes
{
    public class TaxiRouteDetailsViewModel
    {
        public string Title { get; set; } = null!;

        public string PickUpAddress { get; set; } = null!;

        public string ImageUrlRouteGoogleMaps { get; set; } = null!;

        public string DeliveryAddress { get; set; } = null!;
    }
}