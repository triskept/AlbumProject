using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumProject.Migrations
{
    public partial class ArtistNameToAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Albums");
        }
    }
}
