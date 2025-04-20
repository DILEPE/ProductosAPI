using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductosAPI.Migrations
{
    /// <inheritdoc />
    public partial class CorregirPrecio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImagenesProductos",
                table: "ImagenesProductos");

            migrationBuilder.RenameTable(
                name: "ImagenesProductos",
                newName: "Imagenes");

            migrationBuilder.RenameIndex(
                name: "IX_ImagenesProductos_ProductoId",
                table: "Imagenes",
                newName: "IX_Imagenes_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagenes_Productos_ProductoId",
                table: "Imagenes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagenes_Productos_ProductoId",
                table: "Imagenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagenes",
                table: "Imagenes");

            migrationBuilder.RenameTable(
                name: "Imagenes",
                newName: "ImagenesProductos");

            migrationBuilder.RenameIndex(
                name: "IX_Imagenes_ProductoId",
                table: "ImagenesProductos",
                newName: "IX_ImagenesProductos_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImagenesProductos",
                table: "ImagenesProductos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagenesProductos_Productos_ProductoId",
                table: "ImagenesProductos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
