using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaGestion.Migrations
{
    /// <inheritdoc />
    public partial class ClientesEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
