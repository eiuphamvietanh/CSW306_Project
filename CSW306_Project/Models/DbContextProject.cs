using Microsoft.EntityFrameworkCore;

namespace CSW306_Project.Models
{
    public class DbContextProject : DbContext
    {
      
        public DbContextProject(DbContextOptions<DbContextProject> options) : base(options)
        {    
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bike> WeatherForecasts { get; set; }
    }
}
