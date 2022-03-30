using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_TripLog12_start1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accommodations",
                columns: table => new
                {
                    AccommodationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodations", x => x.AccommodationId);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    AccommodationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trips_Accommodations_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodations",
                        principalColumn: "AccommodationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trips_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripActivity",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false),
                    ActivityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripActivity", x => new { x.TripId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_TripActivity_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripActivity_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accommodations",
                columns: new[] { "AccommodationId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "", "Camping", "" },
                    { 2, "thelodge@whitefish.com", "The Lodge at Whitefish Lake", "" },
                    { 3, "contact@staybridgesuites.com", "Staybridge Suites", "555-123-9876" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Name" },
                values: new object[,]
                {
                    { 1, "Cross country skiing" },
                    { 2, "Go to Grand Central Station" },
                    { 3, "Hiking" },
                    { 4, "Ice skate" },
                    { 5, "Ride the subway" },
                    { 6, "Swimming" },
                    { 7, "Walk in the snow" }
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Name" },
                values: new object[,]
                {
                    { 1, "Whitefish Montana" },
                    { 2, "Olympic Peninnsula" },
                    { 3, "New York" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationId", "DestinationId", "EndDate", "StartDate" },
                values: new object[] { 3, 2, 1, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationId", "DestinationId", "EndDate", "StartDate" },
                values: new object[] { 2, 1, 2, new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AccommodationId", "DestinationId", "EndDate", "StartDate" },
                values: new object[] { 1, 3, 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TripActivity",
                columns: new[] { "TripId", "ActivityId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 7 },
                    { 2, 3 },
                    { 2, 6 },
                    { 1, 2 },
                    { 1, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripActivity_ActivityId",
                table: "TripActivity",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_AccommodationId",
                table: "Trips",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_DestinationId",
                table: "Trips",
                column: "DestinationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripActivity");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Accommodations");

            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
