using Microsoft.EntityFrameworkCore;
using CSC237_TripLog12_start1.Models.DataAccess.SeedData;

namespace CSC237_TripLog12_start1.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new TripActivityConfig());
            modelBuilder.ApplyConfiguration(new SeedAccommodation());
            modelBuilder.ApplyConfiguration(new SeedActivities());
            modelBuilder.ApplyConfiguration(new SeedDestination());
            modelBuilder.ApplyConfiguration(new SeedTrips());
            modelBuilder.ApplyConfiguration(new SeedTripActivity());
        }

    }
}
