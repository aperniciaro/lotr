using Microsoft.EntityFrameworkCore.Migrations;

namespace lotr.Migrations
{
    public partial class ChangedPropNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryLanguage",
                table: "Races",
                newName: "NativeLanguage");

            migrationBuilder.RenameColumn(
                name: "HasWieldedRing",
                table: "Characters",
                newName: "HasWieldedOneRing");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NativeLanguage",
                table: "Races",
                newName: "PrimaryLanguage");

            migrationBuilder.RenameColumn(
                name: "HasWieldedOneRing",
                table: "Characters",
                newName: "HasWieldedRing");
        }
    }
}
