using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MigrationBend_Hist_Busq_Cabeceras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bend_Hist_Busq_Cabeceras",
                columns: table => new
                {
                    IdBendHistBusqCabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoMedidaCautelarId = table.Column<int>(type: "int", nullable: false),
                    DeudorId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FecCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FecActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bend_Hist_Busq_Cabeceras", x => x.IdBendHistBusqCabecera);
                    table.ForeignKey(
                        name: "FK_Bend_Hist_Busq_Cabeceras_BEND_DEUDORES_DeudorId",
                        column: x => x.DeudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bend_Hist_Busq_Cabeceras_BOFF_TIPO_MEDIDAS_CAUTELARES_TipoMedidaCautelarId",
                        column: x => x.TipoMedidaCautelarId,
                        principalTable: "BOFF_TIPO_MEDIDAS_CAUTELARES",
                        principalColumn: "idTipoMedidaCautelar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bend_Hist_Busq_Cabeceras_DeudorId",
                table: "Bend_Hist_Busq_Cabeceras",
                column: "DeudorId");

            migrationBuilder.CreateIndex(
                name: "IX_Bend_Hist_Busq_Cabeceras_TipoMedidaCautelarId",
                table: "Bend_Hist_Busq_Cabeceras",
                column: "TipoMedidaCautelarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bend_Hist_Busq_Cabeceras");
        }
    }
}
