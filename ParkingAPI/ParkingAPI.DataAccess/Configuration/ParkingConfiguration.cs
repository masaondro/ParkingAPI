using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ParkingAPI.Domain.Entities;

namespace ParkingAPI.DataAccess.Configuration
{
    public class ParkingConfiguration : IEntityTypeConfiguration<Parking>
    {
        public void Configure(EntityTypeBuilder<Parking> builder)
        {
            builder.ToTable(nameof(Parking));

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}