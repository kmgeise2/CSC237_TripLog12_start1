using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSC237_TripLog12_start1.Models
{
    internal class TripActivityConfig : IEntityTypeConfiguration<TripActivity>
    {
        public void Configure(EntityTypeBuilder<TripActivity> entity)
        {
            // composite primary key for TripActivity
            

            // one-to-many relationship between Trip and TripActivity
            

            // one-to-many relationship between Activity and TripActivity
            
        }
    }
}
