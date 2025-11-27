using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(2892), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(2897), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(2899), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3287), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3289), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3295), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3444), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3446), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3450), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3451), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3454), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3455), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3459), new DateTime(2025, 11, 27, 13, 50, 42, 119, DateTimeKind.Local).AddTicks(3460), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
