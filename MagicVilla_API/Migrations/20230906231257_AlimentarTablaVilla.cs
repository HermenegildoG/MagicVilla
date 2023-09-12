using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Aun sin detalles", new DateTime(2023, 9, 6, 17, 12, 56, 868, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 9, 6, 17, 12, 56, 868, DateTimeKind.Local).AddTicks(4675), "", 50, "Villa Chica", 5, 200.0 },
                    { 2, "", "Aun sin detalles", new DateTime(2023, 9, 6, 17, 12, 56, 868, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 9, 6, 17, 12, 56, 868, DateTimeKind.Local).AddTicks(4759), "", 90, "Amozoc", 24, 600.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
