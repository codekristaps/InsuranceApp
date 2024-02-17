using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("107e5973-4598-438a-977a-7af29c12fe1e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("10b11420-2920-4a57-bdc2-43a9aaff3a37"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("3393d821-1f07-4cca-bfa3-cf298dc42496"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("71b9c13a-25ca-43d8-a119-3c396efb9d60"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d10cae64-b57a-40c5-b83b-8a401253e97a"));

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("186c9c47-01a3-4c61-bd9f-a7815a1ef171"), "Car Insurance" },
                    { new Guid("4955578a-4258-4f4a-b029-7d165553bc20"), "Health Insurance" },
                    { new Guid("4ed2cbb9-b496-4c60-ac46-3c8561fa5b1c"), "Travel Insurance" },
                    { new Guid("66cf8e3c-4301-45cf-975b-5743d9143384"), "Life Insurance" },
                    { new Guid("b7a6eec0-faaf-4d79-881d-20824e15dd49"), "Home Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("186c9c47-01a3-4c61-bd9f-a7815a1ef171"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4955578a-4258-4f4a-b029-7d165553bc20"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4ed2cbb9-b496-4c60-ac46-3c8561fa5b1c"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("66cf8e3c-4301-45cf-975b-5743d9143384"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b7a6eec0-faaf-4d79-881d-20824e15dd49"));

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("107e5973-4598-438a-977a-7af29c12fe1e"), "Health Insurance" },
                    { new Guid("10b11420-2920-4a57-bdc2-43a9aaff3a37"), "Car Insurance" },
                    { new Guid("3393d821-1f07-4cca-bfa3-cf298dc42496"), "Home Insurance" },
                    { new Guid("71b9c13a-25ca-43d8-a119-3c396efb9d60"), "Life Insurance" },
                    { new Guid("d10cae64-b57a-40c5-b83b-8a401253e97a"), "Travel Insurance" }
                });
        }
    }
}
