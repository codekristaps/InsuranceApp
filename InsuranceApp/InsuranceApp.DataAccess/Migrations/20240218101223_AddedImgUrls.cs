using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImgUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("22a7d4e0-ed92-4dec-97ac-b02358dac48e"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4af3cf88-6006-420a-8232-f4f60cfb7f30"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("81073022-06cc-4198-aae0-ca98a4af96fa"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("d5463621-0cc5-4d1b-9bee-17ef002552a3"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("f88cd8dd-9fd7-4c15-94ee-4492fae54cec"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "InsuranceProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("0ad449db-050d-4ef9-8fd3-c9cb4d7e265d"), null, "Travel Insurance" },
                    { new Guid("1ee9d86f-a142-43bf-bb55-ac9623f72ea1"), null, "Health Insurance" },
                    { new Guid("2be2aadc-21a2-493e-b70b-3de475ec6a66"), null, "Life Insurance" },
                    { new Guid("e2fc2134-650e-4f7d-aa26-edfbea92386f"), null, "Home Insurance" },
                    { new Guid("f9621a8c-08e6-46c9-8819-a5fb8b73f38c"), null, "Car Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("0ad449db-050d-4ef9-8fd3-c9cb4d7e265d"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("1ee9d86f-a142-43bf-bb55-ac9623f72ea1"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("2be2aadc-21a2-493e-b70b-3de475ec6a66"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("e2fc2134-650e-4f7d-aa26-edfbea92386f"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("f9621a8c-08e6-46c9-8819-a5fb8b73f38c"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "InsuranceProducts");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("22a7d4e0-ed92-4dec-97ac-b02358dac48e"), null, "Life Insurance" },
                    { new Guid("4af3cf88-6006-420a-8232-f4f60cfb7f30"), null, "Travel Insurance" },
                    { new Guid("81073022-06cc-4198-aae0-ca98a4af96fa"), null, "Health Insurance" },
                    { new Guid("d5463621-0cc5-4d1b-9bee-17ef002552a3"), null, "Home Insurance" },
                    { new Guid("f88cd8dd-9fd7-4c15-94ee-4492fae54cec"), null, "Car Insurance" }
                });
        }
    }
}
