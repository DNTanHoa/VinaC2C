using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VinaC2C.Data.Migrations
{
    public partial class AddFeatureAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DigitalShops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ApiUrlPrefix = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigitalShops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FeatureID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    IsAllow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    IsMenuLeft = table.Column<bool>(nullable: false),
                    ParentFeatureID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DigitalShops");

            migrationBuilder.DropTable(
                name: "FeatureRoles");

            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
