using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBook_Bingo.Migrations
{
    public partial class AlteracaoShinobi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cla",
                table: "Shinobi");

            migrationBuilder.AddColumn<int>(
                name: "Cla_Id",
                table: "Shinobi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shinobi_Cla_Id",
                table: "Shinobi",
                column: "Cla_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shinobi_Cla_Cla_Id",
                table: "Shinobi",
                column: "Cla_Id",
                principalTable: "Cla",
                principalColumn: "IdClas",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shinobi_Cla_Cla_Id",
                table: "Shinobi");

            migrationBuilder.DropIndex(
                name: "IX_Shinobi_Cla_Id",
                table: "Shinobi");

            migrationBuilder.DropColumn(
                name: "Cla_Id",
                table: "Shinobi");

            migrationBuilder.AddColumn<string>(
                name: "Cla",
                table: "Shinobi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
