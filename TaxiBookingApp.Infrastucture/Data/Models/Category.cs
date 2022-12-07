using System.ComponentModel.DataAnnotations;

namespace TaxiBookingApp.Infrastucture.Data.Models
{
    public class Category
    {
        public Category()
        {
            TaxiRoutes = new List<TaxiRoute>();
        }

        [Key]
        public int CategoryId { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;


        public List<TaxiRoute> TaxiRoutes { get; set; }
    }
}
