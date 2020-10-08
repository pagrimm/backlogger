using Microsoft.EntityFrameworkCore.Migrations;

namespace backlogger.Migrations
{
    public partial class ConsolidateApiID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RawgId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "TmdbId",
                table: "Items",
                newName: "ApiId");

            migrationBuilder.AddColumn<bool>(
                name: "Watched",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Watched",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ApiId",
                table: "Items",
                newName: "TmdbId");

            migrationBuilder.AddColumn<long>(
                name: "RawgId",
                table: "Items",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
