using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models.DataAccess.SeedData 
{
    internal class SeedTrips : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> entity)
        {
            entity.HasData(
                
                new Trip 
                { 
                    TripId = 1, 
                    DestinationId = 3,  
                    StartDate= new DateTime(2020, 10, 25), 
                    EndDate = new DateTime(2020, 11, 1), 
                    AccommodationId = 3 
                },
                // StartDate = 7/2/2020, EndDate = 7/9/2020
                new Trip 
                { 
                    TripId = 2, 
                    DestinationId = 2, 
                    StartDate = new DateTime(2020, 7, 2), 
                    EndDate = new DateTime(2020, 7, 9), 
                    AccommodationId = 1 
                },
                // StartDate = 2/15/2021, EndDate = 2/21/2021
                new Trip 
                { 
                    TripId = 3, 
                    DestinationId = 1, 
                    StartDate = new DateTime(2021, 2, 15), 
                    EndDate = new DateTime(2021, 2, 21), 
                    AccommodationId = 2 
                }
            );
        }
    }
}
