// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CSC237_TripLog12_start1.Models;

namespace CSC237_TripLog12_start1.Migrations
{
    [DbContext(typeof(TripLogContext))]
    [Migration("20220329003455_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripLog12_start1.Models.Accommodation", b =>
                {
                    b.Property<int>("AccommodationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccommodationId");

                    b.ToTable("Accommodations");

                    b.HasData(
                        new
                        {
                            AccommodationId = 1,
                            Email = "",
                            Name = "Camping",
                            Phone = ""
                        },
                        new
                        {
                            AccommodationId = 2,
                            Email = "thelodge@whitefish.com",
                            Name = "The Lodge at Whitefish Lake",
                            Phone = ""
                        },
                        new
                        {
                            AccommodationId = 3,
                            Email = "contact@staybridgesuites.com",
                            Name = "Staybridge Suites",
                            Phone = "555-123-9876"
                        });
                });

            modelBuilder.Entity("TripLog12_start1.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            ActivityId = 1,
                            Name = "Cross country skiing"
                        },
                        new
                        {
                            ActivityId = 2,
                            Name = "Go to Grand Central Station"
                        },
                        new
                        {
                            ActivityId = 3,
                            Name = "Hiking"
                        },
                        new
                        {
                            ActivityId = 4,
                            Name = "Ice skate"
                        },
                        new
                        {
                            ActivityId = 5,
                            Name = "Ride the subway"
                        },
                        new
                        {
                            ActivityId = 6,
                            Name = "Swimming"
                        },
                        new
                        {
                            ActivityId = 7,
                            Name = "Walk in the snow"
                        });
                });

            modelBuilder.Entity("TripLog12_start1.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Name = "Whitefish Montana"
                        },
                        new
                        {
                            DestinationId = 2,
                            Name = "Olympic Peninnsula"
                        },
                        new
                        {
                            DestinationId = 3,
                            Name = "New York"
                        });
                });

            modelBuilder.Entity("TripLog12_start1.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccommodationId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("TripId");

                    b.HasIndex("AccommodationId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            AccommodationId = 3,
                            DestinationId = 3,
                            EndDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 2,
                            AccommodationId = 1,
                            DestinationId = 2,
                            EndDate = new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 3,
                            AccommodationId = 2,
                            DestinationId = 1,
                            EndDate = new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TripLog12_start1.Models.TripActivity", b =>
                {
                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.HasKey("TripId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("TripActivity");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            ActivityId = 2
                        },
                        new
                        {
                            TripId = 1,
                            ActivityId = 5
                        },
                        new
                        {
                            TripId = 2,
                            ActivityId = 3
                        },
                        new
                        {
                            TripId = 2,
                            ActivityId = 6
                        },
                        new
                        {
                            TripId = 3,
                            ActivityId = 1
                        },
                        new
                        {
                            TripId = 3,
                            ActivityId = 4
                        },
                        new
                        {
                            TripId = 3,
                            ActivityId = 7
                        });
                });

            modelBuilder.Entity("TripLog12_start1.Models.Trip", b =>
                {
                    b.HasOne("TripLog12_start1.Models.Accommodation", "Accommodation")
                        .WithMany("Trips")
                        .HasForeignKey("AccommodationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TripLog12_start1.Models.Destination", "Destination")
                        .WithMany("Trips")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("TripLog12_start1.Models.TripActivity", b =>
                {
                    b.HasOne("TripLog12_start1.Models.Activity", "Activity")
                        .WithMany("TripActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripLog12_start1.Models.Trip", "Trip")
                        .WithMany("TripActivities")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
