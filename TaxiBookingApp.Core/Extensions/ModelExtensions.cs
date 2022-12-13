using System.Text;
using System.Text.RegularExpressions;
using TaxiBookingApp.Core.Contracts;


namespace TaxiBookingApp.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ITaxiRouteModel taxiRoute)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(taxiRoute.Title.Replace(" ", "-"));
            sb.Append("-");
            sb.Append(GetPickUpAddressAddress(taxiRoute.PickUpAddress));
            sb.Append(GetDeliveryAddressAddress(taxiRoute.DeliveryAddress));

            return sb.ToString();
        }

        private static string GetPickUpAddressAddress(string pickUpAddress)
        {
            string result = string
                .Join("-", pickUpAddress.Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Take(3));

            return Regex.Replace(pickUpAddress, @"[^a-zA-Z0-9\-]", string.Empty);
        }

        private static string GetDeliveryAddressAddress(string deliveryUpAddress)
        {
            string result = string
                .Join("-", deliveryUpAddress.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Take(3));

            return Regex.Replace(deliveryUpAddress, @"[^a-zA-Z0-9\-]", string.Empty);

        }
    }
}

