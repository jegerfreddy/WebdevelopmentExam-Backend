using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDatatypesInTeamsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_Driver1Id",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Drivers_Driver2Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Driver1Id",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_Driver2Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Driver1Id",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Driver2Id",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "Driver1",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Driver2",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Driver1",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Driver2",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "Driver1Id",
                table: "Teams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Driver2Id",
                table: "Teams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Driver1Id",
                table: "Teams",
                column: "Driver1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Driver2Id",
                table: "Teams",
                column: "Driver2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_Driver1Id",
                table: "Teams",
                column: "Driver1Id",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Drivers_Driver2Id",
                table: "Teams",
                column: "Driver2Id",
                principalTable: "Drivers",
                principalColumn: "Id");
        }
    }
}
