using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblGroupStages");

            migrationBuilder.DropTable(
                name: "TblMainStages");

            migrationBuilder.DropTable(
                name: "TblTournementTeams");

            migrationBuilder.DropTable(
                name: "TblVideos");

            migrationBuilder.DropTable(
                name: "TblTeams");

            migrationBuilder.DropTable(
                name: "TblTournements");
        }
    }
}
