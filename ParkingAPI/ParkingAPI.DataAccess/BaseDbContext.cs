using Microsoft.EntityFrameworkCore;
using ParkingAPI.DataAccess.Configuration;

namespace ParkingAPI.DataAccess
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParkingConfiguration());
        }
        
    }
}