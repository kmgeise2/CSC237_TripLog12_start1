using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models
{
    internal class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> entity)
        {
            // configure foreign keys so don't use cascading delete
            entity.HasOne(t => t.Destination)
                .WithMany(d => d.Trips)
                .OnDelete(DeleteBehavior.Restrict);

            // accommodation can be null ERROR cannot be null!
            entity.HasOne(a => a.Accommodation) // 
                .WithMany(t => t.Trips) // nav property
                //.OnDelete(DeleteBehavior.SetNull);
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
