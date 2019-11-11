using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumProject.Migrations
{
    public partial class LetsTryThisAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Albums",
                newName: "ArtistName");

            migrationBuilder.AddColumn<string>(
                name: "AlbumTitle",
                table: "Artists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumTitle",
                table: "Artists");

            migrationBuilder.RenameColumn(
                name: "ArtistName",
                table: "Albums",
                newName: "Name");
        }
    }
}
