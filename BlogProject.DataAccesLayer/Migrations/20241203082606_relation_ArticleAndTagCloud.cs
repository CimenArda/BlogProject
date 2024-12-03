using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DataAccesLayer.Migrations
{
    public partial class relation_ArticleAndTagCloud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "TagClouds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TagClouds_ArticleID",
                table: "TagClouds",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Articles_ArticleID",
                table: "TagClouds",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Articles_ArticleID",
                table: "TagClouds");

            migrationBuilder.DropIndex(
                name: "IX_TagClouds_ArticleID",
                table: "TagClouds");

            migrationBuilder.DropColumn(
                name: "ArticleID",
                table: "TagClouds");
        }
    }
}
