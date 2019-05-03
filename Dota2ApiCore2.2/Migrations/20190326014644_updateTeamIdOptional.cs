using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class updateTeamIdOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "TblPricePools",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "TblPricePools",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
