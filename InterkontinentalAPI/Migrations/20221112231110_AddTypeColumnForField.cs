using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterkontinentalAPI.Migrations
{
    public partial class AddTypeColumnForField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Czechy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Czechy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Czechy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Szansy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "Koleje");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "Ukraina");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 9,
                column: "Type",
                value: "Ukraina");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11,
                column: "Type",
                value: "Ukraina");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12,
                column: "Type",
                value: "Watykan");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 14,
                column: "Type",
                value: "Polska");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 15,
                column: "Type",
                value: "Polska");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 16,
                column: "Type",
                value: "Polska");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 17,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 18,
                column: "Type",
                value: "Koleje");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 19,
                column: "Type",
                value: "Polska");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20,
                column: "Type",
                value: "Niemcy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21,
                column: "Type",
                value: "Niemcy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22,
                column: "Type",
                value: "Niemcy");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24,
                column: "Type",
                value: "Rosja");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 25,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 26,
                column: "Type",
                value: "Rosja");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 27,
                column: "Type",
                value: "Rosja");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 28,
                column: "Type",
                value: "Ameryka");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 29,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30,
                column: "Type",
                value: "Koleje");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31,
                column: "Type",
                value: "Ameryka");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33,
                column: "Type",
                value: "Ameryka");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 34,
                column: "Type",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 35,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 36,
                column: "Type",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 37,
                column: "Type",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 38,
                column: "Type",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 39,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40,
                column: "Type",
                value: "Egipt");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41,
                column: "Type",
                value: "Egipt");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42,
                column: "Type",
                value: "Bogate");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 44,
                column: "Type",
                value: "Koleje");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 45,
                column: "Type",
                value: "Bogate");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 46,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 47,
                column: "Type",
                value: "Dziwne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 48,
                column: "Type",
                value: "Inne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 49,
                column: "Type",
                value: "Dziwne");

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50,
                column: "Type",
                value: "Inne");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Fields");
        }
    }
}
