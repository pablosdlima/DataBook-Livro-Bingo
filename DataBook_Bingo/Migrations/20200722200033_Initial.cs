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
                    NomeAldeia = table.Column<string>(nullable: true),
                    ImgAldeia = table.Column<byte[]>(nullable: true),
                    PaisAldeia = table.Column<string>(nullable: true)
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
                    NomeClas = table.Column<string>(nullable: true),
                    ImageClas = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cla", x => x.IdClas);
                });

            migrationBuilder.CreateTable(
                name: "Organizacao",
                columns: table => new
                {
                    IdOrganizacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Limite = table.Column<int>(nullable: false),
                    NomeOrganizacao = table.Column<string>(nullable: true),
                    ImgOrganizacao = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizacao", x => x.IdOrganizacao);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailUsuario = table.Column<string>(nullable: false),
                    SenhaUsuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Shinobi",
                columns: table => new
                {
                    IdShinobi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aldeia_Id = table.Column<int>(nullable: false),
                    Cla_Id = table.Column<int>(nullable: false),
                    Organizacao_Id = table.Column<int>(nullable: false),
                    NomeShinobi = table.Column<string>(nullable: true),
                    ImagemShinobi = table.Column<byte[]>(nullable: true),
                    Especialidade = table.Column<string>(nullable: true),
                    Renegado = table.Column<string>(nullable: false),
                    Vivo = table.Column<string>(nullable: false),
                    Elemento = table.Column<string>(nullable: true),
                    Graduacao = table.Column<string>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Shinobi_Cla_Cla_Id",
                        column: x => x.Cla_Id,
                        principalTable: "Cla",
                        principalColumn: "IdClas",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shinobi_Organizacao_Organizacao_Id",
                        column: x => x.Organizacao_Id,
                        principalTable: "Organizacao",
                        principalColumn: "IdOrganizacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shinobi_Aldeia_Id",
                table: "Shinobi",
                column: "Aldeia_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shinobi_Cla_Id",
                table: "Shinobi",
                column: "Cla_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shinobi_Organizacao_Id",
                table: "Shinobi",
                column: "Organizacao_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shinobi");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Aldeia");

            migrationBuilder.DropTable(
                name: "Cla");

            migrationBuilder.DropTable(
                name: "Organizacao");
        }
    }
}
