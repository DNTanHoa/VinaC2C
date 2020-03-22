using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VinaC2C.Data.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DigitalShopRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    DigitalShopID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    IsAllow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DigitalShopRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DigitalShops",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
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
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    FeatureID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
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
                    Id = table.Column<long>(type: "bigint", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ServiceTicketRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ServiceTicketID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    IsAllow = table.Column<bool>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTicketRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTickets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    GCRecord = table.Column<bool>(nullable: false),
                    CreateUser = table.Column<string>(nullable: true),
                    UpdateUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    DateCycleExpire = table.Column<int>(nullable: true),
                    IsFree = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DigitalShopRoles");

            migrationBuilder.DropTable(
                name: "DigitalShops");

            migrationBuilder.DropTable(
                name: "FeatureRoles");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "ServiceTicketRoles");

            migrationBuilder.DropTable(
                name: "ServiceTickets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
