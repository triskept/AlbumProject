using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumProject.Migrations
{
    public partial class ConnectionAlbumToArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Albums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Albums",
                nullable: true);
        }
    }
}
