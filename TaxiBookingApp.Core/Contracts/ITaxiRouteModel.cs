
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
