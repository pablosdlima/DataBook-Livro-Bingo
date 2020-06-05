using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBook_Bingo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aldeia",
                columns: table => new
                {
                    IdAldeia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAldeia = table.Column<string>(nullable: false),
                    ImgAldeia = table.Column<byte[]>(nullable: false),
                    PaisAldeia = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aldeia", x => x.IdAldeia);
                });

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

            migrationBuilder.CreateTable(
                name: "Shinobi",
                columns: table => new
                {
                    IdShinobi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aldeia_Id = table.Column<int>(nullable: false),
                    NomeShinobi = table.Column<string>(nullable: false),
                    ImagemShinobi = table.Column<byte[]>(nullable: false),
                    Cla = table.Column<string>(nullable: false),
                    Especialidade = table.Column<string>(nullable: false),
                    Renegado = table.Column<string>(nullable: false),
                    Vivo = table.Column<string>(nullable: false),
                    Elemento = table.Column<string>(nullable: false),
                    Graduacao = table.Column<string>(nullable: false),
                    Membro = table.Column<string>(nullable: false),
                    Nivel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shinobi", x => x.IdShinobi);
                    table.ForeignKey(
                        name: "FK_Shinobi_Aldeia_Aldeia_Id",
                        column: x => x.Aldeia_Id,
                        principalTable: "Aldeia",
                        principalColumn: "IdAldeia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shinobi_Aldeia_Id",
                table: "Shinobi",
                column: "Aldeia_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cla");

            migrationBuilder.DropTable(
                name: "Shinobi");

            migrationBuilder.DropTable(
                name: "Aldeia");
        }
    }
}
