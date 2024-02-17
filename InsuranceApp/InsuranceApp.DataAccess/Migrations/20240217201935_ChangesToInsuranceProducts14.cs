using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"), "Home Insurance" },
                    { new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"), "Health Insurance" },
                    { new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"), "Car Insurance" },
                    { new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"), "Travel Insurance" },
                    { new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"), "Life Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"));

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
    }
}
