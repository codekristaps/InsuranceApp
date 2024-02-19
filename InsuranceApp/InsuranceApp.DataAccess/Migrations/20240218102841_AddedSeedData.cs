using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "InsuranceProducts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "InsuranceProducts",
                columns: new[] { "InsuranceProductId", "Description", "Discount", "ImageUrl", "InsuranceId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"), "Basic coverage for life insurance.", 10m, null, new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"), "Life Insurance - Basic", 1000m },
                    { new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"), "Premium coverage for health insurance.", 15m, null, new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"), "Health Insurance - Premium", 2000m },
                    { new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"), "Full coverage for car insurance.", 20m, null, new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"), "Car Insurance - Full Coverage", 1500m },
                    { new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"), "Comprehensive coverage for home insurance.", 10m, null, new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"), "Home Insurance - Comprehensive", 1200m },
                    { new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"), "Global coverage for travel insurance.", 15m, null, new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"), "Travel Insurance - Global", 800m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "InsuranceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
