using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterkontinentalAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counters_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Counters_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Praga" },
                    { 2, "Kompostownik" },
                    { 3, "Kolin" },
                    { 4, "Kutna Hora" },
                    { 5, "Szansa 1" },
                    { 6, "Kolej Europejska" },
                    { 7, "Prypeć" },
                    { 8, "Gazownia" },
                    { 9, "Kijów" },
                    { 10, "Odwiedzanie Gułagu" },
                    { 11, "Odessa" },
                    { 12, "Watykan" },
                    { 13, "Lotnisko" },
                    { 14, "Płaza" },
                    { 15, "Balin" },
                    { 16, "Regulice" },
                    { 17, "Szansa 2" },
                    { 18, "Kolej Transsyberyjska" },
                    { 19, "Zaginiona Wioska" },
                    { 20, "Berlin Wschodni" },
                    { 21, "Drezno" },
                    { 22, "Zwickau" },
                    { 23, "Koksownia" },
                    { 24, "Władywostok" },
                    { 25, "Partyjna Działka" },
                    { 26, "Jekaterynburg" },
                    { 27, "Nowosybirsk" },
                    { 28, "Bogota" },
                    { 29, "Szansa 3" },
                    { 30, "Kolej Światowa" },
                    { 31, "Hawana" },
                    { 32, "Grill" },
                    { 33, "Meksyk" },
                    { 34, "Sydney" },
                    { 35, "Gułag" },
                    { 36, "Melbourne" },
                    { 37, "Wellington" },
                    { 38, "Zanzibar" },
                    { 39, "Port" },
                    { 40, "Dakar" },
                    { 41, "Kair" },
                    { 42, "Singapur" }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 43, "Szansa 4" },
                    { 44, "Kolej Towarowa" },
                    { 45, "Tajwan" },
                    { 46, "Truskawki" },
                    { 47, "Sosnowiec" },
                    { 48, "Kopalnia Uranu" },
                    { 49, "Bukareszt" },
                    { 50, "Start" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Counters_FieldId",
                table: "Counters",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Counters_GameId",
                table: "Counters",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
