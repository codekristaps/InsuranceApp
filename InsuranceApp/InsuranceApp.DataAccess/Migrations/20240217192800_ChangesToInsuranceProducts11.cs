using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToInsuranceProducts11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsuranceInsuranceProduct");

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("044903ef-c860-4f00-bac6-63fe1511a2b1"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5b9b0fcd-7a45-437f-aa82-04bf7c5c5d02"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6e63ad94-3e5f-4926-b932-a3122bab2560"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("bb98d81e-ed99-4a4e-8a92-251ba8873270"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d4b551b9-f70a-4eec-b8ef-c958a562fbad"));

            migrationBuilder.DropColumn(
                name: "Type",
                table: "InsuranceProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "InsuranceId",
                table: "InsuranceProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("09f606a9-aa03-4ba7-8a14-d3a21cb2164f"), "Car Insurance" },
                    { new Guid("af65b1bf-9212-4e4e-b7ef-5314fe06e1fc"), "Travel Insurance" },
                    { new Guid("b274db54-43a4-4146-881b-014913817b2c"), "Life Insurance" },
                    { new Guid("b37e64cc-0e8b-46b3-83b9-d66753476c43"), "Home Insurance" },
                    { new Guid("b8ed5110-5296-43f4-9093-dcfb4a7b63bc"), "Health Insurance" }
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
                principalColumn: "InsuranceId",
                onDelete: ReferentialAction.Cascade);
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
                keyValue: new Guid("09f606a9-aa03-4ba7-8a14-d3a21cb2164f"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("af65b1bf-9212-4e4e-b7ef-5314fe06e1fc"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b274db54-43a4-4146-881b-014913817b2c"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b37e64cc-0e8b-46b3-83b9-d66753476c43"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b8ed5110-5296-43f4-9093-dcfb4a7b63bc"));

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "InsuranceProducts");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "InsuranceProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Insurances",
                columns: new[] { "InsuranceId", "Name" },
                values: new object[,]
                {
                    { new Guid("044903ef-c860-4f00-bac6-63fe1511a2b1"), "Car Insurance" },
                    { new Guid("5b9b0fcd-7a45-437f-aa82-04bf7c5c5d02"), "Travel Insurance" },
                    { new Guid("6e63ad94-3e5f-4926-b932-a3122bab2560"), "Home Insurance" },
                    { new Guid("bb98d81e-ed99-4a4e-8a92-251ba8873270"), "Life Insurance" },
                    { new Guid("d4b551b9-f70a-4eec-b8ef-c958a562fbad"), "Health Insurance" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceInsuranceProduct_InsurancesInsuranceId",
                table: "InsuranceInsuranceProduct",
                column: "InsurancesInsuranceId");
        }
    }
}
