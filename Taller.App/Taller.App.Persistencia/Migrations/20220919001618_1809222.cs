using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    public partial class _1809222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioForeingKey",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "PropietarioForeingKey",
                table: "Vehiculos",
                newName: "Cedula");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PropietarioForeingKey",
                table: "Vehiculos",
                newName: "IX_Vehiculos_Cedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_Cedula",
                table: "Vehiculos",
                column: "Cedula",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_Cedula",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Vehiculos",
                newName: "PropietarioForeingKey");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_Cedula",
                table: "Vehiculos",
                newName: "IX_Vehiculos_PropietarioForeingKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioForeingKey",
                table: "Vehiculos",
                column: "PropietarioForeingKey",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
