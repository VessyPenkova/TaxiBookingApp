using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaxiBookingApp.Infrastucture.Data.Configuration;


namespace TaxiBookingApp.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
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
            builder.ApplyConfiguration(new OfficeConfiguration());    

            base.OnModelCreating(builder);
        }

        public DbSet<TaxiRoute> TaxiRoutes { get; set; } = null!;

        public DbSet<Category> Categorieses { get; set; } = null!;

        public DbSet<DriverCar> DriversCars { get; set; } = null!;

        public DbSet<Office> Offices { get; set; } = null!;

      
    }
}