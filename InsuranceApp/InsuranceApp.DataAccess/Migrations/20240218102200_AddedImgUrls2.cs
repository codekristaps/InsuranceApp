using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImgUrls2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "InsuranceId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"), null, "Home Insurance" },
                    { new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"), null, "Health Insurance" },
                    { new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"), null, "Car Insurance" },
                    { new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"), null, "Travel Insurance" },
                    { new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"), null, "Life Insurance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"));

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"));

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
    }
}
