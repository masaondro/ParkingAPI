using Microsoft.EntityFrameworkCore;
using ParkingAPI.DataAccess;

namespace ParkingAPI.Migrations
{
    public class MigrationDbContext : BaseDbContext
    {
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
        {
        }
    }
}