using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumProject.Migrations
{
    public partial class KeysPictureMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/images/alicia_keys.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/images/alicia-keys.jpg");
        }
    }
}
