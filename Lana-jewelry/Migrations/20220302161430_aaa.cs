using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lana_jewelry.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransportPrice",
                table: "Transports",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "TransportDuration",
                table: "Transports",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "TransportId",
                table: "Transports",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Transports",
                newName: "TransportPrice");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Transports",
                newName: "TransportDuration");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Transports",
                newName: "TransportId");
        }
    }
}
