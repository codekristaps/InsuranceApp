using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsuranceChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Insurances");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Insurances",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"),
                column: "Discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"),
                column: "Discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"),
                column: "Discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"),
                column: "Discount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "InsuranceId",
                keyValue: new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"),
                column: "Discount",
                value: null);
        }
    }
}
