using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minicoreback.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Gastos_IdDepartamento",
                table: "Gastos",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_IdEmpleado",
                table: "Gastos",
                column: "IdEmpleado");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Departamento_IdDepartamento",
                table: "Gastos",
                column: "IdDepartamento",
                principalTable: "Departamento",
                principalColumn: "IdDepartamento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Empleados_IdEmpleado",
                table: "Gastos",
                column: "IdEmpleado",
                principalTable: "Empleados",
                principalColumn: "IdEmpleado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Departamento_IdDepartamento",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Empleados_IdEmpleado",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_IdDepartamento",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_IdEmpleado",
                table: "Gastos");
        }
    }
}
