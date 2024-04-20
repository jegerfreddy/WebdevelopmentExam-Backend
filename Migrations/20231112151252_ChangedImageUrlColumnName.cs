using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedImageUrlColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Teams",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Drivers",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Teams",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Drivers",
                newName: "ImageUrl");
        }
    }
}
