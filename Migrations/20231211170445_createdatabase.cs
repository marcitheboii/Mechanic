using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoszerelo.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ugyfelek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lakcim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugyfelek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Munkak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UgyfelId = table.Column<int>(type: "int", nullable: false),
                    Rendszam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GyartasiEv = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kategoria = table.Column<int>(type: "int", nullable: false),
                    HibaLeiras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HibaSulyossag = table.Column<int>(type: "int", nullable: false),
                    Allapot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Munkak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Munkak_Ugyfelek_UgyfelId",
                        column: x => x.UgyfelId,
                        principalTable: "Ugyfelek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Munkak_UgyfelId",
                table: "Munkak",
                column: "UgyfelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Munkak");

            migrationBuilder.DropTable(
                name: "Ugyfelek");
        }
    }
}
