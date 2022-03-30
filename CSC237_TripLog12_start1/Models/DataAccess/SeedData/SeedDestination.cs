using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models.DataAccess.SeedData
{
    internal class SeedDestination : IEntityTypeConfiguration<Destination> 
    {
        public void Configure(EntityTypeBuilder<Destination> entity)
        {
            entity.HasData(
                new Destination { DestinationId = 1, Name = "Whitefish Montana" },
                new Destination { DestinationId = 2, Name = "Olympic Peninnsula" },
                new Destination { DestinationId = 3, Name = "New York" }
            );
        }

    }
}
