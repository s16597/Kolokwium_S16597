using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium.Migrations
{
    public partial class AddedValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusicianIdMusician",
                table: "Tracks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_MusicianIdMusician",
                table: "Tracks",
                column: "MusicianIdMusician");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Musicians_MusicianIdMusician",
                table: "Tracks",
                column: "MusicianIdMusician",
                principalTable: "Musicians",
                principalColumn: "IdMusician",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Musicians_MusicianIdMusician",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_MusicianIdMusician",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "MusicianIdMusician",
                table: "Tracks");
        }
    }
}
