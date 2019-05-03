using Microsoft.EntityFrameworkCore.Migrations;

namespace Dota2ApiCore2._2.Migrations
{
    public partial class AddTblPricePool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblPricePools",
                columns: table => new
                {
                    PricePoolId = table.Column<int>(nullable: false),
                    TournementId = table.Column<int>(nullable: false),
                    RankFrom = table.Column<int>(nullable: false),
                    RankTo = table.Column<int>(nullable: false),
                    PricePoolUSD = table.Column<int>(nullable: false),
                    DPCPoints = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPricePools", x => x.PricePoolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPricePools");
        }
    }
}
