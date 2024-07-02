using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class tableshist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES",
                columns: table => new
                {
                    IdBendHistBusqCuentasBancarias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BendHistBusqCabeceraId = table.Column<int>(type: "int", nullable: false),
                    MontoEmbargadoCuentasBancarias = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ObservacionCuentasBancarias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCuentasBancarias = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES", x => x.IdBendHistBusqCuentasBancarias);
                    table.ForeignKey(
                        name: "FK_BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES_Bend_Hist_Busq_Cabeceras_BendHistBusqCabeceraId",
                        column: x => x.BendHistBusqCabeceraId,
                        principalTable: "Bend_Hist_Busq_Cabeceras",
                        principalColumn: "IdBendHistBusqCabecera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES",
                columns: table => new
                {
                    IdBendHistBusqRemanente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BendHistBusqCabeceraId = table.Column<int>(type: "int", nullable: false),
                    TieneRemanente = table.Column<bool>(type: "bit", nullable: true),
                    EstadoRemanente = table.Column<int>(type: "int", nullable: true),
                    ObservacionRemanente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES", x => x.IdBendHistBusqRemanente);
                    table.ForeignKey(
                        name: "FK_BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES_Bend_Hist_Busq_Cabeceras_BendHistBusqCabeceraId",
                        column: x => x.BendHistBusqCabeceraId,
                        principalTable: "Bend_Hist_Busq_Cabeceras",
                        principalColumn: "IdBendHistBusqCabecera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES",
                columns: table => new
                {
                    IdBendHistBusqEstablecimientoComercio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BendHistBusqCabeceraId = table.Column<int>(type: "int", nullable: false),
                    NombreEstablecimiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DireccionEstablecimiento = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NumeroRegistroEstablecimiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObservacionEstablecimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoEstablecimiento = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES", x => x.IdBendHistBusqEstablecimientoComercio);
                    table.ForeignKey(
                        name: "FK_BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES_Bend_Hist_Busq_Cabeceras_BendHistBusqCabeceraId",
                        column: x => x.BendHistBusqCabeceraId,
                        principalTable: "Bend_Hist_Busq_Cabeceras",
                        principalColumn: "IdBendHistBusqCabecera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_OTROS_DETALLES",
                columns: table => new
                {
                    IdBendHistBusqOtro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BendHistBusqCabeceraId = table.Column<int>(type: "int", nullable: false),
                    TieneOtros = table.Column<bool>(type: "bit", nullable: true),
                    EstadoOtros = table.Column<int>(type: "int", nullable: true),
                    ObservacionOtros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    FecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    FecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BEND_HIST_BUSQ_OTROS_DETALLES", x => x.IdBendHistBusqOtro);
                    table.ForeignKey(
                        name: "FK_BEND_HIST_BUSQ_OTROS_DETALLES_Bend_Hist_Busq_Cabeceras_BendHistBusqCabeceraId",
                        column: x => x.BendHistBusqCabeceraId,
                        principalTable: "Bend_Hist_Busq_Cabeceras",
                        principalColumn: "IdBendHistBusqCabecera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES_BendHistBusqCabeceraId",
                table: "BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES",
                column: "BendHistBusqCabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES_BendHistBusqCabeceraId",
                table: "BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES",
                column: "BendHistBusqCabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES_BendHistBusqCabeceraId",
                table: "BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES",
                column: "BendHistBusqCabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_OTROS_DETALLES_BendHistBusqCabeceraId",
                table: "BEND_HIST_BUSQ_OTROS_DETALLES",
                column: "BendHistBusqCabeceraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_OTROS_DETALLES");
        }
    }
}
