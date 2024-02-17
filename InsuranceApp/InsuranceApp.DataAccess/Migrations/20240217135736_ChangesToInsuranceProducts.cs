using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("2a00a0af-bc9b-43b1-bf6b-9c0d9bd562ef"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("9a13cc2b-0441-4cd1-9c76-b63cbca1f698"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b3eeb614-2df9-4182-8559-702fae44ce29"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d03cc78d-0dac-42f4-826f-dd52b2601575"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("ec7c17a8-8933-4a99-8033-46a0844ce2d5"));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "InsuranceProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceProducts_InsuranceId",
                table: "InsuranceProducts",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceProducts_Insurances_InsuranceId",
                table: "InsuranceProducts",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "InsuranceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceProducts_Insurances_InsuranceId",
                table: "InsuranceProducts");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceProducts_InsuranceId",
                table: "InsuranceProducts");

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
                name: "Price",
                table: "InsuranceProducts");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("2a00a0af-bc9b-43b1-bf6b-9c0d9bd562ef"), null, "Life Insurance" },
                    { new Guid("9a13cc2b-0441-4cd1-9c76-b63cbca1f698"), null, "Car Insurance" },
                    { new Guid("b3eeb614-2df9-4182-8559-702fae44ce29"), null, "Health Insurance" },
                    { new Guid("d03cc78d-0dac-42f4-826f-dd52b2601575"), null, "Home Insurance" },
                    { new Guid("ec7c17a8-8933-4a99-8033-46a0844ce2d5"), null, "Travel Insurance" }
                });
        }
    }
}
