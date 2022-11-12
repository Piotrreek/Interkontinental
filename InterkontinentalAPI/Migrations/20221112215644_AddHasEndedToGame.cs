using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterkontinentalAPI.Migrations
{
    public partial class AddHasEndedToGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasEnded",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasEnded",
                table: "Games");
        }
    }
}
