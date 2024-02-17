using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("062039fc-c9dc-4e7c-8355-8043e2cfde74"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4bd31370-360f-49d1-bf55-c9e71e61209d"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("773f0f4e-6fd5-49d6-aec1-f71fbe7d9551"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("aa520579-46d6-4447-817b-9122076a5114"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("de436f45-1bbd-43ce-9571-24e867d7001c"));

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("58df5b5f-89c0-4c09-9f34-b6d7573ed2bf"), "Health Insurance" },
                    { new Guid("9a12af79-954d-4d7f-b9f6-f667e867cab8"), "Car Insurance" },
                    { new Guid("b8c2b5ff-9aa5-4c12-8687-bd18e633b25e"), "Life Insurance" },
                    { new Guid("d7bc407d-197f-4cbe-9635-edaab2596311"), "Home Insurance" },
                    { new Guid("fea51ffb-447d-4e0d-bb97-fa739461c296"), "Travel Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("58df5b5f-89c0-4c09-9f34-b6d7573ed2bf"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("9a12af79-954d-4d7f-b9f6-f667e867cab8"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b8c2b5ff-9aa5-4c12-8687-bd18e633b25e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d7bc407d-197f-4cbe-9635-edaab2596311"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("fea51ffb-447d-4e0d-bb97-fa739461c296"));

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("062039fc-c9dc-4e7c-8355-8043e2cfde74"), "Car Insurance" },
                    { new Guid("4bd31370-360f-49d1-bf55-c9e71e61209d"), "Travel Insurance" },
                    { new Guid("773f0f4e-6fd5-49d6-aec1-f71fbe7d9551"), "Health Insurance" },
                    { new Guid("aa520579-46d6-4447-817b-9122076a5114"), "Home Insurance" },
                    { new Guid("de436f45-1bbd-43ce-9571-24e867d7001c"), "Life Insurance" }
                });
        }
    }
}
