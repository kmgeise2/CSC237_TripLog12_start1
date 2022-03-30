using System.Collections.Generic;

namespace CSC237_TripLog12_start1.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }           // PK 
        public string Name { get; set; }

        public ICollection<Trip> Trips { get; set; }     // navigation property
    }
}
