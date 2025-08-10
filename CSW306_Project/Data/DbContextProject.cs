using Microsoft.EntityFrameworkCore;
using CSW306_Project.Models;

namespace CSW306_Project.Data;


public class DbContextProject : DbContext
{
  
    public DbContextProject(DbContextOptions<DbContextProject> options) : base(options)
    {    
    }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Stations> Stations { get; set; }
    public DbSet<Rentals> Rentals { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<Bikes> WeatherForecasts { get; set; }
}
