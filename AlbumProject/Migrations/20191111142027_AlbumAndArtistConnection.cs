using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumProject.Migrations
{
    public partial class AlbumAndArtistConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlbumTitle",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumTitle",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Albums");
        }
    }
}
