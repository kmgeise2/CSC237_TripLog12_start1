﻿
namespace CSC237_TripLog12_start1.Models
{
    public class TripViewModel : DropDownViewModel
    {
        public Trip Trip { get; set; }
        public int PageNumber { get; set; }
        public string DestinationName { get; set; }
        public int[] SelectedActivities { get; set; }
    }
}
