using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class WallPostFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drawings_PWallPosts_WallPostID",
                table: "Drawings");

            migrationBuilder.DropForeignKey(
                name: "FK_PWallPosts_Categories_CategoryID",
                table: "PWallPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PWallPosts",
                table: "PWallPosts");

            migrationBuilder.RenameTable(
                name: "PWallPosts",
                newName: "WallPosts");

            migrationBuilder.RenameIndex(
                name: "IX_PWallPosts_CategoryID",
                table: "WallPosts",
                newName: "IX_WallPosts_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WallPosts",
                table: "WallPosts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawings_WallPosts_WallPostID",
                table: "Drawings",
                column: "WallPostID",
                principalTable: "WallPosts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WallPosts_Categories_CategoryID",
                table: "WallPosts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drawings_WallPosts_WallPostID",
                table: "Drawings");

            migrationBuilder.DropForeignKey(
                name: "FK_WallPosts_Categories_CategoryID",
                table: "WallPosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WallPosts",
                table: "WallPosts");

            migrationBuilder.RenameTable(
                name: "WallPosts",
                newName: "PWallPosts");

            migrationBuilder.RenameIndex(
                name: "IX_WallPosts_CategoryID",
                table: "PWallPosts",
                newName: "IX_PWallPosts_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PWallPosts",
                table: "PWallPosts",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawings_PWallPosts_WallPostID",
                table: "Drawings",
                column: "WallPostID",
                principalTable: "PWallPosts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PWallPosts_Categories_CategoryID",
                table: "PWallPosts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
