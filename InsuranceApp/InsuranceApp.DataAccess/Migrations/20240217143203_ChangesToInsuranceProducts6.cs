using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("15313a63-32ac-4c24-a435-fc837135684f"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("6653580a-26dd-4d3b-987e-e691544d1429"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("79acbf17-6d8c-453d-bd1e-c80c580dea9b"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("8010145d-8d70-4422-a1e0-2f2ad013fc95"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("da411237-6a05-4f65-91fd-ce4fa867585e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("2137da24-d61f-4357-ae97-ee9f7a27b391"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("31d68f1f-b0e5-4d20-ba00-ebe2fb6a4258"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bc809bfb-89d9-4dbd-85f1-e923a578c612"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("df852593-8164-47cc-8b53-f4297206e197"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("f08044ce-500f-4d49-93f4-3866ce01e611"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsuranceProducts",
                columns: new[] { "InsuranceProductId", "Description", "Discount", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("15313a63-32ac-4c24-a435-fc837135684f"), "This is a travel insurance product.", 50.00m, "Travel Insurance Product", 500.00m, 4 },
                    { new Guid("6653580a-26dd-4d3b-987e-e691544d1429"), "This is a home insurance product.", 40.00m, "Home Insurance Product", 400.00m, 3 },
                    { new Guid("79acbf17-6d8c-453d-bd1e-c80c580dea9b"), "This is a life insurance product.", 10.00m, "Life Insurance Product", 100.00m, 0 },
                    { new Guid("8010145d-8d70-4422-a1e0-2f2ad013fc95"), "This is a health insurance product.", 20.00m, "Health Insurance Product", 200.00m, 1 },
                    { new Guid("da411237-6a05-4f65-91fd-ce4fa867585e"), "This is a car insurance product.", 30.00m, "Car Insurance Product", 300.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("2137da24-d61f-4357-ae97-ee9f7a27b391"), "Home Insurance" },
                    { new Guid("31d68f1f-b0e5-4d20-ba00-ebe2fb6a4258"), "Life Insurance" },
                    { new Guid("bc809bfb-89d9-4dbd-85f1-e923a578c612"), "Health Insurance" },
                    { new Guid("df852593-8164-47cc-8b53-f4297206e197"), "Car Insurance" },
                    { new Guid("f08044ce-500f-4d49-93f4-3866ce01e611"), "Travel Insurance" }
                });
        }
    }
}
