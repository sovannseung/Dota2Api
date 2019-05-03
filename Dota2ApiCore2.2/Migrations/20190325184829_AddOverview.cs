using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class AddOverview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "TblTournements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Overview",
                table: "TblTournements");
        }
    }
}
