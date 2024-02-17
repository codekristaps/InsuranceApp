using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("2fe33c73-75ef-4893-ae84-08cf96cf61cc"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4e42b4e5-0f0a-4d04-915d-a7f69e4ff20f"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5d7089aa-0e2e-46e5-a3e2-d7e36c1d114c"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("cc7b639d-d537-4314-ba23-ddd8e167cd9f"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("e84b7d82-1a31-4130-9a62-e9b83c9f80f8"));

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("2fe33c73-75ef-4893-ae84-08cf96cf61cc"), null, "Home Insurance" },
                    { new Guid("4e42b4e5-0f0a-4d04-915d-a7f69e4ff20f"), null, "Car Insurance" },
                    { new Guid("5d7089aa-0e2e-46e5-a3e2-d7e36c1d114c"), null, "Travel Insurance" },
                    { new Guid("cc7b639d-d537-4314-ba23-ddd8e167cd9f"), null, "Health Insurance" },
                    { new Guid("e84b7d82-1a31-4130-9a62-e9b83c9f80f8"), null, "Life Insurance" }
                });
        }
    }
}
