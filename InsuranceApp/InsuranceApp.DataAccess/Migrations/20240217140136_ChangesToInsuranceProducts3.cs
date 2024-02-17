using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "InsuranceCustomerId", "Name" },
                values: new object[,]
                {
                    { new Guid("167f0522-744a-4e5b-b214-f9e9861f9a45"), null, "Travel Insurance" },
                    { new Guid("318109d4-0d4c-49a5-b77a-2e6abd25f7a5"), null, "Home Insurance" },
                    { new Guid("4fc20864-d762-4039-b944-e4449d255556"), null, "Car Insurance" },
                    { new Guid("be887af7-0724-4681-9de2-13a3c0202f1e"), null, "Life Insurance" },
                    { new Guid("e39ff992-c8d4-439d-b382-8894a91baf6f"), null, "Health Insurance" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceProducts_ProductId",
                table: "InsuranceProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceProducts_Products_ProductId",
                table: "InsuranceProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceProducts_Products_ProductId",
                table: "InsuranceProducts");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceProducts_ProductId",
                table: "InsuranceProducts");

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("167f0522-744a-4e5b-b214-f9e9861f9a45"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("318109d4-0d4c-49a5-b77a-2e6abd25f7a5"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4fc20864-d762-4039-b944-e4449d255556"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("be887af7-0724-4681-9de2-13a3c0202f1e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("e39ff992-c8d4-439d-b382-8894a91baf6f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
    }
}
