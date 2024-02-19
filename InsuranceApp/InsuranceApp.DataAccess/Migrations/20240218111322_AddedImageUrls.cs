using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"),
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/35160/pexels-photo.jpg?auto=compress&cs=tinysrgb&w=600");

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"),
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1346347/pexels-photo-1346347.jpeg?auto=compress&cs=tinysrgb&w=600");

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"),
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/2262628/pexels-photo-2262628.jpeg?auto=compress&cs=tinysrgb&w=600");

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"),
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/9646747/pexels-photo-9646747.jpeg?auto=compress&cs=tinysrgb&w=600");

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"),
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/1076240/pexels-photo-1076240.jpeg?auto=compress&cs=tinysrgb&w=600");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"),
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"),
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"),
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"),
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"),
                column: "ImageUrl",
                value: null);
        }
    }
}
