using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models.DataAccess.SeedData
{
    internal class SeedAccommodation : IEntityTypeConfiguration<Accommodation>
    {
        public void Configure(EntityTypeBuilder<Accommodation> entity)
        {
            entity.HasData(
                new Accommodation { AccommodationId = 1, Name = "Camping", Phone = "", Email = ""},
                new Accommodation { AccommodationId = 2, Name = "The Lodge at Whitefish Lake", Phone = "", Email = "thelodge@whitefish.com" },
                new Accommodation { AccommodationId = 3, Name = "Staybridge Suites", Phone = "555-123-9876", Email = "contact@staybridgesuites.com" }
            );
        }
    }
}
