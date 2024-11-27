using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaGestion.Migrations
{
    /// <inheritdoc />
    public partial class DbFarmaGestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Clientes_ClienteID",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_ClienteID",
                table: "Productos",
                newName: "IX_Productos_ClienteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Clientes_ClienteID",
                table: "Productos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Clientes_ClienteID",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_ClienteID",
                table: "Producto",
                newName: "IX_Producto_ClienteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Clientes_ClienteID",
                table: "Producto",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID");
        }
    }
}
