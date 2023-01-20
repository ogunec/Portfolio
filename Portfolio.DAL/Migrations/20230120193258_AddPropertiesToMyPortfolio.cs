using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.DAL.Migrations
{
    public partial class AddPropertiesToMyPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Progress",
                table: "MyPortfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "MyPortfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progress",
                table: "MyPortfolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MyPortfolios");
        }
    }
}
