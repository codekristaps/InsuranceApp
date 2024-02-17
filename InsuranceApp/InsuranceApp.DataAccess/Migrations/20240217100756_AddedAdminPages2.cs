using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminPages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("33a636c2-0673-492c-a8fd-d6acbce807ba"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("72db4f1c-5e2e-4249-8a56-f3e95212fa2e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("84ba61d3-02ac-4cb8-8249-3ad70cc7fe94"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("8e08b2c1-d322-4c2c-afd2-7d224db49c39"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bac29fce-7b58-4d2e-92ef-f55d04c6b467"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("33a636c2-0673-492c-a8fd-d6acbce807ba"), null, "Home Insurance" },
                    { new Guid("72db4f1c-5e2e-4249-8a56-f3e95212fa2e"), null, "Travel Insurance" },
                    { new Guid("84ba61d3-02ac-4cb8-8249-3ad70cc7fe94"), null, "Life Insurance" },
                    { new Guid("8e08b2c1-d322-4c2c-afd2-7d224db49c39"), null, "Health Insurance" },
                    { new Guid("bac29fce-7b58-4d2e-92ef-f55d04c6b467"), null, "Car Insurance" }
                });
        }
    }
}
