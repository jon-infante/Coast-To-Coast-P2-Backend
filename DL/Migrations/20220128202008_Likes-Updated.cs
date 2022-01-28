using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DL.Migrations
{
    public partial class LikesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Drawings");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentID",
                table: "Likes",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_DrawingID",
                table: "Likes",
                column: "DrawingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Comments_CommentID",
                table: "Likes",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Drawings_DrawingID",
                table: "Likes",
                column: "DrawingID",
                principalTable: "Drawings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Comments_CommentID",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Drawings_DrawingID",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_CommentID",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_DrawingID",
                table: "Likes");

            migrationBuilder.AddColumn<List<int>>(
                name: "Likes",
                table: "Drawings",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "Likes",
                table: "Comments",
                type: "integer[]",
                nullable: false);
        }
    }
}
