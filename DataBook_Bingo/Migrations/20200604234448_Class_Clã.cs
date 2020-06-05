using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBook_Bingo.Migrations
{
    public partial class Class_Clã : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cla",
                columns: table => new
                {
                    IdClas = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeClas = table.Column<string>(nullable: false),
                    ImageClas = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cla", x => x.IdClas);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cla");
        }
    }
}
