using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("09f606a9-aa03-4ba7-8a14-d3a21cb2164f"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("af65b1bf-9212-4e4e-b7ef-5314fe06e1fc"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b274db54-43a4-4146-881b-014913817b2c"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b37e64cc-0e8b-46b3-83b9-d66753476c43"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b8ed5110-5296-43f4-9093-dcfb4a7b63bc"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("09f606a9-aa03-4ba7-8a14-d3a21cb2164f"), "Car Insurance" },
                    { new Guid("af65b1bf-9212-4e4e-b7ef-5314fe06e1fc"), "Travel Insurance" },
                    { new Guid("b274db54-43a4-4146-881b-014913817b2c"), "Life Insurance" },
                    { new Guid("b37e64cc-0e8b-46b3-83b9-d66753476c43"), "Home Insurance" },
                    { new Guid("b8ed5110-5296-43f4-9093-dcfb4a7b63bc"), "Health Insurance" }
                });
        }
    }
}
