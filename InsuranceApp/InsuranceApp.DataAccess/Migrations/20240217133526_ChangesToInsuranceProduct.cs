using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("14b309dd-4981-4cac-91a4-11e10ecea4aa"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("242acf66-ca8b-48c6-9f47-a34af868f577"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("40973c9a-4d57-4aab-a54d-1ffe46431d3a"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bdabba3f-e633-493e-8db3-80583004ad8a"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("e53cb27d-69d0-49c7-9b8e-e75ee3fb7616"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InsuranceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InsuranceProducts");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("14b309dd-4981-4cac-91a4-11e10ecea4aa"), null, "Health Insurance" },
                    { new Guid("242acf66-ca8b-48c6-9f47-a34af868f577"), null, "Travel Insurance" },
                    { new Guid("40973c9a-4d57-4aab-a54d-1ffe46431d3a"), null, "Life Insurance" },
                    { new Guid("bdabba3f-e633-493e-8db3-80583004ad8a"), null, "Home Insurance" },
                    { new Guid("e53cb27d-69d0-49c7-9b8e-e75ee3fb7616"), null, "Car Insurance" }
                });
        }
    }
}
