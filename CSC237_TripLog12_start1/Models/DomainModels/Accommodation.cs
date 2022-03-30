﻿using System.Collections.Generic;

namespace CSC237_TripLog12_start1.Models
{
    public class Accommodation
    {
        public int AccommodationId { get; set; }              // PK 
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Trip> Trips { get; set; }          // navigation property

    }
}
