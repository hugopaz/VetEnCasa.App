using Microsoft.EntityFrameworkCore.Migrations;

namespace VetEnCasa.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "Personas");
        }
    }
}
