using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterkontinentalAPI.Migrations
{
    public partial class ChangeSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 17,
                column: "Type",
                value: "Szansy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 29,
                column: "Type",
                value: "Szansy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 38,
                column: "Type",
                value: "Egipt");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43,
                column: "Type",
                value: "Szansy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 17,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 29,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 38,
                column: "Type",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43,
                column: "Type",
                value: "Inne");
        }
    }
}
