using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class Modelsreconfigured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Likes",
                newName: "PlayerID");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Drawings",
                newName: "Keyword");

            migrationBuilder.AddColumn<decimal>(
                name: "GoogleScore",
                table: "Drawings",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Comments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleScore",
                table: "Drawings");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "Likes",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Keyword",
                table: "Drawings",
                newName: "Category");
        }
    }
}
