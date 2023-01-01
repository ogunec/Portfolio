using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.DAL.Migrations
{
    public partial class addPropertyToAbout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Abouts");
        }
    }
}
