using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class update_something : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainStagePairId",
                table: "TblMainStages");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "TblVideos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "TblVideos");

            migrationBuilder.AddColumn<int>(
                name: "MainStagePairId",
                table: "TblMainStages",
                nullable: false,
                defaultValue: 0);
        }
    }
}
