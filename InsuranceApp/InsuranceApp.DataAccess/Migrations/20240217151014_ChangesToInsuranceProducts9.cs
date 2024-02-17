using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("044903ef-c860-4f00-bac6-63fe1511a2b1"), "Car Insurance" },
                    { new Guid("5b9b0fcd-7a45-437f-aa82-04bf7c5c5d02"), "Travel Insurance" },
                    { new Guid("6e63ad94-3e5f-4926-b932-a3122bab2560"), "Home Insurance" },
                    { new Guid("bb98d81e-ed99-4a4e-8a92-251ba8873270"), "Life Insurance" },
                    { new Guid("d4b551b9-f70a-4eec-b8ef-c958a562fbad"), "Health Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("044903ef-c860-4f00-bac6-63fe1511a2b1"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5b9b0fcd-7a45-437f-aa82-04bf7c5c5d02"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6e63ad94-3e5f-4926-b932-a3122bab2560"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bb98d81e-ed99-4a4e-8a92-251ba8873270"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d4b551b9-f70a-4eec-b8ef-c958a562fbad"));

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
    }
}
