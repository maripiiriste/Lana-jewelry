using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lana_jewelry.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewel",
                newName: "Transports",
                newSchema: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "GiftCards",
                schema: "Lana_jewel",
                newName: "GiftCards",
                newSchema: "Lana_jewelry");

            migrationBuilder.AlterColumn<string>(
                name: "CostumerAddress",
                schema: "Lana_jewelry",
                table: "Transports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Lana_jewelry",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Lana_jewelry");

            migrationBuilder.EnsureSchema(
                name: "Lana_jewel");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewelry",
                newName: "Transports",
                newSchema: "Lana_jewel");

            migrationBuilder.RenameTable(
                name: "GiftCards",
                schema: "Lana_jewelry",
                newName: "GiftCards",
                newSchema: "Lana_jewel");

            migrationBuilder.AlterColumn<string>(
                name: "CostumerAddress",
                schema: "Lana_jewel",
                table: "Transports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
