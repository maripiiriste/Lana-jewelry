using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lana_jewelry.Migrations
{
    public partial class giftcards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costumers",
                schema: "Lana_jewelry");

            migrationBuilder.DropTable(
                name: "Infos",
                schema: "Lana_jewelry");

            migrationBuilder.EnsureSchema(
                name: "Lana_jewel");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewelry",
                newName: "Transports",
                newSchema: "Lana_jewel");

            migrationBuilder.CreateTable(
                name: "GiftCards",
                schema: "Lana_jewel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftCards",
                schema: "Lana_jewel");

            migrationBuilder.EnsureSchema(
                name: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewel",
                newName: "Transports",
                newSchema: "Lana_jewelry");

            migrationBuilder.CreateTable(
                name: "Costumers",
                schema: "Lana_jewelry",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
                schema: "Lana_jewelry",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.Id);
                });
        }
    }
}
