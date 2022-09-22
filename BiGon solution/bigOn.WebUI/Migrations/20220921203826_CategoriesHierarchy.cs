using Microsoft.EntityFrameworkCore.Migrations;

namespace bigOn.WebUI.Migrations
{
    public partial class CategoriesHierarchy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPost",
                table: "ContactPost");

            migrationBuilder.RenameTable(
                name: "ContactPost",
                newName: "ContactPosts");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPosts",
                table: "ContactPosts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories",
                column: "ParentId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ParentId",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPosts",
                table: "ContactPosts");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "ContactPosts",
                newName: "ContactPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPost",
                table: "ContactPost",
                column: "Id");
        }
    }
}
