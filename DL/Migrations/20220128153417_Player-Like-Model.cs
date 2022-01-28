using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class PlayerLikeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Players",
                newName: "AverageScore");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageResult",
                table: "Players",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TotalGuesses",
                table: "Players",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageResult",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TotalGuesses",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "AverageScore",
                table: "Players",
                newName: "Score");
        }
    }
}
