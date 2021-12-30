using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRecipes.Data.Migrations
{
    public partial class AddOriginalUrlAndRemoteImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OriginalUrl",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemoteImageUrl",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalUrl",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RemoteImageUrl",
                table: "Images");
        }
    }
}
