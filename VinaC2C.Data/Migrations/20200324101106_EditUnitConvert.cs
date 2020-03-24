using Microsoft.EntityFrameworkCore.Migrations;

namespace VinaC2C.Data.Migrations
{
    public partial class EditUnitConvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "UnitConverts",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UnitConverts");
        }
    }
}
