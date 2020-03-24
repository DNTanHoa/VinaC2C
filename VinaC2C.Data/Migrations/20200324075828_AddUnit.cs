using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VinaC2C.Data.Migrations
{
    public partial class AddUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitConverts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SourceUnit = table.Column<long>(nullable: true),
                    DestinationUnit = table.Column<long>(nullable: true),
                    SourceCoefficient = table.Column<decimal>(nullable: true),
                    DestinationCoefficient = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitConverts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitConverts");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
