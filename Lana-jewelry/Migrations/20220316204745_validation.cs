using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lana_jewelry.Migrations
{
    public partial class validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewelryDb",
                newName: "Transports",
                newSchema: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "Infos",
                schema: "Lana_jewelryDb",
                newName: "Infos",
                newSchema: "Lana_jewelry");

            migrationBuilder.RenameTable(
                name: "Costumers",
                schema: "Lana_jewelryDb",
                newName: "Costumers",
                newSchema: "Lana_jewelry");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StreetNumber",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "Lana_jewelry",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Lana_jewelryDb");

            migrationBuilder.RenameTable(
                name: "Transports",
                schema: "Lana_jewelry",
                newName: "Transports",
                newSchema: "Lana_jewelryDb");

            migrationBuilder.RenameTable(
                name: "Infos",
                schema: "Lana_jewelry",
                newName: "Infos",
                newSchema: "Lana_jewelryDb");

            migrationBuilder.RenameTable(
                name: "Costumers",
                schema: "Lana_jewelry",
                newName: "Costumers",
                newSchema: "Lana_jewelryDb");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetNumber",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "Lana_jewelryDb",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
