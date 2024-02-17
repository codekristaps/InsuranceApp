using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6fed97cb-f2a6-4231-a73d-d6897245d921"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("7cb624eb-5da2-46e9-a260-7a5bd07b8163"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("c4e7383e-26df-4dde-bbbe-5f704e5246ab"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d1c39a3f-362b-4ae6-953e-13200050840b"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("ea95ab7a-d8dd-4b73-a797-198c1c0d67d1"));

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("6fed97cb-f2a6-4231-a73d-d6897245d921"), null, "Health Insurance" },
                    { new Guid("7cb624eb-5da2-46e9-a260-7a5bd07b8163"), null, "Travel Insurance" },
                    { new Guid("c4e7383e-26df-4dde-bbbe-5f704e5246ab"), null, "Life Insurance" },
                    { new Guid("d1c39a3f-362b-4ae6-953e-13200050840b"), null, "Car Insurance" },
                    { new Guid("ea95ab7a-d8dd-4b73-a797-198c1c0d67d1"), null, "Home Insurance" }
                });
        }
    }
}
