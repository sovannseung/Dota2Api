using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class remove_win_lose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Draw",
                table: "TblGroupStages");

            migrationBuilder.DropColumn(
                name: "Lose",
                table: "TblGroupStages");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "TblGroupStages");

            migrationBuilder.DropColumn(
                name: "Win",
                table: "TblGroupStages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Draw",
                table: "TblGroupStages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lose",
                table: "TblGroupStages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "TblGroupStages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Win",
                table: "TblGroupStages",
                nullable: false,
                defaultValue: 0);
        }
    }
}
