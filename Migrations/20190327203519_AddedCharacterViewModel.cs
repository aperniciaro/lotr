using Microsoft.EntityFrameworkCore.Migrations;

namespace lotr.Migrations
{
    public partial class AddedCharacterViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RaceName",
                table: "Characters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaceName",
                table: "Characters");
        }
    }
}
