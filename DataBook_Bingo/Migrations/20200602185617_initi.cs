using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBook_Bingo.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shinobi",
                columns: table => new
                {
                    IdShinobi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aldeia_Id = table.Column<int>(nullable: false),
                    NomeShinobi = table.Column<string>(nullable: false),
                    Cla = table.Column<string>(nullable: false),
                    Especialidade = table.Column<string>(nullable: false),
                    Renegado = table.Column<string>(nullable: false),
                    Vivo = table.Column<string>(nullable: false),
                    Elemento = table.Column<string>(nullable: false),
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
                name: "Shinobi");
        }
    }
}
