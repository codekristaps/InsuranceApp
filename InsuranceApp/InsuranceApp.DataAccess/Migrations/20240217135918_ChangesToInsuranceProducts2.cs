using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("36f48657-1440-4137-a22a-1f2e3e3aa387"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("55bc37dd-dead-4228-bcf7-a2c7a81707d1"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("a52afbfc-1954-4801-b84c-8a8e2ca7ae68"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("c3715fa8-3519-4218-b893-6c9c091a9eb6"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d8a870f1-39b3-4c31-8c90-013cdd5428c4"));

            migrationBuilder.DropColumn(
                name: "InsuranceCustomerId",
                table: "InsuranceProducts");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0f0378fa-2d2e-4348-a726-1baa469d54fc"), null, "Travel Insurance" },
                    { new Guid("4d9f3fd6-32cd-48bd-8f1b-88eb09db7b14"), null, "Car Insurance" },
                    { new Guid("9c23aaa1-9d58-4b01-a7f1-d9c56ebc101e"), null, "Life Insurance" },
                    { new Guid("d369acac-dba9-45f4-9eef-2027cb1da8c4"), null, "Health Insurance" },
                    { new Guid("e3476205-a25b-4b61-a444-56b098cb66f9"), null, "Home Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("0f0378fa-2d2e-4348-a726-1baa469d54fc"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4d9f3fd6-32cd-48bd-8f1b-88eb09db7b14"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("9c23aaa1-9d58-4b01-a7f1-d9c56ebc101e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d369acac-dba9-45f4-9eef-2027cb1da8c4"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("e3476205-a25b-4b61-a444-56b098cb66f9"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsuranceCustomerId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("36f48657-1440-4137-a22a-1f2e3e3aa387"), null, "Car Insurance" },
                    { new Guid("55bc37dd-dead-4228-bcf7-a2c7a81707d1"), null, "Health Insurance" },
                    { new Guid("a52afbfc-1954-4801-b84c-8a8e2ca7ae68"), null, "Life Insurance" },
                    { new Guid("c3715fa8-3519-4218-b893-6c9c091a9eb6"), null, "Travel Insurance" },
                    { new Guid("d8a870f1-39b3-4c31-8c90-013cdd5428c4"), null, "Home Insurance" }
                });
        }
    }
}
