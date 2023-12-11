using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Autoszerelo.Data.Migrations.Munkak
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Munkak");
        }
    }
}
