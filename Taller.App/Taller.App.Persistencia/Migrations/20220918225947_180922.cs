using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    public partial class _180922 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioId",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "PropietarioId",
                table: "Vehiculos",
                newName: "PropietarioForeingKey");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PropietarioId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioForeingKey",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "PropietarioForeingKey",
                table: "Vehiculos",
                newName: "PropietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PropietarioForeingKey",
                table: "Vehiculos",
                newName: "IX_Vehiculos_PropietarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Propietarios_PropietarioId",
                table: "Vehiculos",
                column: "PropietarioId",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
