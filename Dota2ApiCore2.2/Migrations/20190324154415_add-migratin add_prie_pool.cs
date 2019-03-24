using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class addmigratinadd_prie_pool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "TblTournements",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PricePool",
                table: "TblTournements",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "TblTournements");

            migrationBuilder.DropColumn(
                name: "PricePool",
                table: "TblTournements");
        }
    }
}
