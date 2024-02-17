using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceProducts_Insurances_InsuranceId",
                table: "InsuranceProducts");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceProducts_InsuranceId",
                table: "InsuranceProducts");

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
                name: "InsuranceId",
                table: "InsuranceProducts");

            migrationBuilder.CreateTable(
                name: "InsuranceInsuranceProduct",
                columns: table => new
                {
                    InsuranceProductsInsuranceProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsurancesInsuranceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceInsuranceProduct", x => new { x.InsuranceProductsInsuranceProductId, x.InsurancesInsuranceId });
                    table.ForeignKey(
                        name: "FK_InsuranceInsuranceProduct_InsuranceProducts_InsuranceProductsInsuranceProductId",
                        column: x => x.InsuranceProductsInsuranceProductId,
                        principalTable: "InsuranceProducts",
                        principalColumn: "InsuranceProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsuranceInsuranceProduct_Insurances_InsurancesInsuranceId",
                        column: x => x.InsurancesInsuranceId,
                        principalTable: "Insurances",
                        principalColumn: "InsuranceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InsuranceProducts",
                columns: new[] { "InsuranceProductId", "Description", "Discount", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { new Guid("15313a63-32ac-4c24-a435-fc837135684f"), "This is a travel insurance product.", 50.00m, "Travel Insurance Product", 500.00m, 4 },
                    { new Guid("6653580a-26dd-4d3b-987e-e691544d1429"), "This is a home insurance product.", 40.00m, "Home Insurance Product", 400.00m, 3 },
                    { new Guid("79acbf17-6d8c-453d-bd1e-c80c580dea9b"), "This is a life insurance product.", 10.00m, "Life Insurance Product", 100.00m, 0 },
                    { new Guid("8010145d-8d70-4422-a1e0-2f2ad013fc95"), "This is a health insurance product.", 20.00m, "Health Insurance Product", 200.00m, 1 },
                    { new Guid("da411237-6a05-4f65-91fd-ce4fa867585e"), "This is a car insurance product.", 30.00m, "Car Insurance Product", 300.00m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("2137da24-d61f-4357-ae97-ee9f7a27b391"), "Home Insurance" },
                    { new Guid("31d68f1f-b0e5-4d20-ba00-ebe2fb6a4258"), "Life Insurance" },
                    { new Guid("bc809bfb-89d9-4dbd-85f1-e923a578c612"), "Health Insurance" },
                    { new Guid("df852593-8164-47cc-8b53-f4297206e197"), "Car Insurance" },
                    { new Guid("f08044ce-500f-4d49-93f4-3866ce01e611"), "Travel Insurance" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceInsuranceProduct_InsurancesInsuranceId",
                table: "InsuranceInsuranceProduct",
                column: "InsurancesInsuranceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsuranceInsuranceProduct");

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("15313a63-32ac-4c24-a435-fc837135684f"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("6653580a-26dd-4d3b-987e-e691544d1429"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("79acbf17-6d8c-453d-bd1e-c80c580dea9b"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("8010145d-8d70-4422-a1e0-2f2ad013fc95"));

            migrationBuilder.DeleteData(
                table: "InsuranceProducts",
                keyColumn: "InsuranceProductId",
                keyValue: new Guid("da411237-6a05-4f65-91fd-ce4fa867585e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("2137da24-d61f-4357-ae97-ee9f7a27b391"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("31d68f1f-b0e5-4d20-ba00-ebe2fb6a4258"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bc809bfb-89d9-4dbd-85f1-e923a578c612"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("df852593-8164-47cc-8b53-f4297206e197"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("f08044ce-500f-4d49-93f4-3866ce01e611"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsuranceId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
