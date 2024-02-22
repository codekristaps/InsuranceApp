using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedSalesGrowthFunctionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GrowthRate",
                table: "AdminDashboard",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "TotalSalesLastMonth",
                table: "AdminDashboard",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrowthRate",
                table: "AdminDashboard");

            migrationBuilder.DropColumn(
                name: "TotalSalesLastMonth",
                table: "AdminDashboard");
        }
    }
}
