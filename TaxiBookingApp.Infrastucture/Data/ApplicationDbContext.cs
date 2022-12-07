using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Infrastucture.Data.Configuration;
using TaxiBookingApp.Infrastucture.Data.Models;

namespace TaxiBookingApp.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new DriverCarConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TaxiRouteConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<TaxiRoute> TaxiRoutes { get; set; } = null!;

        public DbSet<Category> Categorieses { get; set; } = null!;

        public DbSet<DriverCar> DriversCars { get; set; } = null!;
       
      
    }
}