using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedStructureOfRaceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "NumOfLaps",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "WinnerTime",
                table: "Races",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "WinnerName",
                table: "Races",
                newName: "PlayerName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Races",
                newName: "WinnerTime");

            migrationBuilder.RenameColumn(
                name: "PlayerName",
                table: "Races",
                newName: "WinnerName");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Races",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumOfLaps",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
