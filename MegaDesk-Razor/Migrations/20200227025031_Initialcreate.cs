using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk_Razor.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Desk",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<decimal>(nullable: false),
                    Depth = table.Column<decimal>(nullable: false),
                    NumDrawers = table.Column<decimal>(nullable: false),
                    MaterialType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desk", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Desk = table.Column<int>(nullable: false),
                    ShippingSpeed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialType = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingSpeed",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Speed = table.Column<string>(nullable: true),
                    BasePrice = table.Column<decimal>(nullable: false),
                    Over1000Price = table.Column<decimal>(nullable: false),
                    Over2000Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingSpeed", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desk");

            migrationBuilder.DropTable(
                name: "DeskQuote");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "ShippingSpeed");
        }
    }
}
