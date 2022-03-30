using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models.DataAccess.SeedData
{
    internal class SeedTripActivity : IEntityTypeConfiguration<TripActivity>
    {
        public void Configure(EntityTypeBuilder<TripActivity> entity)
        {
            entity.HasData(
                new TripActivity { TripId = 1, ActivityId = 2 },
                new TripActivity { TripId = 1, ActivityId = 5 },
                new TripActivity { TripId = 2, ActivityId = 3 },
                new TripActivity { TripId = 2, ActivityId = 6 },
                new TripActivity { TripId = 3, ActivityId = 1 },
                new TripActivity { TripId = 3, ActivityId = 4 },
                new TripActivity { TripId = 3, ActivityId = 7 }
            );
        }
    }
}
