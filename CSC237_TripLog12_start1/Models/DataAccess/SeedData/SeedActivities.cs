using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models.DataAccess.SeedData
{
    internal class SeedActivities : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> entity)
        {
            entity.HasData(
                new Activity { ActivityId = 1, Name = "Cross country skiing" },
                new Activity { ActivityId = 2, Name = "Go to Grand Central Station" },
                new Activity { ActivityId = 3, Name = "Hiking" },
                new Activity { ActivityId = 4, Name = "Ice skate" },
                new Activity { ActivityId = 5, Name = "Ride the subway" },
                new Activity { ActivityId = 6, Name = "Swimming" },
                new Activity { ActivityId = 7, Name = "Walk in the snow" }
            );
        }
    }
}
