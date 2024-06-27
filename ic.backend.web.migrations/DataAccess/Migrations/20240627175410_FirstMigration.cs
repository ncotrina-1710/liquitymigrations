using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APLI_DESPACHOS",
                columns: table => new
                {
                    idDespacho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDespacho = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DES__61E931FA36D2DAA1", x => x.idDespacho);
                });

            migrationBuilder.CreateTable(
                name: "APLI_DIVISAS",
                columns: table => new
                {
                    idDivisa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDivisa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    abreviacionDivisa = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    simboloDivisa = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DIV__96114A561016D848", x => x.idDivisa);
                });

            migrationBuilder.CreateTable(
                name: "APLI_ESTADO_COBROS",
                columns: table => new
                {
                    idEstadoCobro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEstadoCobro = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_EST__383D24944BAC210A", x => x.idEstadoCobro);
                });

            migrationBuilder.CreateTable(
                name: "APLI_FECHAS",
                columns: table => new
                {
                    idFecha = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    annio = table.Column<int>(type: "int", nullable: true),
                    mes = table.Column<int>(type: "int", nullable: true),
                    dia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_FEC__65F2E8696C3D2123", x => x.idFecha);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_ASIGNACIONES",
                columns: table => new
                {
                    idTipoAsignacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoAsignacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__377C788169FDCD07", x => x.idTipoAsignacion);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_AVALUOS",
                columns: table => new
                {
                    idTipoAvaluo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoAvaluo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__F12434E2CF612F3F", x => x.idTipoAvaluo);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_CONTACTOS",
                columns: table => new
                {
                    idTipoContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descipcionTipoContacto = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__EF7BE7754EEAC3EE", x => x.idTipoContacto);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_CUANTIAS",
                columns: table => new
                {
                    idTipoCuantia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoCuantia = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__9F273BD3D4567D9E", x => x.idTipoCuantia);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_DEUDAS",
                columns: table => new
                {
                    idTipoDeuda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descipcionTipoDeuda = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__2DA4E62725AB823A", x => x.idTipoDeuda);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_DILIGENCIAS",
                columns: table => new
                {
                    idTipoDiligencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoDiligencia = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__76917249780DE3C5", x => x.idTipoDiligencia);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_EVENTOS",
                columns: table => new
                {
                    idTipoEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoEvento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    fecCreacionTipoEvento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__09EED93A3F68C03F", x => x.idTipoEvento);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_JUZGADOS",
                columns: table => new
                {
                    idTipoJuzgado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoJuzgado = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    fecCreacionTipoJuzgado = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__0C417944A6502789", x => x.idTipoJuzgado);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_PAGARES",
                columns: table => new
                {
                    idTipoPagare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoPagare = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__A288A7DA2E0EE7F2", x => x.idTipoPagare);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_PERSONAS",
                columns: table => new
                {
                    idTipoPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoPersona = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__68D37AD6556F192D", x => x.idTipoPersona);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_PROCESOS",
                columns: table => new
                {
                    idTipoProceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProceso = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecCreacionProceso = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionProceso = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__619F308CDCD7781F", x => x.idTipoProceso);
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_REPORTES",
                columns: table => new
                {
                    idTipoReporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoReporte = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__5692713ACDCB72A3", x => x.idTipoReporte);
                });

            migrationBuilder.CreateTable(
                name: "APLI_VENCIMIENTO_CONTRASENIAS",
                columns: table => new
                {
                    idVencimientoContrasenia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantVencimiento = table.Column<int>(type: "int", nullable: false),
                    estadoVencimientoContrasenia = table.Column<int>(type: "int", nullable: false),
                    fecCreacionVencimientoContrasenia = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionVencimientoContrasenia = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_VEN__5C5D7D86414BFC5A", x => x.idVencimientoContrasenia);
                });

            migrationBuilder.CreateTable(
                name: "ASIC_SEDES",
                columns: table => new
                {
                    idSede = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paisSede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    departamentoSede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    provinciaSede = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoSede = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_SED__C5AF63D0FC52AEB6", x => x.idSede);
                });

            migrationBuilder.CreateTable(
                name: "BEND_ACTIVIDADES",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    idWorkFlow = table.Column<long>(type: "bigint", nullable: false),
                    idActividad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    idRol = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    fechaAsignacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaTermino = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaCancelacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaReingreso = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    fechaSuspension = table.Column<DateTime>(type: "datetime", nullable: true),
                    fechaReactivacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    permiso = table.Column<bool>(type: "bit", nullable: true),
                    idReproceso = table.Column<long>(type: "bigint", nullable: true),
                    esDetenido = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_ACT__3213E83F524DA46B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BEND_CAT_ACTIVIDADES_WS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    actividad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    idActividad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    idProceso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    proceso = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    page = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    etapa = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    tiempoPromedio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_CAT__3213E83FC89B33AE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BEND_CUSTOMIZA_ELEMENTOS",
                columns: table => new
                {
                    idCustomizaElemento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    tipoColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    fecCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_CUS__3EB03196B999C708", x => x.idCustomizaElemento);
                });

            migrationBuilder.CreateTable(
                name: "BEND_GARANTIA_FAVORES",
                columns: table => new
                {
                    idGarantiaFavor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacionAcreedor = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecInscripcionGarantiaFavor = table.Column<DateTime>(type: "datetime", nullable: true),
                    patrimonioAutonomo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    confeCamara = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_GAR__DAB8DF288384CA15", x => x.idGarantiaFavor);
                });

            migrationBuilder.CreateTable(
                name: "BEND_LIMITACION_PROPIEDADES",
                columns: table => new
                {
                    idLimitacionPropiedad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoLimitacionPropiedad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nroOficio = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    entidadJuridica = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    departamento = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    municipio = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecExpedicionOficio = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecRegistroSistema = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_LIM__35AC6A411E9CADC4", x => x.idLimitacionPropiedad);
                });

            migrationBuilder.CreateTable(
                name: "BEND_PLANTILLA_CAMPOS",
                columns: table => new
                {
                    idCampo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grupoCampo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    nombreCampo = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    descripcionCampo = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    requeridoCampo = table.Column<bool>(type: "bit", nullable: false),
                    tipoDatoCampo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    tipoControlCampo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoCampo = table.Column<int>(type: "int", nullable: false),
                    fecCreacionCampo = table.Column<DateTime>(type: "datetime", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_PLA__5245D63CF5F18C9E", x => x.idCampo);
                });

            migrationBuilder.CreateTable(
                name: "BEND_PREGUNTA_SESIONES",
                columns: table => new
                {
                    idPregunta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionPregunta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_PRE__623EEC4237F68B14", x => x.idPregunta);
                });

            migrationBuilder.CreateTable(
                name: "BEND_TBLETAPAS",
                columns: table => new
                {
                    idEtapa = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    descripcion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    fechaAlta = table.Column<DateTime>(type: "datetime", nullable: false),
                    fechaBaja = table.Column<DateTime>(type: "datetime", nullable: true),
                    activo = table.Column<bool>(type: "bit", nullable: false),
                    tiempoPromedio = table.Column<int>(type: "int", nullable: true),
                    tipoFlujo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_TBL__C587A24F24A9C6AB", x => x.idEtapa);
                });

            migrationBuilder.CreateTable(
                name: "BEND_TIPO_EXP_DOCUMENTOS",
                columns: table => new
                {
                    idTipoExpDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoExpDocumento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    fecCreacionTipoExpDocumento = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_TIP__B5486DC0493BA8F3", x => x.idTipoExpDocumento);
                });

            migrationBuilder.CreateTable(
                name: "BEND_TIPO_OBJETOS",
                columns: table => new
                {
                    idTipoObjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriptcionTipoObjeto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    estadoTipoObjeto = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_TIP__D3389F8ED680DD0F", x => x.idTipoObjeto);
                });

            migrationBuilder.CreateTable(
                name: "BEND_VALIDACIONES",
                columns: table => new
                {
                    idValidacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoValidacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_VAL__B0AAE7CFAAB8B7C6", x => x.idValidacion);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_HIST_SESIONES_ACTIVAS",
                columns: table => new
                {
                    idHistSesionActiva = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesionActivaUsuarioId = table.Column<int>(type: "int", nullable: false),
                    fecInicioHistSesion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecfinHistSesion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_HIS__BBEC5BD445B0A8DE", x => x.idHistSesionActiva);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_HIST_SESIONES_ERRONEAS",
                columns: table => new
                {
                    idHistSesionErronea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesionErroneaUsuarioId = table.Column<int>(type: "int", nullable: false),
                    fecInicioHistSesion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecfinHistSesion = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_HIS__F331AC4D4FD18AA5", x => x.idHistSesionErronea);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_PERFILES",
                columns: table => new
                {
                    idPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionPerfil = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoPerfil = table.Column<int>(type: "int", nullable: false),
                    fecCreacionPerfil = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionPerfil = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_PER__40F13B608F16E885", x => x.idPerfil);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_PERMISOS",
                columns: table => new
                {
                    idPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionPermiso = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoPermiso = table.Column<int>(type: "int", nullable: false),
                    fecCreacionPermiso = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionPermiso = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_PER__06A5848641D0CE82", x => x.idPermiso);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_ROLES",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionRol = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoRol = table.Column<int>(type: "int", nullable: false),
                    fecCreacionRol = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionRol = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_ROL__3C872F766444C158", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_TIPO_BITACORA",
                columns: table => new
                {
                    idTipoBitacora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoBitacora = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    nombreBitacora = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoBitacora = table.Column<int>(type: "int", nullable: false),
                    controlWeb = table.Column<bool>(type: "bit", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionBitacora = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionBitacora = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_TIP__D4B6FAF82C245321", x => x.idTipoBitacora);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_TIPO_ETAPA_MEDIDA_CAUTELAR",
                columns: table => new
                {
                    idTipoEtapaMedidaCautelar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroOrdenEtapaMedidaCautelar = table.Column<int>(type: "int", nullable: true),
                    nombreTipoEtapaMedidaCautelar = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoTipoEtapaMedidaCautelar = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionTipoEtapaMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionTipoEtapaMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_TIP__AFDF208CB5D595D5", x => x.idTipoEtapaMedidaCautelar);
                });

            migrationBuilder.CreateTable(
                name: "BOFF_TIPO_MEDIDAS_CAUTELARES",
                columns: table => new
                {
                    idTipoMedidaCautelar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoMedidaCautelar = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    estadoTipoMedidaCautelar = table.Column<int>(type: "int", nullable: false),
                    fecCreacionTipoMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionTipoMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_TIP__8FD696B62D6C34B7", x => x.idTipoMedidaCautelar);
                });

            migrationBuilder.CreateTable(
                name: "GBOT_LOG_CATEGORIAS",
                columns: table => new
                {
                    idLogCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLogCategoria = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_LOG__869C228EC2872207", x => x.idLogCategoria);
                });

            migrationBuilder.CreateTable(
                name: "GBOT_LOG_EVENTOS",
                columns: table => new
                {
                    idLogEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLogEvento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_LOG__45215E7B2FEAD496", x => x.idLogEvento);
                });

            migrationBuilder.CreateTable(
                name: "GBOT_LOG_FUENTES",
                columns: table => new
                {
                    idLogFuentes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLogFuentes = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_LOG__18D45F923F362261", x => x.idLogFuentes);
                });

            migrationBuilder.CreateTable(
                name: "GBOT_LOG_INTERACCIONES",
                columns: table => new
                {
                    idLogInteraccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLogInteraccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_LOG__05C411ACB220EBC3", x => x.idLogInteraccion);
                });

            migrationBuilder.CreateTable(
                name: "GBOT_PROCESOS_BOTS",
                columns: table => new
                {
                    idProcesoBot = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProcesoBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_PRO__EF60F4E84954BBB3", x => x.idProcesoBot);
                });

            migrationBuilder.CreateTable(
                name: "GIBD_PROCESOS_TABLAS",
                columns: table => new
                {
                    idProceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreProceso = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    prefijoProceso = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    estadoProceso = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIBD_PRO__DEC8292695F896B8", x => x.idProceso);
                });

            migrationBuilder.CreateTable(
                name: "GIBD_TIPO_AMBIENTES",
                columns: table => new
                {
                    idTipoAmbiente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreAmbiente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIBD_TIP__AE5ECEDBB873144F", x => x.idTipoAmbiente);
                });

            migrationBuilder.CreateTable(
                name: "INVB_TIPO_INMUEBLES",
                columns: table => new
                {
                    idTipoInmueble = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionTipoInmueble = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INVB_TIP__73A1AD1514FE7C9F", x => x.idTipoInmueble);
                });

            migrationBuilder.CreateTable(
                name: "APLI_EVENTOS",
                columns: table => new
                {
                    idEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoEvento = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    nombreEvento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    tipoEventoId = table.Column<int>(type: "int", nullable: false),
                    estadoEvento = table.Column<int>(type: "int", nullable: false),
                    controlWeb = table.Column<bool>(type: "bit", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionEvento = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionEvento = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_EVE__C8DC7BDA0EFC2C12", x => x.idEvento);
                    table.ForeignKey(
                        name: "FK_EVENTO_TIPOEVENTO_idTipoEvento",
                        column: x => x.tipoEventoId,
                        principalTable: "APLI_TIPO_EVENTOS",
                        principalColumn: "idTipoEvento");
                });

            migrationBuilder.CreateTable(
                name: "APLI_SUBTIPO_JUZGADOS",
                columns: table => new
                {
                    idSubtipoJuzgado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoJuzgadoId = table.Column<int>(type: "int", nullable: false),
                    descripcionSubtipoJuzgado = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    fecCreacionSubtipoJuzgado = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_SUB__33DB6AF61424954D", x => x.idSubtipoJuzgado);
                    table.ForeignKey(
                        name: "FK_TIPO_SUBTIPO_JUZGADOS_idTipoJuzgado",
                        column: x => x.tipoJuzgadoId,
                        principalTable: "APLI_TIPO_JUZGADOS",
                        principalColumn: "idTipoJuzgado");
                });

            migrationBuilder.CreateTable(
                name: "APLI_PAGARES",
                columns: table => new
                {
                    idPagare = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroPagare = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    tipoPagareId = table.Column<int>(type: "int", nullable: false),
                    fecCreacionPagare = table.Column<DateTime>(type: "datetime", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_PAG__74FD2A525E7DC319", x => x.idPagare);
                    table.ForeignKey(
                        name: "FK_PAGARES_TIPOPAGARES_idTipoPagare",
                        column: x => x.tipoPagareId,
                        principalTable: "APLI_TIPO_PAGARES",
                        principalColumn: "idTipoPagare");
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_DOCUMENTOS",
                columns: table => new
                {
                    idTipoDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreTipoDocumento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    tipoPersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__61FDF9F5C7C52745", x => x.idTipoDocumento);
                    table.ForeignKey(
                        name: "FK_TIPODOCUMENTO_TIPOPERSONA_idTipoPersona",
                        column: x => x.tipoPersonaId,
                        principalTable: "APLI_TIPO_PERSONAS",
                        principalColumn: "idTipoPersona");
                });

            migrationBuilder.CreateTable(
                name: "APLI_TIPO_ETAPAS",
                columns: table => new
                {
                    idTipoEtapa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoProcesoId = table.Column<int>(type: "int", nullable: false),
                    nroOrdenEtapa = table.Column<int>(type: "int", nullable: false),
                    nombreTipoEtapa = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoTipoEtapa = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionTipoEtapa = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionTipoEtapa = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_TIP__19611D342E2D6A12", x => x.idTipoEtapa);
                    table.ForeignKey(
                        name: "FK_TIPOPROCESO_TIPOETAPA_idTipoProceso",
                        column: x => x.tipoProcesoId,
                        principalTable: "APLI_TIPO_PROCESOS",
                        principalColumn: "idTipoProceso");
                });

            migrationBuilder.CreateTable(
                name: "APLI_LOCACIONES",
                columns: table => new
                {
                    idLocacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sedeId = table.Column<int>(type: "int", nullable: false),
                    paisLocacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    prefijo2Locacion = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    prefijo3Locacion = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    regionLocacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    provinciaLocacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ciudadLocacion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    latitudLocacion = table.Column<double>(type: "float", nullable: true),
                    longitudLocacion = table.Column<double>(type: "float", nullable: true),
                    prefijoNumericoLocacion = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    zonaHorariaLocacion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_LOC__C895F35ECA5E8F89", x => x.idLocacion);
                    table.ForeignKey(
                        name: "FK_LOCACIONES_SEDES_idSede",
                        column: x => x.sedeId,
                        principalTable: "ASIC_SEDES",
                        principalColumn: "idSede");
                });

            migrationBuilder.CreateTable(
                name: "BEND_RESPUESTA_SESIONES",
                columns: table => new
                {
                    idRespuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionRespuesta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    preguntaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_RES__8AB5BFC843F16337", x => x.idRespuesta);
                    table.ForeignKey(
                        name: "FK_RESPUESTA_PREGUNTA_idPregunta",
                        column: x => x.preguntaId,
                        principalTable: "BEND_PREGUNTA_SESIONES",
                        principalColumn: "idPregunta");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR",
                columns: table => new
                {
                    idTipoSubetapaMedidaCautelar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroOrdenSubetapaMedidaCautelar = table.Column<int>(type: "int", nullable: false),
                    tipoEtapaMedidaCautelarId = table.Column<int>(type: "int", nullable: false),
                    nombreSubetapaMedidaCautelar = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoSubetapaMedidaCautelar = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionSubetapaMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionSubetapaMedidaCautelar = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_TIP__4920BBA3F92F582E", x => x.idTipoSubetapaMedidaCautelar);
                    table.ForeignKey(
                        name: "FK_SUBETAPA_MEDIDACAUTELAR_ETAPAMEDIDACAUTELAR_idTipoEtapaMedidaCautelar",
                        column: x => x.tipoEtapaMedidaCautelarId,
                        principalTable: "BOFF_TIPO_ETAPA_MEDIDA_CAUTELAR",
                        principalColumn: "idTipoEtapaMedidaCautelar");
                });

            migrationBuilder.CreateTable(
                name: "BEND_OBJETOS",
                columns: table => new
                {
                    idObjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoObjetoId = table.Column<int>(type: "int", nullable: false),
                    padreObjetoId = table.Column<int>(type: "int", nullable: true),
                    nombreObjeto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    rutaObjeto = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoObjeto = table.Column<int>(type: "int", nullable: false),
                    tipoAmbienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_OBJ__C3C88194B35110F8", x => x.idObjeto);
                    table.ForeignKey(
                        name: "FK_OBJETO_AMBIENTE_idTipoAmbiente",
                        column: x => x.tipoAmbienteId,
                        principalTable: "GIBD_TIPO_AMBIENTES",
                        principalColumn: "idTipoAmbiente");
                    table.ForeignKey(
                        name: "FK_OBJETO_TIPO_OBJETOS_idTipoObjeto",
                        column: x => x.tipoObjetoId,
                        principalTable: "BEND_TIPO_OBJETOS",
                        principalColumn: "idTipoObjeto");
                });

            migrationBuilder.CreateTable(
                name: "GBOT_BOTS",
                columns: table => new
                {
                    idBot = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoAmbienteId = table.Column<int>(type: "int", nullable: false),
                    procesoBotId = table.Column<int>(type: "int", nullable: false),
                    codigoBot = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    nombreBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_BOT__383960253D6A4C3E", x => x.idBot);
                    table.ForeignKey(
                        name: "FK_BOTS_PROCESOSBOTS_idProcesoBot",
                        column: x => x.procesoBotId,
                        principalTable: "GBOT_PROCESOS_BOTS",
                        principalColumn: "idProcesoBot");
                    table.ForeignKey(
                        name: "FK_BOTS_TIPOAMBIENTES_idTipoAmbiente",
                        column: x => x.tipoAmbienteId,
                        principalTable: "GIBD_TIPO_AMBIENTES",
                        principalColumn: "idTipoAmbiente");
                });

            migrationBuilder.CreateTable(
                name: "GIBD_TABLAS",
                columns: table => new
                {
                    idTabla = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoAmbienteId = table.Column<int>(type: "int", nullable: false),
                    procesoId = table.Column<int>(type: "int", nullable: false),
                    nombreTabla = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    fecCreacionTabla = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecActualizacionTabla = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIBD_TAB__716BDE20DB284C34", x => x.idTabla);
                    table.ForeignKey(
                        name: "FK_TABLAS_AMBIENTE_idTipoAmbiente",
                        column: x => x.tipoAmbienteId,
                        principalTable: "GIBD_TIPO_AMBIENTES",
                        principalColumn: "idTipoAmbiente");
                    table.ForeignKey(
                        name: "FK_TABLAS_PROCESO_idProceso",
                        column: x => x.procesoId,
                        principalTable: "GIBD_PROCESOS_TABLAS",
                        principalColumn: "idProceso");
                });

            migrationBuilder.CreateTable(
                name: "APLI_LOCACION_JUZGADOS",
                columns: table => new
                {
                    idLocacionJuzgado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subtipoJuzgadoId = table.Column<int>(type: "int", nullable: true),
                    ciudadJuzgados = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    departamentoJuzgado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    zonaJuzgado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_LOC__45234F404BED56B6", x => x.idLocacionJuzgado);
                    table.ForeignKey(
                        name: "FK_LOCACION_SUBTIPO_JUZGADOS_idTipoJuzgado",
                        column: x => x.subtipoJuzgadoId,
                        principalTable: "APLI_SUBTIPO_JUZGADOS",
                        principalColumn: "idSubtipoJuzgado");
                });

            migrationBuilder.CreateTable(
                name: "APLI_DEMANDADOS",
                columns: table => new
                {
                    idDemandado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDemandado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    apellidoPaternoDemandado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    apellidoMaternoDemandado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoDemandado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    emailDemandado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    direccionDemandado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    telefonoDemandado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DEM__AFDB382450E1EEEA", x => x.idDemandado);
                    table.ForeignKey(
                        name: "FK_DEMANDADO_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "APLI_DEMANDANTES",
                columns: table => new
                {
                    idDemandante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDemandante = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tipoPersonaId = table.Column<int>(type: "int", nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoDemandante = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DEM__46019B4F2E357C73", x => x.idDemandante);
                    table.ForeignKey(
                        name: "FK_DEMANDANTE_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                    table.ForeignKey(
                        name: "FK_DEMANDANTE_TIPOPERSONA_idTipoPersona",
                        column: x => x.tipoPersonaId,
                        principalTable: "APLI_TIPO_PERSONAS",
                        principalColumn: "idTipoPersona");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDORES",
                columns: table => new
                {
                    idDeudor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    nroDocumento = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nombreDeudor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    apePaternoDeudor = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    apeMaternoDeudor = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecCreacionDeudor = table.Column<DateTime>(type: "datetime", nullable: true),
                    paisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__8FA83C7282E33368", x => x.idDeudor);
                    table.ForeignKey(
                        name: "FK_DEUDORES_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "APLI_ESTADO_PROCESAL",
                columns: table => new
                {
                    idEstadoProcesal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroOrdenEstado = table.Column<int>(type: "int", nullable: false),
                    tipoEtapaId = table.Column<int>(type: "int", nullable: false),
                    nombreEstadoProcesal = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoEstadoProcesal = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionEstadoProcesal = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionEstadoProcesal = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_EST__785BE16ED1AF2E9C", x => x.idEstadoProcesal);
                    table.ForeignKey(
                        name: "FK_ESTADO_TIPOETAPA_idTipoEtapa",
                        column: x => x.tipoEtapaId,
                        principalTable: "APLI_TIPO_ETAPAS",
                        principalColumn: "idTipoEtapa");
                });

            migrationBuilder.CreateTable(
                name: "APLI_SUBETAPAS",
                columns: table => new
                {
                    idSubEtapa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroOrdenSubtapa = table.Column<int>(type: "int", nullable: false),
                    tipoEtapaId = table.Column<int>(type: "int", nullable: false),
                    eventoId = table.Column<int>(type: "int", nullable: true),
                    nombreSubEtapa = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estadoSubEtapa = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    fecCreacionSubEtapa = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionSubEtapa = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_SUB__446E2DEF3EF3B060", x => x.idSubEtapa);
                    table.ForeignKey(
                        name: "FK_SUBETAPA_TIPOETAPA_idTipoEtapa",
                        column: x => x.tipoEtapaId,
                        principalTable: "APLI_TIPO_ETAPAS",
                        principalColumn: "idTipoEtapa");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_CLIENTES",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    emailCliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    tipoPersonaId = table.Column<int>(type: "int", nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoCliente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    estadoCliente = table.Column<int>(type: "int", nullable: false),
                    locacionId = table.Column<int>(type: "int", nullable: false),
                    rutaLogoCliente = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    direccionCliente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    fecCreacionCliente = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_CLI__885457EE6860AC5D", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_CLIENTES_LOCACION_idLocacion",
                        column: x => x.locacionId,
                        principalTable: "APLI_LOCACIONES",
                        principalColumn: "idLocacion");
                    table.ForeignKey(
                        name: "FK_CLIENTES_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                    table.ForeignKey(
                        name: "FK_CLIENTES_TIPOPERSONA_idTipoPersona",
                        column: x => x.tipoPersonaId,
                        principalTable: "APLI_TIPO_PERSONAS",
                        principalColumn: "idTipoPersona");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_PERFILES_PERMISOS",
                columns: table => new
                {
                    idPerfilPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    perfilId = table.Column<int>(type: "int", nullable: false),
                    objetoId = table.Column<int>(type: "int", nullable: false),
                    permisoId = table.Column<int>(type: "int", nullable: false),
                    urlPerfilPermiso = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    funcionPerfilPermiso = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    estadoPerfilPermiso = table.Column<int>(type: "int", nullable: false),
                    fecCreacionPerfilPermiso = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionPerfilPermiso = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_PER__47153D95E992EB55", x => x.idPerfilPermiso);
                    table.ForeignKey(
                        name: "FK_PERFILPERMISOS_OBJETOS_idObjeto",
                        column: x => x.objetoId,
                        principalTable: "BEND_OBJETOS",
                        principalColumn: "idObjeto");
                    table.ForeignKey(
                        name: "FK_PERFILPERMISOS_PERFILES_idPerfil",
                        column: x => x.perfilId,
                        principalTable: "BOFF_PERFILES",
                        principalColumn: "idPerfil");
                    table.ForeignKey(
                        name: "FK_PERFILPERMISOS_PERMISOS_idPermiso",
                        column: x => x.permisoId,
                        principalTable: "BOFF_PERMISOS",
                        principalColumn: "idPermiso");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_SESIONES_OBJETOS",
                columns: table => new
                {
                    idSesionObjeto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesionId = table.Column<int>(type: "int", nullable: false),
                    objetoId = table.Column<int>(type: "int", nullable: false),
                    fecSesionObjeto = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_SES__04AAA2544A2A7157", x => x.idSesionObjeto);
                    table.ForeignKey(
                        name: "FK_SESIONOBJETO_OBJETO_idObjeto",
                        column: x => x.objetoId,
                        principalTable: "BEND_OBJETOS",
                        principalColumn: "idObjeto");
                });

            migrationBuilder.CreateTable(
                name: "GBOT_HIST_GESTION_BOTS",
                columns: table => new
                {
                    idGestBot = table.Column<int>(type: "int", nullable: false),
                    botId = table.Column<int>(type: "int", nullable: false),
                    objetoId = table.Column<int>(type: "int", nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoGestBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecGestBot = table.Column<DateTime>(type: "datetime", nullable: false),
                    tipoDocumentoAuxGestBot = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    numeroDocumentoAuxGestBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_HIS__9D7964CD03619914", x => x.idGestBot);
                    table.ForeignKey(
                        name: "FK_HISTGESTBOTS_BOTS_idBot",
                        column: x => x.botId,
                        principalTable: "GBOT_BOTS",
                        principalColumn: "idBot");
                    table.ForeignKey(
                        name: "FK_HISTGESTBOTS_OBJETOS_idObjeto",
                        column: x => x.objetoId,
                        principalTable: "BEND_OBJETOS",
                        principalColumn: "idObjeto");
                    table.ForeignKey(
                        name: "FK_HISTGESTBOTS_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "GBOT_HIST_LOG_BOTS",
                columns: table => new
                {
                    idLogBot = table.Column<int>(type: "int", nullable: false),
                    botId = table.Column<int>(type: "int", nullable: false),
                    logEventoId = table.Column<int>(type: "int", nullable: false),
                    logCategoriaId = table.Column<int>(type: "int", nullable: false),
                    logInteraccionId = table.Column<int>(type: "int", nullable: false),
                    logFuenteId = table.Column<int>(type: "int", nullable: false),
                    fecLogBot = table.Column<DateTime>(type: "datetime", nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoLogBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tipoDocumentoAuxLogBot = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    numeroDocumentoAuxLogBot = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    mensaje = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    flagBarrido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GBOT_HIS__2E2BA02A3EAE9F2A", x => x.idLogBot);
                    table.ForeignKey(
                        name: "FK_HISTLOGBOTS_BOTS_idBot",
                        column: x => x.botId,
                        principalTable: "GBOT_BOTS",
                        principalColumn: "idBot");
                    table.ForeignKey(
                        name: "FK_HISTLOGBOTS_LOGCATEGORIAS_idLogCategoria",
                        column: x => x.logCategoriaId,
                        principalTable: "GBOT_LOG_CATEGORIAS",
                        principalColumn: "idLogCategoria");
                    table.ForeignKey(
                        name: "FK_HISTLOGBOTS_LOGEVENTOS_idLogEvento",
                        column: x => x.logEventoId,
                        principalTable: "GBOT_LOG_EVENTOS",
                        principalColumn: "idLogEvento");
                    table.ForeignKey(
                        name: "FK_HISTLOGBOTS_LOGINTERACCIONES_idLogInteraccion",
                        column: x => x.logInteraccionId,
                        principalTable: "GBOT_LOG_INTERACCIONES",
                        principalColumn: "idLogInteraccion");
                    table.ForeignKey(
                        name: "FK_HISTLOGBOTS_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "GIBD_AUDITORIA_TABLAS",
                columns: table => new
                {
                    idAuditoriaTabla = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tablaId = table.Column<int>(type: "int", nullable: false),
                    fecAuditoriaTabla = table.Column<DateTime>(type: "datetime", nullable: false),
                    descripcionAuditoriaTabla = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIBD_AUD__7616020EFEA9F17A", x => x.idAuditoriaTabla);
                    table.ForeignKey(
                        name: "FK_AUDITORIATABLA_TABLAS_idTabla",
                        column: x => x.tablaId,
                        principalTable: "GIBD_TABLAS",
                        principalColumn: "idTabla");
                });

            migrationBuilder.CreateTable(
                name: "APLI_JUZGADOS",
                columns: table => new
                {
                    idJuzgado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locacionJuzgadoId = table.Column<int>(type: "int", nullable: false),
                    nroJuzgado = table.Column<int>(type: "int", nullable: true),
                    codigoJuzgado = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    nombreJuzgado = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    correoElectronico = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    estadoJuzgado = table.Column<int>(type: "int", nullable: false),
                    fecCreacionJuzgado = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionJuzgado = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_JUZ__95D0A920A2CF9067", x => x.idJuzgado);
                    table.ForeignKey(
                        name: "FK_LOCACION_JUZGADOS_idLocacionJuzgado",
                        column: x => x.locacionJuzgadoId,
                        principalTable: "APLI_LOCACION_JUZGADOS",
                        principalColumn: "idLocacionJuzgado");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDOR_BIEN",
                columns: table => new
                {
                    idDeudorBien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    fecCreacionDeudorBien = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__B6C4A93F26C9A231", x => x.idDeudorBien);
                    table.ForeignKey(
                        name: "FK_BIEN_DETALLES_DEUDOR_idDeudor",
                        column: x => x.deudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDOR_RAMA_JUDICIAL",
                columns: table => new
                {
                    idDeudorRamaJudicial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorId = table.Column<int>(type: "int", nullable: true),
                    nroRadicacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    fecInicioTermino = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecFintTermino = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    fecRegistro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__25C7BFE5F3276A1A", x => x.idDeudorRamaJudicial);
                    table.ForeignKey(
                        name: "FK_RAMA_JUDICIAL_DEUDOR_idDeudor",
                        column: x => x.deudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDOR_SALARIO",
                columns: table => new
                {
                    idDeudorSalario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    fecCreacionSaliario = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__351AE0F5A5D3056E", x => x.idDeudorSalario);
                    table.ForeignKey(
                        name: "FK_SALARIO_DETALLE_DEUDOR_idDeudor",
                        column: x => x.deudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDOR_VEHICULO",
                columns: table => new
                {
                    idDeudorVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    fecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__015479B9CD0D5A8B", x => x.idDeudorVehiculo);
                    table.ForeignKey(
                        name: "FK_VEHICULO_DETALLES_DEUDOR_idDeudor",
                        column: x => x.deudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor");
                });

            migrationBuilder.CreateTable(
                name: "APLI_DIRECTORIOS",
                columns: table => new
                {
                    idDirectorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoDirectorio = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    estadoDirectorio = table.Column<int>(type: "int", nullable: false),
                    telefonoDirectorio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    emailDirectorio = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    identificacionDirectorio = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    whatsAppDirectorio = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    fecCreacionDirectorio = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionDirectorio = table.Column<DateTime>(type: "datetime", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DIR__14C666632E855429", x => x.idDirectorio);
                    table.ForeignKey(
                        name: "FK_DIRECTORIOS_CLIENTES_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE",
                columns: table => new
                {
                    idVencimientoContraseniaCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    vencimientoContraseniaId = table.Column<int>(type: "int", nullable: false),
                    estadoVencimientoContraseniaCliente = table.Column<int>(type: "int", nullable: false),
                    fecCreacionVencimientoContraseniaCliente = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionVencimientoContraseniaCliente = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_VEN__7D576B83DF34B45A", x => x.idVencimientoContraseniaCliente);
                    table.ForeignKey(
                        name: "FK_VENCIMIENTO_CLIENTES_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_VENCIMIENTO_CONTRASENIA_idVencimientoContrasenia",
                        column: x => x.vencimientoContraseniaId,
                        principalTable: "APLI_VENCIMIENTO_CONTRASENIAS",
                        principalColumn: "idVencimientoContrasenia");
                });

            migrationBuilder.CreateTable(
                name: "ASIC_MASIVA_LOTES",
                columns: table => new
                {
                    idLote = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLote = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    estadoLotes = table.Column<int>(type: "int", nullable: false),
                    fecCreacionLote = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionLote = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_MAS__1B91FFCBFAD443AD", x => x.idLote);
                    table.ForeignKey(
                        name: "FK_ASICLOTE_CLIENTES_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "BEND_CAMPO_CLIENTES",
                columns: table => new
                {
                    idCampoCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    campoId = table.Column<int>(type: "int", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    estadoCampoCliente = table.Column<int>(type: "int", nullable: false),
                    ordenCampo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_CAM__F627E5564ECE3F7F", x => x.idCampoCliente);
                    table.ForeignKey(
                        name: "FK_CAMPO_CLIENTES_PLANTILLACAMPOS_idCampo",
                        column: x => x.campoId,
                        principalTable: "BEND_PLANTILLA_CAMPOS",
                        principalColumn: "idCampo");
                    table.ForeignKey(
                        name: "FK_CAMPO_CLIENTES_PLANTILLACAMPOS_idcliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_APODERADOS",
                columns: table => new
                {
                    idApoderado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    nombreApoderado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    emailApoderado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    telefonoApoderado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    direccionApoderado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoApoderado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    estadoApoderado = table.Column<int>(type: "int", nullable: false),
                    fecCreacionApoderado = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_APO__D735979D9565A136", x => x.idApoderado);
                    table.ForeignKey(
                        name: "FK_APODERADOS_CLIENTE_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_APODERADOS_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_COLORES",
                columns: table => new
                {
                    idColor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    primario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    secundario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    fecCreacionColor = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionColor = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_COL__504A3B8810CB4F85", x => x.idColor);
                    table.ForeignKey(
                        name: "FK_COLOR_CLIENTE_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_CONFIG_CLIENTES",
                columns: table => new
                {
                    idConfigCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    prefijoConfigCliente = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    correlativoConfigCliente = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: false),
                    estadoConfigcliente = table.Column<int>(type: "int", nullable: false),
                    fecCreacionConfigCliente = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_CON__789329F06D4D5968", x => x.idConfigCliente);
                    table.ForeignKey(
                        name: "FK_CONFIGCLIENTES_CLIENTES_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_CUENTAS",
                columns: table => new
                {
                    idCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codIdentificacionCuenta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nombreCuenta = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    estadoCuenta = table.Column<int>(type: "int", nullable: false),
                    fecCreacionCuenta = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_CUE__BBC6DF326E210EFC", x => x.idCuenta);
                    table.ForeignKey(
                        name: "FK_CUENTA_CLIENTE_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_REPRESENTANTES",
                columns: table => new
                {
                    idRepresentante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    nombreRepresentante = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    emailRepresentante = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    telefonoRepresentante = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    direccionRepresentante = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoRepresentante = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    estadoRepresentante = table.Column<int>(type: "int", nullable: false),
                    fecCreacionRepresentante = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_REP__119773E3876662D1", x => x.idRepresentante);
                    table.ForeignKey(
                        name: "FK_REPRESENTANTES_CLIENTE_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_REPRESENTANTES_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_USUARIOS",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolId = table.Column<int>(type: "int", nullable: false),
                    clienteId = table.Column<int>(type: "int", nullable: false),
                    respuestaId = table.Column<int>(type: "int", nullable: false),
                    fecAltaUsuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    estadoUsuario = table.Column<int>(type: "int", nullable: false),
                    descripcionEstadoUsuario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    loginUsuario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    contrasenaUsuario = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    nombresUsuario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    apellidosUsuario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    emailUsuario = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    telefonoUsuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    estadoContrasenaUsuario = table.Column<int>(type: "int", nullable: false),
                    fecFinContrasenaUsuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecBajaUsuario = table.Column<DateTime>(type: "datetime", nullable: true),
                    verificarCorreo = table.Column<bool>(type: "bit", nullable: false),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoUsuario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_USU__645723A6BC285E6B", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_BOFFUSUARIO_CLIENTES_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_BOFFUSUARIO_RESPUESTAS_idRespuesta",
                        column: x => x.respuestaId,
                        principalTable: "BEND_RESPUESTA_SESIONES",
                        principalColumn: "idRespuesta");
                    table.ForeignKey(
                        name: "FK_BOFFUSUARIO_ROLES_idRol",
                        column: x => x.rolId,
                        principalTable: "BOFF_ROLES",
                        principalColumn: "idRol");
                    table.ForeignKey(
                        name: "FK_BOFFUSUARIO_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "BEND_ESTADO_ELECTRONICOS_RJ",
                columns: table => new
                {
                    idEstadoElectronico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    juzgadoId = table.Column<int>(type: "int", nullable: true),
                    anioEstadoElectronico = table.Column<int>(type: "int", nullable: false),
                    enlaceEstadoElectronico = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    xpathPestEstadoElectronico = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    xpathTabEstadoElectronico = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    fecCreacionEstadoElectronico = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionEstadoElectronico = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_EST__70DB6CA38D8058AE", x => x.idEstadoElectronico);
                    table.ForeignKey(
                        name: "FK__ELECTRONICOS_JUZGADOS_idJuzgado",
                        column: x => x.juzgadoId,
                        principalTable: "APLI_JUZGADOS",
                        principalColumn: "idJuzgado");
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_BIENES_DETALLES",
                columns: table => new
                {
                    idHistBusqBien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorBienId = table.Column<int>(type: "int", nullable: false),
                    ciudad = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    matricula = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    direccion = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    avaluo = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    oficinaRegistro = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    errorBusqueda = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    detalleError = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    fecCreacionBien = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecBusqueda = table.Column<DateTime>(type: "datetime", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: true),
                    observacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_HIS__779B445CE06BE16C", x => x.idHistBusqBien);
                    table.ForeignKey(
                        name: "FK_BIEN_BUSQBIEN_idDeudorBien",
                        column: x => x.deudorBienId,
                        principalTable: "BEND_DEUDOR_BIEN",
                        principalColumn: "idDeudorBien");
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_RAMA_JUDICIAL",
                columns: table => new
                {
                    idHistRamaJudicial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorRamaJudicialId = table.Column<int>(type: "int", nullable: true),
                    expedienteId = table.Column<int>(type: "int", nullable: true),
                    juzgadoId = table.Column<int>(type: "int", nullable: true),
                    sedeId = table.Column<int>(type: "int", nullable: true),
                    actuacionAnotacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    anotacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fecActuacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipActuacionesTybaProceso = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecActuacionTybaProceso = table.Column<DateTime>(type: "datetime", nullable: true),
                    solicitaDetalleEstado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    demandanteRamaJudicial = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    llaveRamaJudicial = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecInicioTermino = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecFintTermino = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecRegistro = table.Column<DateTime>(type: "datetime", nullable: true),
                    coincidenciaRamaJudicial = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    departamentoRamaJudicial = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    estadoRamaJudicial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    despachoRamaJudicial = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    claseProcesoRamaJudicial = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    fecCreacionRamaJudicial = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionRamaJudicial = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioCreacionRamaJudicial = table.Column<int>(type: "int", nullable: false),
                    fecActualizacionAntRamaJudicial = table.Column<DateTime>(type: "datetime", nullable: true),
                    errorBusqueda = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    detalleError = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fecBusqueda = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    concateacion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    concateacionTyba = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    fecRegistroTybaProceso = table.Column<DateTime>(type: "datetime", nullable: true),
                    rutaDctoPdf = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RutaDctoPdfEstado = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FechaCarga = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaActualizacionMicrositio = table.Column<DateTime>(type: "datetime", nullable: true),
                    ObservacionMicrositio = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RutaDctoPdfEstadoP4 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RutaDctoPdfProvidP4 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ObservacionMicrositioP4 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    FechaMicrositio = table.Column<DateTime>(type: "datetime", nullable: true),
                    FechaActualizacionMicrositioP4 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_HIS__F1A006A011A0646C", x => x.idHistRamaJudicial);
                    table.ForeignKey(
                        name: "FK__JUZAGADO_HISTRAMAJUDICIAL_idJuzgado",
                        column: x => x.juzgadoId,
                        principalTable: "APLI_JUZGADOS",
                        principalColumn: "idJuzgado");
                    table.ForeignKey(
                        name: "FK__RAMAJUDICIAL_HISTRAMAJUDICIAL_idDeudorRamaJudicial",
                        column: x => x.deudorRamaJudicialId,
                        principalTable: "BEND_DEUDOR_RAMA_JUDICIAL",
                        principalColumn: "idDeudorRamaJudicial");
                    table.ForeignKey(
                        name: "FK__SEDE_HISTRAMAJUDICIAL_idSede",
                        column: x => x.sedeId,
                        principalTable: "ASIC_SEDES",
                        principalColumn: "idSede");
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_SALARIOS_DETALLES",
                columns: table => new
                {
                    idHistBusqSalario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorSalarioId = table.Column<int>(type: "int", nullable: false),
                    estadoSalario = table.Column<int>(type: "int", nullable: true),
                    entidadSalario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tipoRegimenSalario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecAfilEfectiva = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecAfilFinalizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipoAfiliadoSalario = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    salario = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    empresa = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    direccionEmpresa = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nroDocumento = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    errorBusqueda = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    detalleError = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    fecBusqueda = table.Column<DateTime>(type: "datetime", nullable: true),
                    observacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_HIS__7FDEC5D44F692695", x => x.idHistBusqSalario);
                    table.ForeignKey(
                        name: "FK_SALARIO_DETALLE_idDeudorSalario",
                        column: x => x.deudorSalarioId,
                        principalTable: "BEND_DEUDOR_SALARIO",
                        principalColumn: "idDeudorSalario");
                    table.ForeignKey(
                        name: "FK_SALARIO_TIPODOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_BUSQ_VEHICULOS_DETALLES",
                columns: table => new
                {
                    idHistBusqVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorVehiculoId = table.Column<int>(type: "int", nullable: false),
                    nroPlacaVehiculo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    limitacionPropiedadId = table.Column<int>(type: "int", nullable: true),
                    garantiaFavorId = table.Column<int>(type: "int", nullable: true),
                    estadoRuntVehiculo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    marcaVehiculo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    modeloVehiculo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    nroSerieVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nroChasisVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    cilindrajeVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    combustibleVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    autoridadTransitoVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    clasicoAntiguoVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    lineaVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    colorVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nroMotorVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    nroVinVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tipoCarroceriaVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecMatriculaInicialVehiculo = table.Column<DateTime>(type: "datetime", nullable: true),
                    gravemenesPropiedad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    repotenciadoVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ciudadVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    oficinaRegistro = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    otrasCaracteristicas = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    errorBusqueda = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    detalleError = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    estadoVehiculo = table.Column<int>(type: "int", nullable: true),
                    estadoLimPropiedadVehiculo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    estadoGarFavorDe = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    observacion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_HIS__AB4588F3A8EB12C2", x => x.idHistBusqVehiculo);
                    table.ForeignKey(
                        name: "FK_BUSQ_VEHICULOS_GARANTIA_idGarantiaFavor",
                        column: x => x.garantiaFavorId,
                        principalTable: "BEND_GARANTIA_FAVORES",
                        principalColumn: "idGarantiaFavor");
                    table.ForeignKey(
                        name: "FK_BUSQ_VEHICULOS_LIMITACION_idLimitacionPropiedad",
                        column: x => x.limitacionPropiedadId,
                        principalTable: "BEND_LIMITACION_PROPIEDADES",
                        principalColumn: "idLimitacionPropiedad");
                    table.ForeignKey(
                        name: "FK_VEHICULO_BUSQVEHICULO_idDeudorVehiculo",
                        column: x => x.deudorVehiculoId,
                        principalTable: "BEND_DEUDOR_VEHICULO",
                        principalColumn: "idDeudorVehiculo");
                });

            migrationBuilder.CreateTable(
                name: "ASIC_MASIVA_CABECERAS",
                columns: table => new
                {
                    idCabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loteId = table.Column<int>(type: "int", nullable: false),
                    registrosTotalesCabecera = table.Column<int>(type: "int", nullable: false),
                    registrosErroneosCabecera = table.Column<int>(type: "int", nullable: false),
                    tipoDocumentoCabecera = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    nombreDocumentoCabecera = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    flagAceptacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_MAS__33F2D28269A75D6B", x => x.idCabecera);
                    table.ForeignKey(
                        name: "FK_ASICCABECERA_LOTE_idLote",
                        column: x => x.loteId,
                        principalTable: "ASIC_MASIVA_LOTES",
                        principalColumn: "idLote");
                });

            migrationBuilder.CreateTable(
                name: "ASIC_MASIVA_LOTE_CARGA_ERRORES",
                columns: table => new
                {
                    idLotesCargaError = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroFilaLote = table.Column<int>(type: "int", nullable: false),
                    descripcionCampoLote = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    descripcionErrorLote = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    loteId = table.Column<int>(type: "int", nullable: false),
                    fecCargaErrorLote = table.Column<DateTime>(type: "datetime", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_MAS__868348BBA85F5A09", x => x.idLotesCargaError);
                    table.ForeignKey(
                        name: "FK_LOTE_CARGA_ERRORES_LOTES_idLote",
                        column: x => x.loteId,
                        principalTable: "ASIC_MASIVA_LOTES",
                        principalColumn: "idLote");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_ASOCIACION_COLOR_CLIENTES",
                columns: table => new
                {
                    idAsociacionColorCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customizaElementoId = table.Column<int>(type: "int", nullable: false),
                    colorId = table.Column<int>(type: "int", nullable: false),
                    fecCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_ASO__A70CC7277294E1F8", x => x.idAsociacionColorCliente);
                    table.ForeignKey(
                        name: "FK_ASOC_COLOR_idColor",
                        column: x => x.colorId,
                        principalTable: "BOFF_COLORES",
                        principalColumn: "idColor");
                    table.ForeignKey(
                        name: "FK_ASOC_CUSTOM_idCustomizaElemento",
                        column: x => x.customizaElementoId,
                        principalTable: "BEND_CUSTOMIZA_ELEMENTOS",
                        principalColumn: "idCustomizaElemento");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_CUENTAS_AGENTE",
                columns: table => new
                {
                    idCuentaAgente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cuentaId = table.Column<int>(type: "int", nullable: false),
                    tipoAgente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    nombreAgente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    emailAgente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    telefonoAgente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    direccionAgente = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    numeroDocumentoAgente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    poderDemanda = table.Column<int>(type: "int", nullable: false),
                    estadoAgente = table.Column<int>(type: "int", nullable: false),
                    fecCreacionAgente = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_CUE__3833D224DD53C00F", x => x.idCuentaAgente);
                    table.ForeignKey(
                        name: "FK_AGENTE_CUENTA_idCuenta",
                        column: x => x.cuentaId,
                        principalTable: "BOFF_CUENTAS",
                        principalColumn: "idCuenta");
                    table.ForeignKey(
                        name: "FK_AGENTE_TIPO_DOCUMENTO_idTipoDocumento",
                        column: x => x.tipoDocumentoId,
                        principalTable: "APLI_TIPO_DOCUMENTOS",
                        principalColumn: "idTipoDocumento");
                });

            migrationBuilder.CreateTable(
                name: "APLI_ABOGADOS",
                columns: table => new
                {
                    idAbogado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    nombresAbogado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    apellidosAbogado = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    tarjetaProfesional = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    fecInicioLicenciaAbogado = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecFinLicenciaAbogado = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecNacimientoAbogado = table.Column<DateTime>(type: "date", nullable: true),
                    estadoAbogado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_ABO__22D2E6DEABCB5A29", x => x.idAbogado);
                    table.ForeignKey(
                        name: "FK_ABOGADO_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BEND_HIST_VALIDACIONES",
                columns: table => new
                {
                    idHistValidacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    validacionId = table.Column<int>(type: "int", nullable: false),
                    locacionId = table.Column<int>(type: "int", nullable: false),
                    telefonoHistValidacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    emailHistValidacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    codigoVerifHistValidacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fecCodigoVerifHistValidacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecInicioSesionHistValidacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    flagExitoSesionHistValidacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_HIS__732CFC9A822A0670", x => x.idHistValidacion);
                    table.ForeignKey(
                        name: "FK_HISVALIDACION_LOCACIONES_idLocacion",
                        column: x => x.locacionId,
                        principalTable: "APLI_LOCACIONES",
                        principalColumn: "idLocacion");
                    table.ForeignKey(
                        name: "FK_HISVALIDACION_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                    table.ForeignKey(
                        name: "FK_HISVALIDACION_VALIDACIONES_idValidacion",
                        column: x => x.validacionId,
                        principalTable: "BEND_VALIDACIONES",
                        principalColumn: "idValidacion");
                });

            migrationBuilder.CreateTable(
                name: "BEND_USUARIOS",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    fecAltaUsuario = table.Column<DateTime>(type: "datetime", nullable: false),
                    contrasena = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    estado = table.Column<int>(type: "int", nullable: true),
                    fecBajaUsuario = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_USU__A5B1AB8E3FBD4A7A", x => x.usuarioId);
                    table.ForeignKey(
                        name: "FK_BENDUSUARIO_BOFFUSUARIO_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_HIST_CONTRASENAS",
                columns: table => new
                {
                    idHistContrasena = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    usuarioContrasena = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    validacionId = table.Column<int>(type: "int", nullable: false),
                    fecIniContrasena = table.Column<DateTime>(type: "date", nullable: false),
                    fecFinContrasena = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_HIS__F64B5534225010A8", x => x.idHistContrasena);
                    table.ForeignKey(
                        name: "FK_HISCONTRASENA_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                    table.ForeignKey(
                        name: "FK_HISCONTRASENA_VALIDACIONES_idValidacion",
                        column: x => x.validacionId,
                        principalTable: "BEND_VALIDACIONES",
                        principalColumn: "idValidacion");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_PERFIL_ROLES",
                columns: table => new
                {
                    idPerfilRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    perfilId = table.Column<int>(type: "int", nullable: true),
                    rolId = table.Column<int>(type: "int", nullable: false),
                    actor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    descripcionPerfilRol = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    idUsuarioAlta = table.Column<int>(type: "int", nullable: true),
                    estadoPerfilRol = table.Column<int>(type: "int", nullable: false),
                    fecCreacionPerfilRol = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_PER__FF59545BF1B08156", x => x.idPerfilRol);
                    table.ForeignKey(
                        name: "FK_PERFIL_ROLES_idPerfil",
                        column: x => x.perfilId,
                        principalTable: "BOFF_PERFILES",
                        principalColumn: "idPerfil");
                    table.ForeignKey(
                        name: "FK_PERFIL_ROLES_idRol",
                        column: x => x.rolId,
                        principalTable: "BOFF_ROLES",
                        principalColumn: "idRol");
                    table.ForeignKey(
                        name: "FK_PERFIL_ROLES_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_SESIONES_ACTIVAS",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    validacionId = table.Column<int>(type: "int", nullable: false),
                    codigoVerifSesion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fecCodigoVerifSesion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecInicioSesion = table.Column<DateTime>(type: "datetime", nullable: false),
                    flagExitoSesion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SESIONACTIVA_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                    table.ForeignKey(
                        name: "FK_SESIONACTIVA_VALIDACION_idValidacion",
                        column: x => x.validacionId,
                        principalTable: "BEND_VALIDACIONES",
                        principalColumn: "idValidacion");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_SESIONES_ERRONEAS",
                columns: table => new
                {
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    fecSesionErronea = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SESIONERRONEA_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_USUARIO_CUENTAS",
                columns: table => new
                {
                    idUsuarioCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cuentaId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    estadoUsuarioCuenta = table.Column<int>(type: "int", nullable: false),
                    idUsuarioCreador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_USU__3127B6D2C80DCED8", x => x.idUsuarioCuenta);
                    table.ForeignKey(
                        name: "FK_USUARIO_CUENTAS_CUENTAS_idCuenta",
                        column: x => x.cuentaId,
                        principalTable: "BOFF_CUENTAS",
                        principalColumn: "idCuenta");
                    table.ForeignKey(
                        name: "FK_USUARIO_CUENTAS_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "ASIC_EXPEDIENTES",
                columns: table => new
                {
                    idExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cabeceraId = table.Column<int>(type: "int", nullable: true),
                    expediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    clienteId = table.Column<int>(type: "int", nullable: true),
                    llave = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    representanteId = table.Column<int>(type: "int", nullable: true),
                    apoderadoId = table.Column<int>(type: "int", nullable: true),
                    demandadoId = table.Column<int>(type: "int", nullable: true),
                    demandadoId2 = table.Column<int>(type: "int", nullable: true),
                    demandadoId3 = table.Column<int>(type: "int", nullable: true),
                    demandadoId4 = table.Column<int>(type: "int", nullable: true),
                    demandanteId = table.Column<int>(type: "int", nullable: true),
                    tipoProcesoId = table.Column<int>(type: "int", nullable: true),
                    sedeId = table.Column<int>(type: "int", nullable: true),
                    cuentaId = table.Column<int>(type: "int", nullable: true),
                    subEtapaId = table.Column<int>(type: "int", nullable: true),
                    estadoProcesalId = table.Column<int>(type: "int", nullable: true),
                    abogadoId = table.Column<int>(type: "int", nullable: true),
                    tipocuantiaId = table.Column<int>(type: "int", nullable: true),
                    nroRadicacion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    nroRadicacionCorta = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    gyc = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    planCompartir = table.Column<bool>(type: "bit", nullable: true),
                    estadoDetalle = table.Column<int>(type: "int", nullable: true),
                    fecAsignacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    prescripcionDetalle = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecSustitucion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecPresentacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    flagFng = table.Column<bool>(type: "bit", nullable: true),
                    docFngTramitado = table.Column<bool>(type: "bit", nullable: true),
                    vrPagoFng = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    fecLiquidacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    valorLiquidacion = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valorRemate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    observacionDetalle = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    fecCreacionExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_EXP__ED873AE3406826D2", x => x.idExpediente);
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_ABOGADOS_idAbogado",
                        column: x => x.abogadoId,
                        principalTable: "APLI_ABOGADOS",
                        principalColumn: "idAbogado");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_APODERADO_idApoderado",
                        column: x => x.apoderadoId,
                        principalTable: "BOFF_APODERADOS",
                        principalColumn: "idApoderado");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_CABECERA_idCabecera",
                        column: x => x.cabeceraId,
                        principalTable: "ASIC_MASIVA_CABECERAS",
                        principalColumn: "idCabecera");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_CLIENTE_idCliente",
                        column: x => x.clienteId,
                        principalTable: "BOFF_CLIENTES",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_CUENTAS_idCuenta",
                        column: x => x.cuentaId,
                        principalTable: "BOFF_CUENTAS",
                        principalColumn: "idCuenta");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_DEMANDADO_idDemandado",
                        column: x => x.demandadoId,
                        principalTable: "APLI_DEMANDADOS",
                        principalColumn: "idDemandado");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_DEMANDANTES_idDemandante",
                        column: x => x.demandanteId,
                        principalTable: "APLI_DEMANDANTES",
                        principalColumn: "idDemandante");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_ESTADOS_idEstadoProcesal",
                        column: x => x.estadoProcesalId,
                        principalTable: "APLI_ESTADO_PROCESAL",
                        principalColumn: "idEstadoProcesal");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_REPRESENTANTE_idRepresentante",
                        column: x => x.representanteId,
                        principalTable: "BOFF_REPRESENTANTES",
                        principalColumn: "idRepresentante");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_SEDES_idSede",
                        column: x => x.sedeId,
                        principalTable: "ASIC_SEDES",
                        principalColumn: "idSede");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_SUBETAPA_idSubEtapa",
                        column: x => x.subEtapaId,
                        principalTable: "APLI_SUBETAPAS",
                        principalColumn: "idSubEtapa");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_TIPOCUANTIAS_idTipoCuantia",
                        column: x => x.tipocuantiaId,
                        principalTable: "APLI_TIPO_CUANTIAS",
                        principalColumn: "idTipoCuantia");
                    table.ForeignKey(
                        name: "FK_ASICEXPEDIENTE_TIPOPROCESO_idTipoProceso",
                        column: x => x.tipoProcesoId,
                        principalTable: "APLI_TIPO_PROCESOS",
                        principalColumn: "idTipoProceso");
                });

            migrationBuilder.CreateTable(
                name: "APLI_ACTUACIONES_EXPEDIENTES",
                columns: table => new
                {
                    idActuacionExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    subEtapaId = table.Column<int>(type: "int", nullable: true),
                    nombreActuacionExpediente = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    urlDocAdjunto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: false),
                    fecGestionActuacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecEstadoActuacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecActuacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_ACT__17FAAC5164A260C1", x => x.idActuacionExpediente);
                    table.ForeignKey(
                        name: "FK_ACTUACION_EXPEDIENTES_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_ACTUACION_EXPEDIENTES_SUBETAPA_idSubEtapa",
                        column: x => x.subEtapaId,
                        principalTable: "APLI_SUBETAPAS",
                        principalColumn: "idSubEtapa");
                });

            migrationBuilder.CreateTable(
                name: "APLI_ASIGNACIONES",
                columns: table => new
                {
                    idAsignacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    tipoAsignacionId = table.Column<int>(type: "int", nullable: false),
                    fecCreacionAsignacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionAsignacion = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_ASI__E1714478F3230806", x => x.idAsignacion);
                    table.ForeignKey(
                        name: "FK_ASIGNACIONES_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_ASIGNACIONES_TIPOASIGNACION_idTipoAsignacion",
                        column: x => x.tipoAsignacionId,
                        principalTable: "APLI_TIPO_ASIGNACIONES",
                        principalColumn: "idTipoAsignacion");
                    table.ForeignKey(
                        name: "FK_ASIGNACIONES_USUARIOS_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "APLI_DETALLE_EXPEDIENTE_EVENTOS",
                columns: table => new
                {
                    idDetalleExpedienteEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    eventoId = table.Column<int>(type: "int", nullable: false),
                    descripcionDetalleExpedienteEvento = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    archivoAdjunto = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    fecCreacionExpedienteEvento = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionExpedienteEvento = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecAsignadaInicio = table.Column<DateTime>(type: "date", nullable: true),
                    fecAsignadaFin = table.Column<DateTime>(type: "date", nullable: true),
                    horaAsignadaInicio = table.Column<TimeSpan>(type: "time", nullable: true),
                    horaAsignadaFin = table.Column<TimeSpan>(type: "time", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    controlWeb = table.Column<bool>(type: "bit", nullable: false),
                    estadoExpedienteEvento = table.Column<int>(type: "int", nullable: false),
                    nombreUsuario = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    observacion = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_DET__B26634A37B07502D", x => x.idDetalleExpedienteEvento);
                    table.ForeignKey(
                        name: "FK_EXPEDIENTEEVENTO_ASICEXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_EXPEDIENTEEVENTO_EVENTO_idEvento",
                        column: x => x.eventoId,
                        principalTable: "APLI_EVENTOS",
                        principalColumn: "idEvento");
                    table.ForeignKey(
                        name: "FK_EXPEDIENTEEVENTO_USUARIO_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "APLI_ESTATUS_PROCESOS",
                columns: table => new
                {
                    idEstatusProceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    estadoProcesalId = table.Column<int>(type: "int", nullable: false),
                    estadoEstatusProceso = table.Column<int>(type: "int", nullable: false),
                    fecCreacionEstatusProceso = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionEstatusProceso = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_EST__4A7993648C734F85", x => x.idEstatusProceso);
                    table.ForeignKey(
                        name: "FK_PROCESOS_ESTADOS_idEstadoProcesal",
                        column: x => x.estadoProcesalId,
                        principalTable: "APLI_ESTADO_PROCESAL",
                        principalColumn: "idEstadoProcesal");
                    table.ForeignKey(
                        name: "FK_PROCESOS_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_PROCESOS_USUARIO_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "APLI_EXP_DOCUMENTOS",
                columns: table => new
                {
                    idExpDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoExpDocumentoId = table.Column<int>(type: "int", nullable: false),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    fecCreacionExpDocumento = table.Column<DateTime>(type: "datetime", nullable: false),
                    urlDocAdjunto = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_EXP__950B158F122AA2BC", x => x.idExpDocumento);
                    table.ForeignKey(
                        name: "FK_DOCUMENTO_EXPEDIENTES_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_DOCUMENTO_TIPOEXPDOCUMENTOS_idTipoExpDocumento",
                        column: x => x.tipoExpDocumentoId,
                        principalTable: "BEND_TIPO_EXP_DOCUMENTOS",
                        principalColumn: "idTipoExpDocumento");
                });

            migrationBuilder.CreateTable(
                name: "APLI_EXPEDIENTE_BITACORA",
                columns: table => new
                {
                    idBitacoraExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    tipoBitacoraId = table.Column<int>(type: "int", nullable: false),
                    descripcionBitacora = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    fecSeguimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    horaRegistro = table.Column<TimeSpan>(type: "time", nullable: false),
                    estadoBitacora = table.Column<int>(type: "int", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_EXPEDIENTE_BITACORA_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_TIPOBITACORA_BITACORA_idTipoBitacora",
                        column: x => x.tipoBitacoraId,
                        principalTable: "BOFF_TIPO_BITACORA",
                        principalColumn: "idTipoBitacora");
                });

            migrationBuilder.CreateTable(
                name: "APLI_JUZGADO_EXPEDIENTES",
                columns: table => new
                {
                    idJuzgadoExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    juzgadoId = table.Column<int>(type: "int", nullable: false),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    juzgadoOrigen = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    ciudadJuzgadoExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    departamentoJuzgadoExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    abogadoInicialJuzgadoExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    fecCreacionJuzgadoExpediente = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionjuzgadoExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_JUZ__AEE78C8B254C5627", x => x.idJuzgadoExpediente);
                    table.ForeignKey(
                        name: "FK_JUZGADO_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_JUZGADO_EXPEDIENTE_idJuzgado",
                        column: x => x.juzgadoId,
                        principalTable: "APLI_JUZGADOS",
                        principalColumn: "idJuzgado");
                });

            migrationBuilder.CreateTable(
                name: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES",
                columns: table => new
                {
                    idMedidaCautelarExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expedienteId = table.Column<int>(type: "int", nullable: true),
                    tipoMedidaCautelarId = table.Column<int>(type: "int", nullable: true),
                    tipoSubetapaMedidaCautelarId = table.Column<int>(type: "int", nullable: true),
                    demandadoId = table.Column<int>(type: "int", nullable: false),
                    detalleMedidaCautelar = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    calendarioMedidaCautelarExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    numeroOficioMedidaCautelarExpediente = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    valorAvaluoMedidaCautelarExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valorRemateMedidaCautelarExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    fecGestionMedidaCautelarExpdiente = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecCreacionedidaCautelarExpediente = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_MED__467AFCF466098B51", x => x.idMedidaCautelarExpediente);
                    table.ForeignKey(
                        name: "FK_MEDIDACAUTELAR_DEMANDADO_idDemandado",
                        column: x => x.demandadoId,
                        principalTable: "APLI_DEMANDADOS",
                        principalColumn: "idDemandado");
                    table.ForeignKey(
                        name: "FK_MEDIDACAUTELAR_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_SUBETAPA_MEDIDACAUTELAR_EXPEDIENTE_idTipoSubetapaMedidaCautelar",
                        column: x => x.tipoSubetapaMedidaCautelarId,
                        principalTable: "BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR",
                        principalColumn: "idTipoSubetapaMedidaCautelar");
                    table.ForeignKey(
                        name: "FK_TIPO_MEDIDACAUTELAR_EXPEDIENTE_idTipoMedidaCautelar",
                        column: x => x.tipoMedidaCautelarId,
                        principalTable: "BOFF_TIPO_MEDIDAS_CAUTELARES",
                        principalColumn: "idTipoMedidaCautelar");
                });

            migrationBuilder.CreateTable(
                name: "APLI_PAGARES_EXPEDIENTES",
                columns: table => new
                {
                    idPagareExpediente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pagareId = table.Column<int>(type: "int", nullable: false),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    capitalPagareExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    interesPagareExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    otroValoresPagareExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valorPagareExpediente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    obligacionPagareExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    fecVencimientoPagareExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecPrescripcionPagareExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecCreacionPagareExpediente = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActualizacionPagareExpediente = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__APLI_PAG__A511D37DDD5AA811", x => x.idPagareExpediente);
                    table.ForeignKey(
                        name: "FK_PAGARE_EXPEDIENTE_idPagare",
                        column: x => x.pagareId,
                        principalTable: "APLI_PAGARES",
                        principalColumn: "idPagare");
                    table.ForeignKey(
                        name: "FL_PAGARE_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                });

            migrationBuilder.CreateTable(
                name: "ASIC_EXPEDIENTE_CARGA_ERRORES",
                columns: table => new
                {
                    idExpedienteCargaError = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroFilaExpediente = table.Column<int>(type: "int", nullable: false),
                    descripcionCampoExpediente = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    descripcionErrorExpediente = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: false),
                    expedienteId = table.Column<int>(type: "int", nullable: false),
                    fecCargaErrorExpediente = table.Column<DateTime>(type: "datetime", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ASIC_EXP__DC0062F39A414237", x => x.idExpedienteCargaError);
                    table.ForeignKey(
                        name: "FK_EXPEDIENTE_CARGA_ERRORES_EXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DEUDOR_DECEVAL",
                columns: table => new
                {
                    idDeudorDeceval = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorId = table.Column<int>(type: "int", nullable: true),
                    expedienteId = table.Column<int>(type: "int", nullable: true),
                    fecSolicitud = table.Column<DateTime>(type: "datetime", nullable: true),
                    fecRecepcion = table.Column<DateTime>(type: "datetime", nullable: true),
                    estadoDeceval = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEU__40144E53CC7426EE", x => x.idDeudorDeceval);
                    table.ForeignKey(
                        name: "FK_DEUDORDECEVAL_ASICEXPEDIENTE_idExpediente",
                        column: x => x.expedienteId,
                        principalTable: "ASIC_EXPEDIENTES",
                        principalColumn: "idExpediente");
                    table.ForeignKey(
                        name: "FK_DEUDORDECEVAL_DEUDOR_idDeudor",
                        column: x => x.deudorId,
                        principalTable: "BEND_DEUDORES",
                        principalColumn: "idDeudor");
                });

            migrationBuilder.CreateTable(
                name: "BOFF_ESTADO_PROCESAL_DOCUMENTOS",
                columns: table => new
                {
                    idEstadoProcesalDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoExpDocumentoId = table.Column<int>(type: "int", nullable: false),
                    estatusProcesoId = table.Column<int>(type: "int", nullable: false),
                    estadoDocumento = table.Column<int>(type: "int", nullable: false),
                    fecCreacionEstadoProcesalDocumento = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecActulacionEntregaDocumento = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOFF_EST__A8FC7B32E179CAA4", x => x.idEstadoProcesalDocumento);
                    table.ForeignKey(
                        name: "FK_PROCESAL_DOCUMENTOS_ESTATUS_idEstatusProceso",
                        column: x => x.estatusProcesoId,
                        principalTable: "APLI_ESTATUS_PROCESOS",
                        principalColumn: "idEstatusProceso");
                    table.ForeignKey(
                        name: "FK_PROCESAL_DOCUMENTOS_TIPOEXPDOCUMENTOS_idTipoExpDocumento",
                        column: x => x.tipoExpDocumentoId,
                        principalTable: "BEND_TIPO_EXP_DOCUMENTOS",
                        principalColumn: "idTipoExpDocumento");
                    table.ForeignKey(
                        name: "FK_PROCESAL_DOCUMENTOS_USUARIO_idUsuario",
                        column: x => x.usuarioId,
                        principalTable: "BOFF_USUARIOS",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateTable(
                name: "BEND_DECEVAL",
                columns: table => new
                {
                    idDeceval = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deudorDecevalId = table.Column<int>(type: "int", nullable: true),
                    sedeId = table.Column<int>(type: "int", nullable: true),
                    cuentaId = table.Column<int>(type: "int", nullable: true),
                    unidad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    mti = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    digital = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    valor = table.Column<decimal>(type: "decimal(19,2)", nullable: true),
                    valorInteres = table.Column<decimal>(type: "decimal(19,2)", nullable: true),
                    fechaVencimiento = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipoPagare = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tipoCertificado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    estado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    proceso = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    enlace = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    observacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecActualizacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    activo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecCreacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    certficicado = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    fecExpedicion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BEND_DEC__B56AF5230CDE5CD1", x => x.idDeceval);
                    table.ForeignKey(
                        name: "FK_DEUDORDECEVAL_DECEVAL_idDeudorDeceval",
                        column: x => x.deudorDecevalId,
                        principalTable: "BEND_DEUDOR_DECEVAL",
                        principalColumn: "idDeudorDeceval");
                    table.ForeignKey(
                        name: "FK__CUENTA_DEUDORDECEVALL_idCuenta",
                        column: x => x.cuentaId,
                        principalTable: "BOFF_CUENTAS",
                        principalColumn: "idCuenta");
                    table.ForeignKey(
                        name: "FK__SEDE_DEUDORDECEVALL_idSede",
                        column: x => x.sedeId,
                        principalTable: "ASIC_SEDES",
                        principalColumn: "idSede");
                });

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ABOGADOS_usuarioId",
                table: "APLI_ABOGADOS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ACTUACIONES_EXPEDIENTES_expedienteId",
                table: "APLI_ACTUACIONES_EXPEDIENTES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ACTUACIONES_EXPEDIENTES_subEtapaId",
                table: "APLI_ACTUACIONES_EXPEDIENTES",
                column: "subEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ASIGNACIONES_expedienteId",
                table: "APLI_ASIGNACIONES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ASIGNACIONES_tipoAsignacionId",
                table: "APLI_ASIGNACIONES",
                column: "tipoAsignacionId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ASIGNACIONES_usuarioId",
                table: "APLI_ASIGNACIONES",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DEMANDADOS_tipoDocumentoId",
                table: "APLI_DEMANDADOS",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DEMANDANTES_tipoDocumentoId",
                table: "APLI_DEMANDANTES",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DEMANDANTES_tipoPersonaId",
                table: "APLI_DEMANDANTES",
                column: "tipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DETALLE_EXPEDIENTE_EVENTOS_eventoId",
                table: "APLI_DETALLE_EXPEDIENTE_EVENTOS",
                column: "eventoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DETALLE_EXPEDIENTE_EVENTOS_expedienteId",
                table: "APLI_DETALLE_EXPEDIENTE_EVENTOS",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DETALLE_EXPEDIENTE_EVENTOS_usuarioId",
                table: "APLI_DETALLE_EXPEDIENTE_EVENTOS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_DIRECTORIOS_clienteId",
                table: "APLI_DIRECTORIOS",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ESTADO_PROCESAL_tipoEtapaId",
                table: "APLI_ESTADO_PROCESAL",
                column: "tipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ESTATUS_PROCESOS_estadoProcesalId",
                table: "APLI_ESTATUS_PROCESOS",
                column: "estadoProcesalId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ESTATUS_PROCESOS_expedienteId",
                table: "APLI_ESTATUS_PROCESOS",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_ESTATUS_PROCESOS_usuarioId",
                table: "APLI_ESTATUS_PROCESOS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_EVENTOS_tipoEventoId",
                table: "APLI_EVENTOS",
                column: "tipoEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_EXP_DOCUMENTOS_expedienteId",
                table: "APLI_EXP_DOCUMENTOS",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_EXP_DOCUMENTOS_tipoExpDocumentoId",
                table: "APLI_EXP_DOCUMENTOS",
                column: "tipoExpDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_EXPEDIENTE_BITACORA_expedienteId",
                table: "APLI_EXPEDIENTE_BITACORA",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_EXPEDIENTE_BITACORA_tipoBitacoraId",
                table: "APLI_EXPEDIENTE_BITACORA",
                column: "tipoBitacoraId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_JUZGADO_EXPEDIENTES_expedienteId",
                table: "APLI_JUZGADO_EXPEDIENTES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_JUZGADO_EXPEDIENTES_juzgadoId",
                table: "APLI_JUZGADO_EXPEDIENTES",
                column: "juzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_JUZGADOS_locacionJuzgadoId",
                table: "APLI_JUZGADOS",
                column: "locacionJuzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_LOCACION_JUZGADOS_subtipoJuzgadoId",
                table: "APLI_LOCACION_JUZGADOS",
                column: "subtipoJuzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_LOCACIONES_sedeId",
                table: "APLI_LOCACIONES",
                column: "sedeId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_MEDIDA_CAUTELAR_EXPEDIENTES_demandadoId",
                table: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES",
                column: "demandadoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_MEDIDA_CAUTELAR_EXPEDIENTES_expedienteId",
                table: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_MEDIDA_CAUTELAR_EXPEDIENTES_tipoMedidaCautelarId",
                table: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES",
                column: "tipoMedidaCautelarId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_MEDIDA_CAUTELAR_EXPEDIENTES_tipoSubetapaMedidaCautelarId",
                table: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES",
                column: "tipoSubetapaMedidaCautelarId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_PAGARES_tipoPagareId",
                table: "APLI_PAGARES",
                column: "tipoPagareId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_PAGARES_EXPEDIENTES_expedienteId",
                table: "APLI_PAGARES_EXPEDIENTES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_PAGARES_EXPEDIENTES_pagareId",
                table: "APLI_PAGARES_EXPEDIENTES",
                column: "pagareId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_SUBETAPAS_tipoEtapaId",
                table: "APLI_SUBETAPAS",
                column: "tipoEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_SUBTIPO_JUZGADOS_tipoJuzgadoId",
                table: "APLI_SUBTIPO_JUZGADOS",
                column: "tipoJuzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_TIPO_DOCUMENTOS_tipoPersonaId",
                table: "APLI_TIPO_DOCUMENTOS",
                column: "tipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_TIPO_ETAPAS_tipoProcesoId",
                table: "APLI_TIPO_ETAPAS",
                column: "tipoProcesoId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE_clienteId",
                table: "APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE_vencimientoContraseniaId",
                table: "APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE",
                column: "vencimientoContraseniaId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTE_CARGA_ERRORES_expedienteId",
                table: "ASIC_EXPEDIENTE_CARGA_ERRORES",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_abogadoId",
                table: "ASIC_EXPEDIENTES",
                column: "abogadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_apoderadoId",
                table: "ASIC_EXPEDIENTES",
                column: "apoderadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_cabeceraId",
                table: "ASIC_EXPEDIENTES",
                column: "cabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_clienteId",
                table: "ASIC_EXPEDIENTES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_cuentaId",
                table: "ASIC_EXPEDIENTES",
                column: "cuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_demandadoId",
                table: "ASIC_EXPEDIENTES",
                column: "demandadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_demandanteId",
                table: "ASIC_EXPEDIENTES",
                column: "demandanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_estadoProcesalId",
                table: "ASIC_EXPEDIENTES",
                column: "estadoProcesalId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_representanteId",
                table: "ASIC_EXPEDIENTES",
                column: "representanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_sedeId",
                table: "ASIC_EXPEDIENTES",
                column: "sedeId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_subEtapaId",
                table: "ASIC_EXPEDIENTES",
                column: "subEtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_tipocuantiaId",
                table: "ASIC_EXPEDIENTES",
                column: "tipocuantiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_EXPEDIENTES_tipoProcesoId",
                table: "ASIC_EXPEDIENTES",
                column: "tipoProcesoId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_MASIVA_CABECERAS_loteId",
                table: "ASIC_MASIVA_CABECERAS",
                column: "loteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_MASIVA_LOTE_CARGA_ERRORES_loteId",
                table: "ASIC_MASIVA_LOTE_CARGA_ERRORES",
                column: "loteId");

            migrationBuilder.CreateIndex(
                name: "IX_ASIC_MASIVA_LOTES_clienteId",
                table: "ASIC_MASIVA_LOTES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_CAMPO_CLIENTES_campoId",
                table: "BEND_CAMPO_CLIENTES",
                column: "campoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_CAMPO_CLIENTES_clienteId",
                table: "BEND_CAMPO_CLIENTES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DECEVAL_cuentaId",
                table: "BEND_DECEVAL",
                column: "cuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DECEVAL_deudorDecevalId",
                table: "BEND_DECEVAL",
                column: "deudorDecevalId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DECEVAL_sedeId",
                table: "BEND_DECEVAL",
                column: "sedeId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_BIEN_deudorId",
                table: "BEND_DEUDOR_BIEN",
                column: "deudorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_DECEVAL_deudorId",
                table: "BEND_DEUDOR_DECEVAL",
                column: "deudorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_DECEVAL_expedienteId",
                table: "BEND_DEUDOR_DECEVAL",
                column: "expedienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_RAMA_JUDICIAL_deudorId",
                table: "BEND_DEUDOR_RAMA_JUDICIAL",
                column: "deudorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_SALARIO_deudorId",
                table: "BEND_DEUDOR_SALARIO",
                column: "deudorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDOR_VEHICULO_deudorId",
                table: "BEND_DEUDOR_VEHICULO",
                column: "deudorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_DEUDORES_tipoDocumentoId",
                table: "BEND_DEUDORES",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_ESTADO_ELECTRONICOS_RJ_juzgadoId",
                table: "BEND_ESTADO_ELECTRONICOS_RJ",
                column: "juzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_BIENES_DETALLES_deudorBienId",
                table: "BEND_HIST_BUSQ_BIENES_DETALLES",
                column: "deudorBienId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_SALARIOS_DETALLES_deudorSalarioId",
                table: "BEND_HIST_BUSQ_SALARIOS_DETALLES",
                column: "deudorSalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_SALARIOS_DETALLES_tipoDocumentoId",
                table: "BEND_HIST_BUSQ_SALARIOS_DETALLES",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_VEHICULOS_DETALLES_deudorVehiculoId",
                table: "BEND_HIST_BUSQ_VEHICULOS_DETALLES",
                column: "deudorVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_VEHICULOS_DETALLES_garantiaFavorId",
                table: "BEND_HIST_BUSQ_VEHICULOS_DETALLES",
                column: "garantiaFavorId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_BUSQ_VEHICULOS_DETALLES_limitacionPropiedadId",
                table: "BEND_HIST_BUSQ_VEHICULOS_DETALLES",
                column: "limitacionPropiedadId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_RAMA_JUDICIAL_deudorRamaJudicialId",
                table: "BEND_HIST_RAMA_JUDICIAL",
                column: "deudorRamaJudicialId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_RAMA_JUDICIAL_juzgadoId",
                table: "BEND_HIST_RAMA_JUDICIAL",
                column: "juzgadoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_RAMA_JUDICIAL_sedeId",
                table: "BEND_HIST_RAMA_JUDICIAL",
                column: "sedeId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_VALIDACIONES_locacionId",
                table: "BEND_HIST_VALIDACIONES",
                column: "locacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_VALIDACIONES_usuarioId",
                table: "BEND_HIST_VALIDACIONES",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_HIST_VALIDACIONES_validacionId",
                table: "BEND_HIST_VALIDACIONES",
                column: "validacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_OBJETOS_tipoAmbienteId",
                table: "BEND_OBJETOS",
                column: "tipoAmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_OBJETOS_tipoObjetoId",
                table: "BEND_OBJETOS",
                column: "tipoObjetoId");

            migrationBuilder.CreateIndex(
                name: "IX_BEND_RESPUESTA_SESIONES_preguntaId",
                table: "BEND_RESPUESTA_SESIONES",
                column: "preguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_APODERADOS_clienteId",
                table: "BOFF_APODERADOS",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_APODERADOS_tipoDocumentoId",
                table: "BOFF_APODERADOS",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_ASOCIACION_COLOR_CLIENTES_colorId",
                table: "BOFF_ASOCIACION_COLOR_CLIENTES",
                column: "colorId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_ASOCIACION_COLOR_CLIENTES_customizaElementoId",
                table: "BOFF_ASOCIACION_COLOR_CLIENTES",
                column: "customizaElementoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CLIENTES_locacionId",
                table: "BOFF_CLIENTES",
                column: "locacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CLIENTES_tipoDocumentoId",
                table: "BOFF_CLIENTES",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CLIENTES_tipoPersonaId",
                table: "BOFF_CLIENTES",
                column: "tipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_COLORES_clienteId",
                table: "BOFF_COLORES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CONFIG_CLIENTES_clienteId",
                table: "BOFF_CONFIG_CLIENTES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CUENTAS_clienteId",
                table: "BOFF_CUENTAS",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CUENTAS_AGENTE_cuentaId",
                table: "BOFF_CUENTAS_AGENTE",
                column: "cuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_CUENTAS_AGENTE_tipoDocumentoId",
                table: "BOFF_CUENTAS_AGENTE",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_ESTADO_PROCESAL_DOCUMENTOS_estatusProcesoId",
                table: "BOFF_ESTADO_PROCESAL_DOCUMENTOS",
                column: "estatusProcesoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_ESTADO_PROCESAL_DOCUMENTOS_tipoExpDocumentoId",
                table: "BOFF_ESTADO_PROCESAL_DOCUMENTOS",
                column: "tipoExpDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_ESTADO_PROCESAL_DOCUMENTOS_usuarioId",
                table: "BOFF_ESTADO_PROCESAL_DOCUMENTOS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_HIST_CONTRASENAS_usuarioId",
                table: "BOFF_HIST_CONTRASENAS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_HIST_CONTRASENAS_validacionId",
                table: "BOFF_HIST_CONTRASENAS",
                column: "validacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFIL_ROLES_perfilId",
                table: "BOFF_PERFIL_ROLES",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFIL_ROLES_rolId",
                table: "BOFF_PERFIL_ROLES",
                column: "rolId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFIL_ROLES_usuarioId",
                table: "BOFF_PERFIL_ROLES",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFILES_PERMISOS_objetoId",
                table: "BOFF_PERFILES_PERMISOS",
                column: "objetoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFILES_PERMISOS_perfilId",
                table: "BOFF_PERFILES_PERMISOS",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_PERFILES_PERMISOS_permisoId",
                table: "BOFF_PERFILES_PERMISOS",
                column: "permisoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_REPRESENTANTES_clienteId",
                table: "BOFF_REPRESENTANTES",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_REPRESENTANTES_tipoDocumentoId",
                table: "BOFF_REPRESENTANTES",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_SESIONES_ACTIVAS_usuarioId",
                table: "BOFF_SESIONES_ACTIVAS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_SESIONES_ACTIVAS_validacionId",
                table: "BOFF_SESIONES_ACTIVAS",
                column: "validacionId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_SESIONES_ERRONEAS_usuarioId",
                table: "BOFF_SESIONES_ERRONEAS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_SESIONES_OBJETOS_objetoId",
                table: "BOFF_SESIONES_OBJETOS",
                column: "objetoId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR_tipoEtapaMedidaCautelarId",
                table: "BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR",
                column: "tipoEtapaMedidaCautelarId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIO_CUENTAS_cuentaId",
                table: "BOFF_USUARIO_CUENTAS",
                column: "cuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIO_CUENTAS_usuarioId",
                table: "BOFF_USUARIO_CUENTAS",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIOS_clienteId",
                table: "BOFF_USUARIOS",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIOS_respuestaId",
                table: "BOFF_USUARIOS",
                column: "respuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIOS_rolId",
                table: "BOFF_USUARIOS",
                column: "rolId");

            migrationBuilder.CreateIndex(
                name: "IX_BOFF_USUARIOS_tipoDocumentoId",
                table: "BOFF_USUARIOS",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_BOTS_procesoBotId",
                table: "GBOT_BOTS",
                column: "procesoBotId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_BOTS_tipoAmbienteId",
                table: "GBOT_BOTS",
                column: "tipoAmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_GESTION_BOTS_botId",
                table: "GBOT_HIST_GESTION_BOTS",
                column: "botId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_GESTION_BOTS_objetoId",
                table: "GBOT_HIST_GESTION_BOTS",
                column: "objetoId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_GESTION_BOTS_tipoDocumentoId",
                table: "GBOT_HIST_GESTION_BOTS",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_LOG_BOTS_botId",
                table: "GBOT_HIST_LOG_BOTS",
                column: "botId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_LOG_BOTS_logCategoriaId",
                table: "GBOT_HIST_LOG_BOTS",
                column: "logCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_LOG_BOTS_logEventoId",
                table: "GBOT_HIST_LOG_BOTS",
                column: "logEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_LOG_BOTS_logInteraccionId",
                table: "GBOT_HIST_LOG_BOTS",
                column: "logInteraccionId");

            migrationBuilder.CreateIndex(
                name: "IX_GBOT_HIST_LOG_BOTS_tipoDocumentoId",
                table: "GBOT_HIST_LOG_BOTS",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_GIBD_AUDITORIA_TABLAS_tablaId",
                table: "GIBD_AUDITORIA_TABLAS",
                column: "tablaId");

            migrationBuilder.CreateIndex(
                name: "IX_GIBD_TABLAS_procesoId",
                table: "GIBD_TABLAS",
                column: "procesoId");

            migrationBuilder.CreateIndex(
                name: "IX_GIBD_TABLAS_tipoAmbienteId",
                table: "GIBD_TABLAS",
                column: "tipoAmbienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APLI_ACTUACIONES_EXPEDIENTES");

            migrationBuilder.DropTable(
                name: "APLI_ASIGNACIONES");

            migrationBuilder.DropTable(
                name: "APLI_DESPACHOS");

            migrationBuilder.DropTable(
                name: "APLI_DETALLE_EXPEDIENTE_EVENTOS");

            migrationBuilder.DropTable(
                name: "APLI_DIRECTORIOS");

            migrationBuilder.DropTable(
                name: "APLI_DIVISAS");

            migrationBuilder.DropTable(
                name: "APLI_ESTADO_COBROS");

            migrationBuilder.DropTable(
                name: "APLI_EXP_DOCUMENTOS");

            migrationBuilder.DropTable(
                name: "APLI_EXPEDIENTE_BITACORA");

            migrationBuilder.DropTable(
                name: "APLI_FECHAS");

            migrationBuilder.DropTable(
                name: "APLI_JUZGADO_EXPEDIENTES");

            migrationBuilder.DropTable(
                name: "APLI_MEDIDA_CAUTELAR_EXPEDIENTES");

            migrationBuilder.DropTable(
                name: "APLI_PAGARES_EXPEDIENTES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_AVALUOS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_CONTACTOS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_DEUDAS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_DILIGENCIAS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_REPORTES");

            migrationBuilder.DropTable(
                name: "APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE");

            migrationBuilder.DropTable(
                name: "ASIC_EXPEDIENTE_CARGA_ERRORES");

            migrationBuilder.DropTable(
                name: "ASIC_MASIVA_LOTE_CARGA_ERRORES");

            migrationBuilder.DropTable(
                name: "BEND_ACTIVIDADES");

            migrationBuilder.DropTable(
                name: "BEND_CAMPO_CLIENTES");

            migrationBuilder.DropTable(
                name: "BEND_CAT_ACTIVIDADES_WS");

            migrationBuilder.DropTable(
                name: "BEND_DECEVAL");

            migrationBuilder.DropTable(
                name: "BEND_ESTADO_ELECTRONICOS_RJ");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_BIENES_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_SALARIOS_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_BUSQ_VEHICULOS_DETALLES");

            migrationBuilder.DropTable(
                name: "BEND_HIST_RAMA_JUDICIAL");

            migrationBuilder.DropTable(
                name: "BEND_HIST_VALIDACIONES");

            migrationBuilder.DropTable(
                name: "BEND_TBLETAPAS");

            migrationBuilder.DropTable(
                name: "BEND_USUARIOS");

            migrationBuilder.DropTable(
                name: "BOFF_ASOCIACION_COLOR_CLIENTES");

            migrationBuilder.DropTable(
                name: "BOFF_CONFIG_CLIENTES");

            migrationBuilder.DropTable(
                name: "BOFF_CUENTAS_AGENTE");

            migrationBuilder.DropTable(
                name: "BOFF_ESTADO_PROCESAL_DOCUMENTOS");

            migrationBuilder.DropTable(
                name: "BOFF_HIST_CONTRASENAS");

            migrationBuilder.DropTable(
                name: "BOFF_HIST_SESIONES_ACTIVAS");

            migrationBuilder.DropTable(
                name: "BOFF_HIST_SESIONES_ERRONEAS");

            migrationBuilder.DropTable(
                name: "BOFF_PERFIL_ROLES");

            migrationBuilder.DropTable(
                name: "BOFF_PERFILES_PERMISOS");

            migrationBuilder.DropTable(
                name: "BOFF_SESIONES_ACTIVAS");

            migrationBuilder.DropTable(
                name: "BOFF_SESIONES_ERRONEAS");

            migrationBuilder.DropTable(
                name: "BOFF_SESIONES_OBJETOS");

            migrationBuilder.DropTable(
                name: "BOFF_USUARIO_CUENTAS");

            migrationBuilder.DropTable(
                name: "GBOT_HIST_GESTION_BOTS");

            migrationBuilder.DropTable(
                name: "GBOT_HIST_LOG_BOTS");

            migrationBuilder.DropTable(
                name: "GBOT_LOG_FUENTES");

            migrationBuilder.DropTable(
                name: "GIBD_AUDITORIA_TABLAS");

            migrationBuilder.DropTable(
                name: "INVB_TIPO_INMUEBLES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_ASIGNACIONES");

            migrationBuilder.DropTable(
                name: "APLI_EVENTOS");

            migrationBuilder.DropTable(
                name: "BOFF_TIPO_BITACORA");

            migrationBuilder.DropTable(
                name: "BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR");

            migrationBuilder.DropTable(
                name: "BOFF_TIPO_MEDIDAS_CAUTELARES");

            migrationBuilder.DropTable(
                name: "APLI_PAGARES");

            migrationBuilder.DropTable(
                name: "APLI_VENCIMIENTO_CONTRASENIAS");

            migrationBuilder.DropTable(
                name: "BEND_PLANTILLA_CAMPOS");

            migrationBuilder.DropTable(
                name: "BEND_DEUDOR_DECEVAL");

            migrationBuilder.DropTable(
                name: "BEND_DEUDOR_BIEN");

            migrationBuilder.DropTable(
                name: "BEND_DEUDOR_SALARIO");

            migrationBuilder.DropTable(
                name: "BEND_GARANTIA_FAVORES");

            migrationBuilder.DropTable(
                name: "BEND_LIMITACION_PROPIEDADES");

            migrationBuilder.DropTable(
                name: "BEND_DEUDOR_VEHICULO");

            migrationBuilder.DropTable(
                name: "APLI_JUZGADOS");

            migrationBuilder.DropTable(
                name: "BEND_DEUDOR_RAMA_JUDICIAL");

            migrationBuilder.DropTable(
                name: "BOFF_COLORES");

            migrationBuilder.DropTable(
                name: "BEND_CUSTOMIZA_ELEMENTOS");

            migrationBuilder.DropTable(
                name: "APLI_ESTATUS_PROCESOS");

            migrationBuilder.DropTable(
                name: "BEND_TIPO_EXP_DOCUMENTOS");

            migrationBuilder.DropTable(
                name: "BOFF_PERFILES");

            migrationBuilder.DropTable(
                name: "BOFF_PERMISOS");

            migrationBuilder.DropTable(
                name: "BEND_VALIDACIONES");

            migrationBuilder.DropTable(
                name: "BEND_OBJETOS");

            migrationBuilder.DropTable(
                name: "GBOT_BOTS");

            migrationBuilder.DropTable(
                name: "GBOT_LOG_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "GBOT_LOG_EVENTOS");

            migrationBuilder.DropTable(
                name: "GBOT_LOG_INTERACCIONES");

            migrationBuilder.DropTable(
                name: "GIBD_TABLAS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_EVENTOS");

            migrationBuilder.DropTable(
                name: "BOFF_TIPO_ETAPA_MEDIDA_CAUTELAR");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_PAGARES");

            migrationBuilder.DropTable(
                name: "APLI_LOCACION_JUZGADOS");

            migrationBuilder.DropTable(
                name: "BEND_DEUDORES");

            migrationBuilder.DropTable(
                name: "ASIC_EXPEDIENTES");

            migrationBuilder.DropTable(
                name: "BEND_TIPO_OBJETOS");

            migrationBuilder.DropTable(
                name: "GBOT_PROCESOS_BOTS");

            migrationBuilder.DropTable(
                name: "GIBD_TIPO_AMBIENTES");

            migrationBuilder.DropTable(
                name: "GIBD_PROCESOS_TABLAS");

            migrationBuilder.DropTable(
                name: "APLI_SUBTIPO_JUZGADOS");

            migrationBuilder.DropTable(
                name: "APLI_ABOGADOS");

            migrationBuilder.DropTable(
                name: "BOFF_APODERADOS");

            migrationBuilder.DropTable(
                name: "ASIC_MASIVA_CABECERAS");

            migrationBuilder.DropTable(
                name: "BOFF_CUENTAS");

            migrationBuilder.DropTable(
                name: "APLI_DEMANDADOS");

            migrationBuilder.DropTable(
                name: "APLI_DEMANDANTES");

            migrationBuilder.DropTable(
                name: "APLI_ESTADO_PROCESAL");

            migrationBuilder.DropTable(
                name: "BOFF_REPRESENTANTES");

            migrationBuilder.DropTable(
                name: "APLI_SUBETAPAS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_CUANTIAS");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_JUZGADOS");

            migrationBuilder.DropTable(
                name: "BOFF_USUARIOS");

            migrationBuilder.DropTable(
                name: "ASIC_MASIVA_LOTES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_ETAPAS");

            migrationBuilder.DropTable(
                name: "BEND_RESPUESTA_SESIONES");

            migrationBuilder.DropTable(
                name: "BOFF_ROLES");

            migrationBuilder.DropTable(
                name: "BOFF_CLIENTES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_PROCESOS");

            migrationBuilder.DropTable(
                name: "BEND_PREGUNTA_SESIONES");

            migrationBuilder.DropTable(
                name: "APLI_LOCACIONES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_DOCUMENTOS");

            migrationBuilder.DropTable(
                name: "ASIC_SEDES");

            migrationBuilder.DropTable(
                name: "APLI_TIPO_PERSONAS");
        }
    }
}
