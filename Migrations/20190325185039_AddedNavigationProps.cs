using Microsoft.EntityFrameworkCore.Migrations;

namespace lotr.Migrations
{
    public partial class AddedNavigationProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Characters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");
        }
    }
}
