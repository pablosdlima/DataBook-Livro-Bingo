using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBook_Bingo.Migrations
{
    public partial class shinobi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImagemShinobi",
                table: "Shinobi",
                nullable: false,
                defaultValue: new byte[] {  });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemShinobi",
                table: "Shinobi");
        }
    }
}
