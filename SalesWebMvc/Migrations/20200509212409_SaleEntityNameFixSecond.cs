using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class SaleEntityNameFixSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("SalesRecord", null, "Sales", null);
            migrationBuilder.RenameTable("Seller", null, "Sellers", null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("Sales", null, "SalesRecord", null);
            migrationBuilder.RenameTable("Sellers", null, "Seller", null);
        }
    }
}
