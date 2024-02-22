using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTotalSalesFiguresToDashboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalSalesAmount",
                table: "AdminDashboard",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSalesAmount",
                table: "AdminDashboard");
        }
    }
}
