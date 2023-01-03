using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.DAL.Migrations
{
    public partial class addTwoPropertiesToMyPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectUrl",
                table: "MyPortfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SmallImageUrl",
                table: "MyPortfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectUrl",
                table: "MyPortfolios");

            migrationBuilder.DropColumn(
                name: "SmallImageUrl",
                table: "MyPortfolios");
        }
    }
}
