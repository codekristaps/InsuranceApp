using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceProducts_Products_ProductId",
                table: "InsuranceProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_AspNetUsers_InsuranceCustomerId",
                table: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_InsuranceCustomerId",
                table: "Insurances");

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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InsuranceCustomerId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "InsuranceProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InsuranceProductId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "InsuranceProducts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InsuranceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "InsuranceProducts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "InsuranceProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "InsuranceProducts",
                columns: new[] { "InsuranceProductId", "Description", "Discount", "InsuranceId", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("1bf50c1e-2a9d-4c93-8695-1b3344b4dba5"), "This is a travel insurance product.", 50.00m, null, "Travel Insurance Product", 500.00m, 4 },
                    { new Guid("2f82e61d-9f28-49ad-afef-12fcdf25d7ab"), "This is a home insurance product.", 40.00m, null, "Home Insurance Product", 400.00m, 3 },
                    { new Guid("3d5628f5-5a27-4124-a7bc-f8cec48c6bd6"), "This is a health insurance product.", 20.00m, null, "Health Insurance Product", 200.00m, 1 },
                    { new Guid("9fce6576-bed5-4f82-bb2b-9a1c61fbad5f"), "This is a car insurance product.", 30.00m, null, "Car Insurance Product", 300.00m, 2 },
                    { new Guid("f5779c22-090a-4fa3-8f86-bf5df634d5f2"), "This is a life insurance product.", 10.00m, null, "Life Insurance Product", 100.00m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("0193d932-e602-4580-8ebd-b0fab680ac3c"), "Home Insurance" },
                    { new Guid("1513a987-519f-4670-9520-ad6c1c58b632"), "Travel Insurance" },
                    { new Guid("40bbc986-b9f8-4ecb-85f3-a0bf5ec34da6"), "Car Insurance" },
                    { new Guid("c436d750-b2db-4f67-8315-c6e93c154d0e"), "Health Insurance" },
                    { new Guid("cb65094c-9548-4e03-984c-9cf6c4dfa4c1"), "Life Insurance" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerId1",
                table: "Products",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InsuranceProductId",
                table: "Products",
                column: "InsuranceProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_CustomerId1",
                table: "Products",
                column: "CustomerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_InsuranceProducts_InsuranceProductId",
                table: "Products",
                column: "InsuranceProductId",
                principalTable: "InsuranceProducts",
                principalColumn: "InsuranceProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_CustomerId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_InsuranceProducts_InsuranceProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CustomerId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_InsuranceProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("1bf50c1e-2a9d-4c93-8695-1b3344b4dba5"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("2f82e61d-9f28-49ad-afef-12fcdf25d7ab"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("3d5628f5-5a27-4124-a7bc-f8cec48c6bd6"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("9fce6576-bed5-4f82-bb2b-9a1c61fbad5f"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("f5779c22-090a-4fa3-8f86-bf5df634d5f2"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("0193d932-e602-4580-8ebd-b0fab680ac3c"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("1513a987-519f-4670-9520-ad6c1c58b632"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("40bbc986-b9f8-4ecb-85f3-a0bf5ec34da6"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("c436d750-b2db-4f67-8315-c6e93c154d0e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("cb65094c-9548-4e03-984c-9cf6c4dfa4c1"));

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InsuranceProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "InsuranceProducts");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "InsuranceProducts");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "InsuranceProducts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceCustomerId",
                table: "Insurances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "InsuranceProducts",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Insurances_InsuranceCustomerId",
                table: "Insurances",
                column: "InsuranceCustomerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_AspNetUsers_InsuranceCustomerId",
                table: "Insurances",
                column: "InsuranceCustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
