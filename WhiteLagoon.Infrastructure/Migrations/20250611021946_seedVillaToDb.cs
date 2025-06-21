using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Villas",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Villas",
                newName: "Created_Date");

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "A luxurious villa with stunning views and modern amenities.", "https://placehold.co/600x400", "Royal Villa", 4, 200.0, 500, null },
                    { 2, null, "A beautiful villa overlooking the ocean, perfect for a relaxing getaway.", "https://placehold.co/600x401", "Ocean View Villa", 4, 300.0, 550, null },
                    { 3, null, "A serene villa nestled in the mountains, ideal for nature lovers.", "https://placehold.co/600x402", "Mountain Retreat Villa", 4, 400.0, 750, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Villas",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Villas",
                newName: "CreatedDate");
        }
    }
}
