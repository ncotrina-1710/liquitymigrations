using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public partial class DdbbLiquittyContext : DbContext
    {
        public DdbbLiquittyContext()
        {
        }

        public DdbbLiquittyContext(DbContextOptions<DdbbLiquittyContext> options)
            : base(options)
        {
        }
        public virtual DbSet<ApliAbogado> ApliAbogados { get; set; }

        public virtual DbSet<ApliActuacionesExpediente> ApliActuacionesExpedientes { get; set; }

        public virtual DbSet<ApliAsignacione> ApliAsignaciones { get; set; }

        public virtual DbSet<ApliDemandado> ApliDemandados { get; set; }

        public virtual DbSet<ApliDemandante> ApliDemandantes { get; set; }

        public virtual DbSet<ApliDespacho> ApliDespachos { get; set; }

        public virtual DbSet<ApliDetalleExpedienteEvento> ApliDetalleExpedienteEventos { get; set; }

        public virtual DbSet<ApliDirectorio> ApliDirectorios { get; set; }

        public virtual DbSet<ApliDivisa> ApliDivisas { get; set; }

        public virtual DbSet<ApliEstadoCobro> ApliEstadoCobros { get; set; }

        public virtual DbSet<ApliEstadoProcesal> ApliEstadoProcesals { get; set; }

        public virtual DbSet<ApliEstatusProceso> ApliEstatusProcesos { get; set; }

        public virtual DbSet<ApliEvento> ApliEventos { get; set; }

        public virtual DbSet<ApliExpDocumento> ApliExpDocumentos { get; set; }

        public virtual DbSet<ApliExpedienteBitacora> ApliExpedienteBitacoras { get; set; }

        public virtual DbSet<ApliFecha> ApliFechas { get; set; }

        public virtual DbSet<ApliJuzgado> ApliJuzgados { get; set; }

        public virtual DbSet<ApliJuzgadoExpediente> ApliJuzgadoExpedientes { get; set; }

        public virtual DbSet<ApliLocacionJuzgado> ApliLocacionJuzgados { get; set; }

        public virtual DbSet<ApliLocacione> ApliLocaciones { get; set; }

        public virtual DbSet<ApliMedidaCautelarExpediente> ApliMedidaCautelarExpedientes { get; set; }

        public virtual DbSet<ApliPagare> ApliPagares { get; set; }

        public virtual DbSet<ApliPagaresExpediente> ApliPagaresExpedientes { get; set; }

        public virtual DbSet<ApliSubetapa> ApliSubetapas { get; set; }

        public virtual DbSet<ApliSubtipoJuzgado> ApliSubtipoJuzgados { get; set; }

        public virtual DbSet<ApliTipoAsignacione> ApliTipoAsignaciones { get; set; }

        public virtual DbSet<ApliTipoAvaluo> ApliTipoAvaluos { get; set; }

        public virtual DbSet<ApliTipoContacto> ApliTipoContactos { get; set; }

        public virtual DbSet<ApliTipoCuantia> ApliTipoCuantias { get; set; }

        public virtual DbSet<ApliTipoDeuda> ApliTipoDeudas { get; set; }

        public virtual DbSet<ApliTipoDiligencia> ApliTipoDiligencias { get; set; }

        public virtual DbSet<ApliTipoDocumento> ApliTipoDocumentos { get; set; }

        public virtual DbSet<ApliTipoEtapa> ApliTipoEtapas { get; set; }

        public virtual DbSet<ApliTipoEvento> ApliTipoEventos { get; set; }

        public virtual DbSet<ApliTipoJuzgado> ApliTipoJuzgados { get; set; }

        public virtual DbSet<ApliTipoPagare> ApliTipoPagares { get; set; }

        public virtual DbSet<ApliTipoPersona> ApliTipoPersonas { get; set; }

        public virtual DbSet<ApliTipoProceso> ApliTipoProcesos { get; set; }

        public virtual DbSet<ApliTipoReporte> ApliTipoReportes { get; set; }

        public virtual DbSet<ApliVencimientoContrasenia> ApliVencimientoContrasenias { get; set; }

        public virtual DbSet<ApliVencimientoContraseniasCliente> ApliVencimientoContraseniasClientes { get; set; }

        public virtual DbSet<AsicExpediente> AsicExpedientes { get; set; }

        public virtual DbSet<AsicExpedienteCargaErrore> AsicExpedienteCargaErrores { get; set; }

        public virtual DbSet<AsicMasivaCabecera> AsicMasivaCabeceras { get; set; }

        public virtual DbSet<AsicMasivaLote> AsicMasivaLotes { get; set; }

        public virtual DbSet<AsicMasivaLoteCargaErrore> AsicMasivaLoteCargaErrores { get; set; }

        public virtual DbSet<AsicSede> AsicSedes { get; set; }

        public virtual DbSet<BendActividade> BendActividades { get; set; }

        public virtual DbSet<BendCampoCliente> BendCampoClientes { get; set; }

        public virtual DbSet<BendCatActividadesW> BendCatActividadesWs { get; set; }

        public virtual DbSet<BendCustomizaElemento> BendCustomizaElementos { get; set; }

        public virtual DbSet<BendDeceval> BendDecevals { get; set; }

        public virtual DbSet<BendDeudorBien> BendDeudorBiens { get; set; }

        public virtual DbSet<BendDeudorDeceval> BendDeudorDecevals { get; set; }

        public virtual DbSet<BendDeudorRamaJudicial> BendDeudorRamaJudicials { get; set; }

        public virtual DbSet<BendDeudorSalario> BendDeudorSalarios { get; set; }

        public virtual DbSet<BendDeudorVehiculo> BendDeudorVehiculos { get; set; }

        public virtual DbSet<BendDeudore> BendDeudores { get; set; }

        public virtual DbSet<BendEstadoElectronicosRj> BendEstadoElectronicosRjs { get; set; }

        public virtual DbSet<BendGarantiaFavore> BendGarantiaFavores { get; set; }

        public virtual DbSet<BendHistBusqBienesDetalle> BendHistBusqBienesDetalles { get; set; }

        public virtual DbSet<BendHistBusqSalariosDetalle> BendHistBusqSalariosDetalles { get; set; }

        public virtual DbSet<BendHistBusqVehiculosDetalle> BendHistBusqVehiculosDetalles { get; set; }

        public virtual DbSet<BendHistRamaJudicial> BendHistRamaJudicials { get; set; }

        public virtual DbSet<BendHistValidacione> BendHistValidaciones { get; set; }

        public virtual DbSet<BendLimitacionPropiedade> BendLimitacionPropiedades { get; set; }

        public virtual DbSet<BendObjeto> BendObjetos { get; set; }

        public virtual DbSet<BendPlantillaCampo> BendPlantillaCampos { get; set; }

        public virtual DbSet<BendPreguntaSesione> BendPreguntaSesiones { get; set; }

        public virtual DbSet<BendRespuestaSesione> BendRespuestaSesiones { get; set; }

        public virtual DbSet<BendTbletapa> BendTbletapas { get; set; }

        public virtual DbSet<BendTipoExpDocumento> BendTipoExpDocumentos { get; set; }

        public virtual DbSet<BendTipoObjeto> BendTipoObjetos { get; set; }

        public virtual DbSet<BendUsuario> BendUsuarios { get; set; }

        public virtual DbSet<BendValidacione> BendValidaciones { get; set; }

        public virtual DbSet<BoffApoderado> BoffApoderados { get; set; }

        public virtual DbSet<BoffAsociacionColorCliente> BoffAsociacionColorClientes { get; set; }

        public virtual DbSet<BoffCliente> BoffClientes { get; set; }

        public virtual DbSet<BoffColore> BoffColores { get; set; }

        public virtual DbSet<BoffConfigCliente> BoffConfigClientes { get; set; }

        public virtual DbSet<BoffCuenta> BoffCuentas { get; set; }

        public virtual DbSet<BoffCuentasAgente> BoffCuentasAgentes { get; set; }

        public virtual DbSet<BoffEstadoProcesalDocumento> BoffEstadoProcesalDocumentos { get; set; }

        public virtual DbSet<BoffHistContrasena> BoffHistContrasenas { get; set; }

        public virtual DbSet<BoffHistSesionesActiva> BoffHistSesionesActivas { get; set; }

        public virtual DbSet<BoffHistSesionesErronea> BoffHistSesionesErroneas { get; set; }

        public virtual DbSet<BoffPerfilRole> BoffPerfilRoles { get; set; }

        public virtual DbSet<BoffPerfile> BoffPerfiles { get; set; }

        public virtual DbSet<BoffPerfilesPermiso> BoffPerfilesPermisos { get; set; }

        public virtual DbSet<BoffPermiso> BoffPermisos { get; set; }

        public virtual DbSet<BoffRepresentante> BoffRepresentantes { get; set; }

        public virtual DbSet<BoffRole> BoffRoles { get; set; }

        public virtual DbSet<BoffSesionesActiva> BoffSesionesActivas { get; set; }

        public virtual DbSet<BoffSesionesErronea> BoffSesionesErroneas { get; set; }

        public virtual DbSet<BoffSesionesObjeto> BoffSesionesObjetos { get; set; }

        public virtual DbSet<BoffTipoBitacora> BoffTipoBitacoras { get; set; }

        public virtual DbSet<BoffTipoEtapaMedidaCautelar> BoffTipoEtapaMedidaCautelars { get; set; }

        public virtual DbSet<BoffTipoMedidasCautelare> BoffTipoMedidasCautelares { get; set; }

        public virtual DbSet<BoffTipoSubetapaMedidaCautelar> BoffTipoSubetapaMedidaCautelars { get; set; }

        public virtual DbSet<BoffUsuario> BoffUsuarios { get; set; }

        public virtual DbSet<BoffUsuarioCuenta> BoffUsuarioCuentas { get; set; }

        public virtual DbSet<GbotBot> GbotBots { get; set; }

        public virtual DbSet<GbotHistGestionBot> GbotHistGestionBots { get; set; }

        public virtual DbSet<GbotHistLogBot> GbotHistLogBots { get; set; }

        public virtual DbSet<GbotLogCategoria> GbotLogCategorias { get; set; }

        public virtual DbSet<GbotLogEvento> GbotLogEventos { get; set; }

        public virtual DbSet<GbotLogFuente> GbotLogFuentes { get; set; }

        public virtual DbSet<GbotLogInteraccione> GbotLogInteracciones { get; set; }

        public virtual DbSet<GbotProcesosBot> GbotProcesosBots { get; set; }

        public virtual DbSet<GibdAuditoriaTabla> GibdAuditoriaTablas { get; set; }

        public virtual DbSet<GibdProcesosTabla> GibdProcesosTablas { get; set; }

        public virtual DbSet<GibdTabla> GibdTablas { get; set; }

        public virtual DbSet<GibdTipoAmbiente> GibdTipoAmbientes { get; set; }

        public virtual DbSet<InvbTipoInmueble> InvbTipoInmuebles { get; set; }
        public virtual DbSet<BendHistBusqCabecera> BendHistBusqCabeceras { get; set; }
        public virtual DbSet<BendHistBusqCuentasBancariasDetalle> BendHistBusqCuentasBancariasDetalles { get; set; }
        public virtual DbSet<BendHistBusqEstablecimientoComerciosDetalle> BendHistBusqEstablecimientoComerciosDetalles { get; set; }
        public virtual DbSet<BendHistBusqOtrosDetalle> BendHistBusqOtrosDetalles { get; set; }
        public virtual DbSet<BendHistBusqRemanentesDetalle> BendHistBusqRemanentesDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApliAbogado>(entity =>
            {
                entity.HasKey(e => e.IdAbogado).HasName("PK__APLI_ABO__22D2E6DEABCB5A29");

                entity.ToTable("APLI_ABOGADOS");

                entity.Property(e => e.IdAbogado).HasColumnName("idAbogado");
                entity.Property(e => e.ApellidosAbogado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("apellidosAbogado");
                entity.Property(e => e.EstadoAbogado).HasColumnName("estadoAbogado");
                entity.Property(e => e.FecFinLicenciaAbogado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecFinLicenciaAbogado");
                entity.Property(e => e.FecInicioLicenciaAbogado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioLicenciaAbogado");
                entity.Property(e => e.FecNacimientoAbogado)
                    .HasColumnType("date")
                    .HasColumnName("fecNacimientoAbogado");
                entity.Property(e => e.NombresAbogado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombresAbogado");
                entity.Property(e => e.TarjetaProfesional)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("tarjetaProfesional");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Usuario).WithMany(p => p.ApliAbogados)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ABOGADO_USUARIOS_idUsuario");
            });

            modelBuilder.Entity<ApliActuacionesExpediente>(entity =>
            {
                entity.HasKey(e => e.IdActuacionExpediente).HasName("PK__APLI_ACT__17FAAC5164A260C1");

                entity.ToTable("APLI_ACTUACIONES_EXPEDIENTES");

                entity.Property(e => e.IdActuacionExpediente).HasColumnName("idActuacionExpediente");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActuacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActuacion");
                entity.Property(e => e.FecCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.FecEstadoActuacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecEstadoActuacion");
                entity.Property(e => e.FecGestionActuacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecGestionActuacion");
                entity.Property(e => e.NombreActuacionExpediente)
                    .IsUnicode(false)
                    .HasColumnName("nombreActuacionExpediente");
                entity.Property(e => e.SubEtapaId).HasColumnName("subEtapaId");
                entity.Property(e => e.UrlDocAdjunto).HasColumnName("urlDocAdjunto");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliActuacionesExpedientes)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACTUACION_EXPEDIENTES_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.SubEtapa).WithMany(p => p.ApliActuacionesExpedientes)
                    .HasForeignKey(d => d.SubEtapaId)
                    .HasConstraintName("FK_ACTUACION_EXPEDIENTES_SUBETAPA_idSubEtapa");
            });

            modelBuilder.Entity<ApliAsignacione>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion).HasName("PK__APLI_ASI__E1714478F3230806");

                entity.ToTable("APLI_ASIGNACIONES");

                entity.Property(e => e.IdAsignacion).HasColumnName("idAsignacion");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActualizacionAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionAsignacion");
                entity.Property(e => e.FecCreacionAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionAsignacion");
                entity.Property(e => e.TipoAsignacionId).HasColumnName("tipoAsignacionId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliAsignaciones)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNACIONES_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.TipoAsignacion).WithMany(p => p.ApliAsignaciones)
                    .HasForeignKey(d => d.TipoAsignacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNACIONES_TIPOASIGNACION_idTipoAsignacion");

                entity.HasOne(d => d.Usuario).WithMany(p => p.ApliAsignaciones)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASIGNACIONES_USUARIOS_idUsuario");
            });

            modelBuilder.Entity<ApliDemandado>(entity =>
            {
                entity.HasKey(e => e.IdDemandado).HasName("PK__APLI_DEM__AFDB382450E1EEEA");

                entity.ToTable("APLI_DEMANDADOS");

                entity.Property(e => e.IdDemandado).HasColumnName("idDemandado");
                entity.Property(e => e.ApellidoMaternoDemandado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("apellidoMaternoDemandado");
                entity.Property(e => e.ApellidoPaternoDemandado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("apellidoPaternoDemandado");
                entity.Property(e => e.DireccionDemandado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("direccionDemandado");
                entity.Property(e => e.EmailDemandado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emailDemandado");
                entity.Property(e => e.NombreDemandado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreDemandado");
                entity.Property(e => e.NumeroDocumentoDemandado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoDemandado");
                entity.Property(e => e.TelefonoDemandado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoDemandado");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.ApliDemandados)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEMANDADO_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<ApliDemandante>(entity =>
            {
                entity.HasKey(e => e.IdDemandante).HasName("PK__APLI_DEM__46019B4F2E357C73");

                entity.ToTable("APLI_DEMANDANTES");

                entity.Property(e => e.IdDemandante).HasColumnName("idDemandante");
                entity.Property(e => e.NombreDemandante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreDemandante");
                entity.Property(e => e.NumeroDocumentoDemandante)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoDemandante");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");
                entity.Property(e => e.TipoPersonaId).HasColumnName("tipoPersonaId");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.ApliDemandantes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEMANDANTE_TIPODOCUMENTO_idTipoDocumento");

                entity.HasOne(d => d.TipoPersona).WithMany(p => p.ApliDemandantes)
                    .HasForeignKey(d => d.TipoPersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEMANDANTE_TIPOPERSONA_idTipoPersona");
            });

            modelBuilder.Entity<ApliDespacho>(entity =>
            {
                entity.HasKey(e => e.IdDespacho).HasName("PK__APLI_DES__61E931FA36D2DAA1");

                entity.ToTable("APLI_DESPACHOS");

                entity.Property(e => e.IdDespacho).HasColumnName("idDespacho");
                entity.Property(e => e.NombreDespacho)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreDespacho");
            });

            modelBuilder.Entity<ApliDetalleExpedienteEvento>(entity =>
            {
                entity.HasKey(e => e.IdDetalleExpedienteEvento).HasName("PK__APLI_DET__B26634A37B07502D");

                entity.ToTable("APLI_DETALLE_EXPEDIENTE_EVENTOS");

                entity.Property(e => e.IdDetalleExpedienteEvento).HasColumnName("idDetalleExpedienteEvento");
                entity.Property(e => e.ArchivoAdjunto)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("archivoAdjunto");
                entity.Property(e => e.ControlWeb).HasColumnName("controlWeb");
                entity.Property(e => e.DescripcionDetalleExpedienteEvento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcionDetalleExpedienteEvento");
                entity.Property(e => e.EstadoExpedienteEvento).HasColumnName("estadoExpedienteEvento");
                entity.Property(e => e.EventoId).HasColumnName("eventoId");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActualizacionExpedienteEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionExpedienteEvento");
                entity.Property(e => e.FecAsignadaFin)
                    .HasColumnType("date")
                    .HasColumnName("fecAsignadaFin");
                entity.Property(e => e.FecAsignadaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecAsignadaInicio");
                entity.Property(e => e.FecCreacionExpedienteEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionExpedienteEvento");
                entity.Property(e => e.HoraAsignadaFin).HasColumnName("horaAsignadaFin");
                entity.Property(e => e.HoraAsignadaInicio).HasColumnName("horaAsignadaInicio");
                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nombreUsuario");
                entity.Property(e => e.Observacion)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Evento).WithMany(p => p.ApliDetalleExpedienteEventos)
                    .HasForeignKey(d => d.EventoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXPEDIENTEEVENTO_EVENTO_idEvento");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliDetalleExpedienteEventos)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXPEDIENTEEVENTO_ASICEXPEDIENTE_idExpediente");

                entity.HasOne(d => d.Usuario).WithMany(p => p.ApliDetalleExpedienteEventos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_EXPEDIENTEEVENTO_USUARIO_idUsuario");
            });

            modelBuilder.Entity<ApliDirectorio>(entity =>
            {
                entity.HasKey(e => e.IdDirectorio).HasName("PK__APLI_DIR__14C666632E855429");

                entity.ToTable("APLI_DIRECTORIOS");

                entity.Property(e => e.IdDirectorio).HasColumnName("idDirectorio");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.EmailDirectorio)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("emailDirectorio");
                entity.Property(e => e.EstadoDirectorio).HasColumnName("estadoDirectorio");
                entity.Property(e => e.FecActualizacionDirectorio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionDirectorio");
                entity.Property(e => e.FecCreacionDirectorio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionDirectorio");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.IdentificacionDirectorio)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("identificacionDirectorio");
                entity.Property(e => e.TelefonoDirectorio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoDirectorio");
                entity.Property(e => e.TipoDirectorio)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoDirectorio");
                entity.Property(e => e.WhatsAppDirectorio)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("whatsAppDirectorio");

                entity.HasOne(d => d.Cliente).WithMany(p => p.ApliDirectorios)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DIRECTORIOS_CLIENTES_idCliente");
            });

            modelBuilder.Entity<ApliDivisa>(entity =>
            {
                entity.HasKey(e => e.IdDivisa).HasName("PK__APLI_DIV__96114A561016D848");

                entity.ToTable("APLI_DIVISAS");

                entity.Property(e => e.IdDivisa).HasColumnName("idDivisa");
                entity.Property(e => e.AbreviacionDivisa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("abreviacionDivisa");
                entity.Property(e => e.NombreDivisa)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreDivisa");
                entity.Property(e => e.SimboloDivisa)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("simboloDivisa");
            });

            modelBuilder.Entity<ApliEstadoCobro>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCobro).HasName("PK__APLI_EST__383D24944BAC210A");

                entity.ToTable("APLI_ESTADO_COBROS");

                entity.Property(e => e.IdEstadoCobro).HasColumnName("idEstadoCobro");
                entity.Property(e => e.NombreEstadoCobro)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreEstadoCobro");
            });

            modelBuilder.Entity<ApliEstadoProcesal>(entity =>
            {
                entity.HasKey(e => e.IdEstadoProcesal).HasName("PK__APLI_EST__785BE16ED1AF2E9C");

                entity.ToTable("APLI_ESTADO_PROCESAL");

                entity.Property(e => e.IdEstadoProcesal).HasColumnName("idEstadoProcesal");
                entity.Property(e => e.EstadoEstadoProcesal).HasColumnName("estadoEstadoProcesal");
                entity.Property(e => e.FecActualizacionEstadoProcesal)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionEstadoProcesal");
                entity.Property(e => e.FecCreacionEstadoProcesal)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionEstadoProcesal");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreEstadoProcesal)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreEstadoProcesal");
                entity.Property(e => e.NroOrdenEstado).HasColumnName("nroOrdenEstado");
                entity.Property(e => e.TipoEtapaId).HasColumnName("tipoEtapaId");

                entity.HasOne(d => d.TipoEtapa).WithMany(p => p.ApliEstadoProcesals)
                    .HasForeignKey(d => d.TipoEtapaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESTADO_TIPOETAPA_idTipoEtapa");
            });

            modelBuilder.Entity<ApliEstatusProceso>(entity =>
            {
                entity.HasKey(e => e.IdEstatusProceso).HasName("PK__APLI_EST__4A7993648C734F85");

                entity.ToTable("APLI_ESTATUS_PROCESOS");

                entity.Property(e => e.IdEstatusProceso).HasColumnName("idEstatusProceso");
                entity.Property(e => e.EstadoEstatusProceso).HasColumnName("estadoEstatusProceso");
                entity.Property(e => e.EstadoProcesalId).HasColumnName("estadoProcesalId");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActualizacionEstatusProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionEstatusProceso");
                entity.Property(e => e.FecCreacionEstatusProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionEstatusProceso");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.EstadoProcesal).WithMany(p => p.ApliEstatusProcesos)
                    .HasForeignKey(d => d.EstadoProcesalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESOS_ESTADOS_idEstadoProcesal");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliEstatusProcesos)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESOS_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.Usuario).WithMany(p => p.ApliEstatusProcesos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESOS_USUARIO_idUsuario");
            });

            modelBuilder.Entity<ApliEvento>(entity =>
            {
                entity.HasKey(e => e.IdEvento).HasName("PK__APLI_EVE__C8DC7BDA0EFC2C12");

                entity.ToTable("APLI_EVENTOS");

                entity.Property(e => e.IdEvento).HasColumnName("idEvento");
                entity.Property(e => e.CodigoEvento)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("codigoEvento");
                entity.Property(e => e.ControlWeb).HasColumnName("controlWeb");
                entity.Property(e => e.EstadoEvento).HasColumnName("estadoEvento");
                entity.Property(e => e.FecActualizacionEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionEvento");
                entity.Property(e => e.FecCreacionEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionEvento");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreEvento)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreEvento");
                entity.Property(e => e.TipoEventoId).HasColumnName("tipoEventoId");

                entity.HasOne(d => d.TipoEvento).WithMany(p => p.ApliEventos)
                    .HasForeignKey(d => d.TipoEventoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVENTO_TIPOEVENTO_idTipoEvento");
            });

            modelBuilder.Entity<ApliExpDocumento>(entity =>
            {
                entity.HasKey(e => e.IdExpDocumento).HasName("PK__APLI_EXP__950B158F122AA2BC");

                entity.ToTable("APLI_EXP_DOCUMENTOS");

                entity.Property(e => e.IdExpDocumento).HasColumnName("idExpDocumento");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecCreacionExpDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionExpDocumento");
                entity.Property(e => e.TipoExpDocumentoId).HasColumnName("tipoExpDocumentoId");
                entity.Property(e => e.UrlDocAdjunto)
                    .HasMaxLength(400)
                    .HasColumnName("urlDocAdjunto");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliExpDocumentos)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENTO_EXPEDIENTES_idExpediente");

                entity.HasOne(d => d.TipoExpDocumento).WithMany(p => p.ApliExpDocumentos)
                    .HasForeignKey(d => d.TipoExpDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENTO_TIPOEXPDOCUMENTOS_idTipoExpDocumento");
            });

            modelBuilder.Entity<ApliExpedienteBitacora>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("APLI_EXPEDIENTE_BITACORA");

                entity.Property(e => e.DescripcionBitacora)
                    .IsUnicode(false)
                    .HasColumnName("descripcionBitacora");
                entity.Property(e => e.EstadoBitacora).HasColumnName("estadoBitacora");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecRegistro)
                    .HasColumnType("date")
                    .HasColumnName("fecRegistro");
                entity.Property(e => e.FecSeguimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecSeguimiento");
                entity.Property(e => e.HoraRegistro).HasColumnName("horaRegistro");
                entity.Property(e => e.IdBitacoraExpediente)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idBitacoraExpediente");
                entity.Property(e => e.TipoBitacoraId).HasColumnName("tipoBitacoraId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Expediente).WithMany()
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXPEDIENTE_BITACORA_idExpediente");

                entity.HasOne(d => d.TipoBitacora).WithMany()
                    .HasForeignKey(d => d.TipoBitacoraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOBITACORA_BITACORA_idTipoBitacora");
            });

            modelBuilder.Entity<ApliFecha>(entity =>
            {
                entity.HasKey(e => e.IdFecha).HasName("PK__APLI_FEC__65F2E8696C3D2123");

                entity.ToTable("APLI_FECHAS");

                entity.Property(e => e.IdFecha)
                    .ValueGeneratedNever()
                    .HasColumnName("idFecha");
                entity.Property(e => e.Annio).HasColumnName("annio");
                entity.Property(e => e.Dia).HasColumnName("dia");
                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");
                entity.Property(e => e.Mes).HasColumnName("mes");
            });

            modelBuilder.Entity<ApliJuzgado>(entity =>
            {
                entity.HasKey(e => e.IdJuzgado).HasName("PK__APLI_JUZ__95D0A920A2CF9067");

                entity.ToTable("APLI_JUZGADOS");

                entity.Property(e => e.IdJuzgado).HasColumnName("idJuzgado");
                entity.Property(e => e.CodigoJuzgado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("codigoJuzgado");
                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("correoElectronico");
                entity.Property(e => e.EstadoJuzgado).HasColumnName("estadoJuzgado");
                entity.Property(e => e.FecActualizacionJuzgado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionJuzgado");
                entity.Property(e => e.FecCreacionJuzgado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionJuzgado");
                entity.Property(e => e.LocacionJuzgadoId).HasColumnName("locacionJuzgadoId");
                entity.Property(e => e.NombreJuzgado)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombreJuzgado");
                entity.Property(e => e.NroJuzgado).HasColumnName("nroJuzgado");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.LocacionJuzgado).WithMany(p => p.ApliJuzgados)
                    .HasForeignKey(d => d.LocacionJuzgadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCACION_JUZGADOS_idLocacionJuzgado");
            });

            modelBuilder.Entity<ApliJuzgadoExpediente>(entity =>
            {
                entity.HasKey(e => e.IdJuzgadoExpediente).HasName("PK__APLI_JUZ__AEE78C8B254C5627");

                entity.ToTable("APLI_JUZGADO_EXPEDIENTES");

                entity.Property(e => e.IdJuzgadoExpediente).HasColumnName("idJuzgadoExpediente");
                entity.Property(e => e.AbogadoInicialJuzgadoExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("abogadoInicialJuzgadoExpediente");
                entity.Property(e => e.CiudadJuzgadoExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ciudadJuzgadoExpediente");
                entity.Property(e => e.DepartamentoJuzgadoExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("departamentoJuzgadoExpediente");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActualizacionjuzgadoExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionjuzgadoExpediente");
                entity.Property(e => e.FecCreacionJuzgadoExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionJuzgadoExpediente");
                entity.Property(e => e.JuzgadoId).HasColumnName("juzgadoId");
                entity.Property(e => e.JuzgadoOrigen)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("juzgadoOrigen");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliJuzgadoExpedientes)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JUZGADO_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.Juzgado).WithMany(p => p.ApliJuzgadoExpedientes)
                    .HasForeignKey(d => d.JuzgadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JUZGADO_EXPEDIENTE_idJuzgado");
            });

            modelBuilder.Entity<ApliLocacionJuzgado>(entity =>
            {
                entity.HasKey(e => e.IdLocacionJuzgado).HasName("PK__APLI_LOC__45234F404BED56B6");

                entity.ToTable("APLI_LOCACION_JUZGADOS");

                entity.Property(e => e.IdLocacionJuzgado).HasColumnName("idLocacionJuzgado");
                entity.Property(e => e.CiudadJuzgados)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ciudadJuzgados");
                entity.Property(e => e.DepartamentoJuzgado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("departamentoJuzgado");
                entity.Property(e => e.SubtipoJuzgadoId).HasColumnName("subtipoJuzgadoId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ZonaJuzgado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("zonaJuzgado");

                entity.HasOne(d => d.SubtipoJuzgado).WithMany(p => p.ApliLocacionJuzgados)
                    .HasForeignKey(d => d.SubtipoJuzgadoId)
                    .HasConstraintName("FK_LOCACION_SUBTIPO_JUZGADOS_idTipoJuzgado");
            });

            modelBuilder.Entity<ApliLocacione>(entity =>
            {
                entity.HasKey(e => e.IdLocacion).HasName("PK__APLI_LOC__C895F35ECA5E8F89");

                entity.ToTable("APLI_LOCACIONES");

                entity.Property(e => e.IdLocacion).HasColumnName("idLocacion");
                entity.Property(e => e.CiudadLocacion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ciudadLocacion");
                entity.Property(e => e.LatitudLocacion).HasColumnName("latitudLocacion");
                entity.Property(e => e.LongitudLocacion).HasColumnName("longitudLocacion");
                entity.Property(e => e.PaisLocacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("paisLocacion");
                entity.Property(e => e.Prefijo2Locacion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("prefijo2Locacion");
                entity.Property(e => e.Prefijo3Locacion)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("prefijo3Locacion");
                entity.Property(e => e.PrefijoNumericoLocacion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("prefijoNumericoLocacion");
                entity.Property(e => e.ProvinciaLocacion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("provinciaLocacion");
                entity.Property(e => e.RegionLocacion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("regionLocacion");
                entity.Property(e => e.SedeId).HasColumnName("sedeId");
                entity.Property(e => e.ZonaHorariaLocacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("zonaHorariaLocacion");

                entity.HasOne(d => d.Sede).WithMany(p => p.ApliLocaciones)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCACIONES_SEDES_idSede");
            });

            modelBuilder.Entity<ApliMedidaCautelarExpediente>(entity =>
            {
                entity.HasKey(e => e.IdMedidaCautelarExpediente).HasName("PK__APLI_MED__467AFCF466098B51");

                entity.ToTable("APLI_MEDIDA_CAUTELAR_EXPEDIENTES");

                entity.Property(e => e.IdMedidaCautelarExpediente).HasColumnName("idMedidaCautelarExpediente");
                entity.Property(e => e.CalendarioMedidaCautelarExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("calendarioMedidaCautelarExpediente");
                entity.Property(e => e.DemandadoId).HasColumnName("demandadoId");
                entity.Property(e => e.DetalleMedidaCautelar)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("detalleMedidaCautelar");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecCreacionedidaCautelarExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionedidaCautelarExpediente");
                entity.Property(e => e.FecGestionMedidaCautelarExpdiente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecGestionMedidaCautelarExpdiente");
                entity.Property(e => e.NumeroOficioMedidaCautelarExpediente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroOficioMedidaCautelarExpediente");
                entity.Property(e => e.TipoMedidaCautelarId).HasColumnName("tipoMedidaCautelarId");
                entity.Property(e => e.TipoSubetapaMedidaCautelarId).HasColumnName("tipoSubetapaMedidaCautelarId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValorAvaluoMedidaCautelarExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorAvaluoMedidaCautelarExpediente");
                entity.Property(e => e.ValorRemateMedidaCautelarExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorRemateMedidaCautelarExpediente");

                entity.HasOne(d => d.Demandado).WithMany(p => p.ApliMedidaCautelarExpedientes)
                    .HasForeignKey(d => d.DemandadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDIDACAUTELAR_DEMANDADO_idDemandado");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliMedidaCautelarExpedientes)
                    .HasForeignKey(d => d.ExpedienteId)
                    .HasConstraintName("FK_MEDIDACAUTELAR_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.TipoMedidaCautelar).WithMany(p => p.ApliMedidaCautelarExpedientes)
                    .HasForeignKey(d => d.TipoMedidaCautelarId)
                    .HasConstraintName("FK_TIPO_MEDIDACAUTELAR_EXPEDIENTE_idTipoMedidaCautelar");

                entity.HasOne(d => d.TipoSubetapaMedidaCautelar).WithMany(p => p.ApliMedidaCautelarExpedientes)
                    .HasForeignKey(d => d.TipoSubetapaMedidaCautelarId)
                    .HasConstraintName("FK_SUBETAPA_MEDIDACAUTELAR_EXPEDIENTE_idTipoSubetapaMedidaCautelar");
            });

            modelBuilder.Entity<ApliPagare>(entity =>
            {
                entity.HasKey(e => e.IdPagare).HasName("PK__APLI_PAG__74FD2A525E7DC319");

                entity.ToTable("APLI_PAGARES");

                entity.Property(e => e.IdPagare).HasColumnName("idPagare");
                entity.Property(e => e.FecCreacionPagare)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPagare");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NroPagare)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nroPagare");
                entity.Property(e => e.TipoPagareId).HasColumnName("tipoPagareId");

                entity.HasOne(d => d.TipoPagare).WithMany(p => p.ApliPagares)
                    .HasForeignKey(d => d.TipoPagareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGARES_TIPOPAGARES_idTipoPagare");
            });

            modelBuilder.Entity<ApliPagaresExpediente>(entity =>
            {
                entity.HasKey(e => e.IdPagareExpediente).HasName("PK__APLI_PAG__A511D37DDD5AA811");

                entity.ToTable("APLI_PAGARES_EXPEDIENTES");

                entity.Property(e => e.IdPagareExpediente).HasColumnName("idPagareExpediente");
                entity.Property(e => e.CapitalPagareExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("capitalPagareExpediente");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActualizacionPagareExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionPagareExpediente");
                entity.Property(e => e.FecCreacionPagareExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPagareExpediente");
                entity.Property(e => e.FecPrescripcionPagareExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecPrescripcionPagareExpediente");
                entity.Property(e => e.FecVencimientoPagareExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecVencimientoPagareExpediente");
                entity.Property(e => e.InteresPagareExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("interesPagareExpediente");
                entity.Property(e => e.ObligacionPagareExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("obligacionPagareExpediente");
                entity.Property(e => e.OtroValoresPagareExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("otroValoresPagareExpediente");
                entity.Property(e => e.PagareId).HasColumnName("pagareId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValorPagareExpediente)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorPagareExpediente");

                entity.HasOne(d => d.Expediente).WithMany(p => p.ApliPagaresExpedientes)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FL_PAGARE_EXPEDIENTE_idExpediente");

                entity.HasOne(d => d.Pagare).WithMany(p => p.ApliPagaresExpedientes)
                    .HasForeignKey(d => d.PagareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGARE_EXPEDIENTE_idPagare");
            });

            modelBuilder.Entity<ApliSubetapa>(entity =>
            {
                entity.HasKey(e => e.IdSubEtapa).HasName("PK__APLI_SUB__446E2DEF3EF3B060");

                entity.ToTable("APLI_SUBETAPAS");

                entity.Property(e => e.IdSubEtapa).HasColumnName("idSubEtapa");
                entity.Property(e => e.EstadoSubEtapa).HasColumnName("estadoSubEtapa");
                entity.Property(e => e.EventoId).HasColumnName("eventoId");
                entity.Property(e => e.FecActualizacionSubEtapa)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionSubEtapa");
                entity.Property(e => e.FecCreacionSubEtapa)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionSubEtapa");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreSubEtapa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreSubEtapa");
                entity.Property(e => e.NroOrdenSubtapa).HasColumnName("nroOrdenSubtapa");
                entity.Property(e => e.TipoEtapaId).HasColumnName("tipoEtapaId");

                entity.HasOne(d => d.TipoEtapa).WithMany(p => p.ApliSubetapas)
                    .HasForeignKey(d => d.TipoEtapaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBETAPA_TIPOETAPA_idTipoEtapa");
            });

            modelBuilder.Entity<ApliSubtipoJuzgado>(entity =>
            {
                entity.HasKey(e => e.IdSubtipoJuzgado).HasName("PK__APLI_SUB__33DB6AF61424954D");

                entity.ToTable("APLI_SUBTIPO_JUZGADOS");

                entity.Property(e => e.IdSubtipoJuzgado).HasColumnName("idSubtipoJuzgado");
                entity.Property(e => e.DescripcionSubtipoJuzgado)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("descripcionSubtipoJuzgado");
                entity.Property(e => e.FecCreacionSubtipoJuzgado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionSubtipoJuzgado");
                entity.Property(e => e.TipoJuzgadoId).HasColumnName("tipoJuzgadoId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.TipoJuzgado).WithMany(p => p.ApliSubtipoJuzgados)
                    .HasForeignKey(d => d.TipoJuzgadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPO_SUBTIPO_JUZGADOS_idTipoJuzgado");
            });

            modelBuilder.Entity<ApliTipoAsignacione>(entity =>
            {
                entity.HasKey(e => e.IdTipoAsignacion).HasName("PK__APLI_TIP__377C788169FDCD07");

                entity.ToTable("APLI_TIPO_ASIGNACIONES");

                entity.Property(e => e.IdTipoAsignacion).HasColumnName("idTipoAsignacion");
                entity.Property(e => e.DescripcionTipoAsignacion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoAsignacion");
            });

            modelBuilder.Entity<ApliTipoAvaluo>(entity =>
            {
                entity.HasKey(e => e.IdTipoAvaluo).HasName("PK__APLI_TIP__F12434E2CF612F3F");

                entity.ToTable("APLI_TIPO_AVALUOS");

                entity.Property(e => e.IdTipoAvaluo).HasColumnName("idTipoAvaluo");
                entity.Property(e => e.DescripcionTipoAvaluo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoAvaluo");
            });

            modelBuilder.Entity<ApliTipoContacto>(entity =>
            {
                entity.HasKey(e => e.IdTipoContacto).HasName("PK__APLI_TIP__EF7BE7754EEAC3EE");

                entity.ToTable("APLI_TIPO_CONTACTOS");

                entity.Property(e => e.IdTipoContacto).HasColumnName("idTipoContacto");
                entity.Property(e => e.DescipcionTipoContacto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descipcionTipoContacto");
            });

            modelBuilder.Entity<ApliTipoCuantia>(entity =>
            {
                entity.HasKey(e => e.IdTipoCuantia).HasName("PK__APLI_TIP__9F273BD3D4567D9E");

                entity.ToTable("APLI_TIPO_CUANTIAS");

                entity.Property(e => e.IdTipoCuantia).HasColumnName("idTipoCuantia");
                entity.Property(e => e.DescripcionTipoCuantia)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoCuantia");
            });

            modelBuilder.Entity<ApliTipoDeuda>(entity =>
            {
                entity.HasKey(e => e.IdTipoDeuda).HasName("PK__APLI_TIP__2DA4E62725AB823A");

                entity.ToTable("APLI_TIPO_DEUDAS");

                entity.Property(e => e.IdTipoDeuda).HasColumnName("idTipoDeuda");
                entity.Property(e => e.DescipcionTipoDeuda)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descipcionTipoDeuda");
            });

            modelBuilder.Entity<ApliTipoDiligencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoDiligencia).HasName("PK__APLI_TIP__76917249780DE3C5");

                entity.ToTable("APLI_TIPO_DILIGENCIAS");

                entity.Property(e => e.IdTipoDiligencia).HasColumnName("idTipoDiligencia");
                entity.Property(e => e.DescripcionTipoDiligencia)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoDiligencia");
            });

            modelBuilder.Entity<ApliTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento).HasName("PK__APLI_TIP__61FDF9F5C7C52745");

                entity.ToTable("APLI_TIPO_DOCUMENTOS");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");
                entity.Property(e => e.NombreTipoDocumento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoDocumento");
                entity.Property(e => e.TipoPersonaId).HasColumnName("tipoPersonaId");

                entity.HasOne(d => d.TipoPersona).WithMany(p => p.ApliTipoDocumentos)
                    .HasForeignKey(d => d.TipoPersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPODOCUMENTO_TIPOPERSONA_idTipoPersona");
            });

            modelBuilder.Entity<ApliTipoEtapa>(entity =>
            {
                entity.HasKey(e => e.IdTipoEtapa).HasName("PK__APLI_TIP__19611D342E2D6A12");

                entity.ToTable("APLI_TIPO_ETAPAS");

                entity.Property(e => e.IdTipoEtapa).HasColumnName("idTipoEtapa");
                entity.Property(e => e.EstadoTipoEtapa).HasColumnName("estadoTipoEtapa");
                entity.Property(e => e.FecActualizacionTipoEtapa)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionTipoEtapa");
                entity.Property(e => e.FecCreacionTipoEtapa)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoEtapa");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreTipoEtapa)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoEtapa");
                entity.Property(e => e.NroOrdenEtapa).HasColumnName("nroOrdenEtapa");
                entity.Property(e => e.TipoProcesoId).HasColumnName("tipoProcesoId");

                entity.HasOne(d => d.TipoProceso).WithMany(p => p.ApliTipoEtapas)
                    .HasForeignKey(d => d.TipoProcesoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TIPOPROCESO_TIPOETAPA_idTipoProceso");
            });

            modelBuilder.Entity<ApliTipoEvento>(entity =>
            {
                entity.HasKey(e => e.IdTipoEvento).HasName("PK__APLI_TIP__09EED93A3F68C03F");

                entity.ToTable("APLI_TIPO_EVENTOS");

                entity.Property(e => e.IdTipoEvento).HasColumnName("idTipoEvento");
                entity.Property(e => e.DescripcionTipoEvento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoEvento");
                entity.Property(e => e.FecCreacionTipoEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoEvento");
            });

            modelBuilder.Entity<ApliTipoJuzgado>(entity =>
            {
                entity.HasKey(e => e.IdTipoJuzgado).HasName("PK__APLI_TIP__0C417944A6502789");

                entity.ToTable("APLI_TIPO_JUZGADOS");

                entity.Property(e => e.IdTipoJuzgado).HasColumnName("idTipoJuzgado");
                entity.Property(e => e.DescripcionTipoJuzgado)
                    .HasMaxLength(450)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoJuzgado");
                entity.Property(e => e.FecCreacionTipoJuzgado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoJuzgado");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
            });

            modelBuilder.Entity<ApliTipoPagare>(entity =>
            {
                entity.HasKey(e => e.IdTipoPagare).HasName("PK__APLI_TIP__A288A7DA2E0EE7F2");

                entity.ToTable("APLI_TIPO_PAGARES");

                entity.Property(e => e.IdTipoPagare).HasColumnName("idTipoPagare");
                entity.Property(e => e.DescripcionTipoPagare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoPagare");
            });

            modelBuilder.Entity<ApliTipoPersona>(entity =>
            {
                entity.HasKey(e => e.IdTipoPersona).HasName("PK__APLI_TIP__68D37AD6556F192D");

                entity.ToTable("APLI_TIPO_PERSONAS");

                entity.Property(e => e.IdTipoPersona).HasColumnName("idTipoPersona");
                entity.Property(e => e.DescripcionTipoPersona)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoPersona");
            });

            modelBuilder.Entity<ApliTipoProceso>(entity =>
            {
                entity.HasKey(e => e.IdTipoProceso).HasName("PK__APLI_TIP__619F308CDCD7781F");

                entity.ToTable("APLI_TIPO_PROCESOS");

                entity.Property(e => e.IdTipoProceso).HasColumnName("idTipoProceso");
                entity.Property(e => e.FecActualizacionProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionProceso");
                entity.Property(e => e.FecCreacionProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionProceso");
                entity.Property(e => e.NombreProceso)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreProceso");
                entity.Property(e => e.Usuarioid).HasColumnName("usuarioid");
            });

            modelBuilder.Entity<ApliTipoReporte>(entity =>
            {
                entity.HasKey(e => e.IdTipoReporte).HasName("PK__APLI_TIP__5692713ACDCB72A3");

                entity.ToTable("APLI_TIPO_REPORTES");

                entity.Property(e => e.IdTipoReporte).HasColumnName("idTipoReporte");
                entity.Property(e => e.DescripcionTipoReporte)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoReporte");
            });

            modelBuilder.Entity<ApliVencimientoContrasenia>(entity =>
            {
                entity.HasKey(e => e.IdVencimientoContrasenia).HasName("PK__APLI_VEN__5C5D7D86414BFC5A");

                entity.ToTable("APLI_VENCIMIENTO_CONTRASENIAS");

                entity.Property(e => e.IdVencimientoContrasenia).HasColumnName("idVencimientoContrasenia");
                entity.Property(e => e.CantVencimiento).HasColumnName("cantVencimiento");
                entity.Property(e => e.EstadoVencimientoContrasenia).HasColumnName("estadoVencimientoContrasenia");
                entity.Property(e => e.FecActualizacionVencimientoContrasenia)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionVencimientoContrasenia");
                entity.Property(e => e.FecCreacionVencimientoContrasenia)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionVencimientoContrasenia");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            });

            modelBuilder.Entity<ApliVencimientoContraseniasCliente>(entity =>
            {
                entity.HasKey(e => e.IdVencimientoContraseniaCliente).HasName("PK__APLI_VEN__7D576B83DF34B45A");

                entity.ToTable("APLI_VENCIMIENTO_CONTRASENIAS_CLIENTE");

                entity.Property(e => e.IdVencimientoContraseniaCliente).HasColumnName("idVencimientoContraseniaCliente");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.EstadoVencimientoContraseniaCliente).HasColumnName("estadoVencimientoContraseniaCliente");
                entity.Property(e => e.FecActualizacionVencimientoContraseniaCliente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionVencimientoContraseniaCliente");
                entity.Property(e => e.FecCreacionVencimientoContraseniaCliente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionVencimientoContraseniaCliente");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.VencimientoContraseniaId).HasColumnName("vencimientoContraseniaId");

                entity.HasOne(d => d.Cliente).WithMany(p => p.ApliVencimientoContraseniasClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENCIMIENTO_CLIENTES_idCliente");

                entity.HasOne(d => d.VencimientoContrasenia).WithMany(p => p.ApliVencimientoContraseniasClientes)
                    .HasForeignKey(d => d.VencimientoContraseniaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VENCIMIENTO_CONTRASENIA_idVencimientoContrasenia");
            });

            modelBuilder.Entity<AsicExpediente>(entity =>
            {
                entity.HasKey(e => e.IdExpediente).HasName("PK__ASIC_EXP__ED873AE3406826D2");

                entity.ToTable("ASIC_EXPEDIENTES");

                entity.Property(e => e.IdExpediente).HasColumnName("idExpediente");
                entity.Property(e => e.AbogadoId).HasColumnName("abogadoId");
                entity.Property(e => e.ApoderadoId).HasColumnName("apoderadoId");
                entity.Property(e => e.CabeceraId).HasColumnName("cabeceraId");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.CuentaId).HasColumnName("cuentaId");
                entity.Property(e => e.DemandadoId).HasColumnName("demandadoId");
                entity.Property(e => e.DemandadoId2).HasColumnName("demandadoId2");
                entity.Property(e => e.DemandadoId3).HasColumnName("demandadoId3");
                entity.Property(e => e.DemandadoId4).HasColumnName("demandadoId4");
                entity.Property(e => e.DemandanteId).HasColumnName("demandanteId");
                entity.Property(e => e.DocFngTramitado).HasColumnName("docFngTramitado");
                entity.Property(e => e.EstadoDetalle).HasColumnName("estadoDetalle");
                entity.Property(e => e.EstadoProcesalId).HasColumnName("estadoProcesalId");
                entity.Property(e => e.Expediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expediente");
                entity.Property(e => e.FecAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAsignacion");
                entity.Property(e => e.FecCreacionExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionExpediente");
                entity.Property(e => e.FecLiquidacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecLiquidacion");
                entity.Property(e => e.FecPresentacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecPresentacion");
                entity.Property(e => e.FecSustitucion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecSustitucion");
                entity.Property(e => e.FlagFng).HasColumnName("flagFng");
                entity.Property(e => e.Gyc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("gyc");
                entity.Property(e => e.Llave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("llave");
                entity.Property(e => e.NroRadicacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nroRadicacion");
                entity.Property(e => e.NroRadicacionCorta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nroRadicacionCorta");
                entity.Property(e => e.ObservacionDetalle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("observacionDetalle");
                entity.Property(e => e.PlanCompartir).HasColumnName("planCompartir");
                entity.Property(e => e.PrescripcionDetalle)
                    .HasColumnType("datetime")
                    .HasColumnName("prescripcionDetalle");
                entity.Property(e => e.RepresentanteId).HasColumnName("representanteId");
                entity.Property(e => e.SedeId).HasColumnName("sedeId");
                entity.Property(e => e.SubEtapaId).HasColumnName("subEtapaId");
                entity.Property(e => e.TipoProcesoId).HasColumnName("tipoProcesoId");
                entity.Property(e => e.TipocuantiaId).HasColumnName("tipocuantiaId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValorLiquidacion)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorLiquidacion");
                entity.Property(e => e.ValorRemate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorRemate");
                entity.Property(e => e.VrPagoFng)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vrPagoFng");

                entity.HasOne(d => d.Abogado).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.AbogadoId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_ABOGADOS_idAbogado");

                entity.HasOne(d => d.Apoderado).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.ApoderadoId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_APODERADO_idApoderado");

                entity.HasOne(d => d.Cabecera).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.CabeceraId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_CABECERA_idCabecera");

                entity.HasOne(d => d.Cliente).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_CLIENTE_idCliente");

                entity.HasOne(d => d.Cuenta).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.CuentaId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_CUENTAS_idCuenta");

                entity.HasOne(d => d.Demandado).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.DemandadoId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_DEMANDADO_idDemandado");

                entity.HasOne(d => d.Demandante).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.DemandanteId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_DEMANDANTES_idDemandante");

                entity.HasOne(d => d.EstadoProcesal).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.EstadoProcesalId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_ESTADOS_idEstadoProcesal");

                entity.HasOne(d => d.Representante).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.RepresentanteId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_REPRESENTANTE_idRepresentante");

                entity.HasOne(d => d.Sede).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.SedeId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_SEDES_idSede");

                entity.HasOne(d => d.SubEtapa).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.SubEtapaId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_SUBETAPA_idSubEtapa");

                entity.HasOne(d => d.TipoProceso).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.TipoProcesoId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_TIPOPROCESO_idTipoProceso");

                entity.HasOne(d => d.Tipocuantia).WithMany(p => p.AsicExpedientes)
                    .HasForeignKey(d => d.TipocuantiaId)
                    .HasConstraintName("FK_ASICEXPEDIENTE_TIPOCUANTIAS_idTipoCuantia");
            });

            modelBuilder.Entity<AsicExpedienteCargaErrore>(entity =>
            {
                entity.HasKey(e => e.IdExpedienteCargaError).HasName("PK__ASIC_EXP__DC0062F39A414237");

                entity.ToTable("ASIC_EXPEDIENTE_CARGA_ERRORES");

                entity.Property(e => e.IdExpedienteCargaError).HasColumnName("idExpedienteCargaError");
                entity.Property(e => e.DescripcionCampoExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionCampoExpediente");
                entity.Property(e => e.DescripcionErrorExpediente)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("descripcionErrorExpediente");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecCargaErrorExpediente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCargaErrorExpediente");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NroFilaExpediente).HasColumnName("nroFilaExpediente");

                entity.HasOne(d => d.Expediente).WithMany(p => p.AsicExpedienteCargaErrores)
                    .HasForeignKey(d => d.ExpedienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EXPEDIENTE_CARGA_ERRORES_EXPEDIENTE_idExpediente");
            });

            modelBuilder.Entity<AsicMasivaCabecera>(entity =>
            {
                entity.HasKey(e => e.IdCabecera).HasName("PK__ASIC_MAS__33F2D28269A75D6B");

                entity.ToTable("ASIC_MASIVA_CABECERAS");

                entity.Property(e => e.IdCabecera).HasColumnName("idCabecera");
                entity.Property(e => e.FlagAceptacion).HasColumnName("flagAceptacion");
                entity.Property(e => e.LoteId).HasColumnName("loteId");
                entity.Property(e => e.NombreDocumentoCabecera)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreDocumentoCabecera");
                entity.Property(e => e.RegistrosErroneosCabecera).HasColumnName("registrosErroneosCabecera");
                entity.Property(e => e.RegistrosTotalesCabecera).HasColumnName("registrosTotalesCabecera");
                entity.Property(e => e.TipoDocumentoCabecera)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumentoCabecera");

                entity.HasOne(d => d.Lote).WithMany(p => p.AsicMasivaCabeceras)
                    .HasForeignKey(d => d.LoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASICCABECERA_LOTE_idLote");
            });

            modelBuilder.Entity<AsicMasivaLote>(entity =>
            {
                entity.HasKey(e => e.IdLote).HasName("PK__ASIC_MAS__1B91FFCBFAD443AD");

                entity.ToTable("ASIC_MASIVA_LOTES");

                entity.Property(e => e.IdLote).HasColumnName("idLote");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.EstadoLotes).HasColumnName("estadoLotes");
                entity.Property(e => e.FecActualizacionLote)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionLote");
                entity.Property(e => e.FecCreacionLote)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionLote");
                entity.Property(e => e.NombreLote)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nombreLote");

                entity.HasOne(d => d.Cliente).WithMany(p => p.AsicMasivaLotes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASICLOTE_CLIENTES_idCliente");
            });

            modelBuilder.Entity<AsicMasivaLoteCargaErrore>(entity =>
            {
                entity.HasKey(e => e.IdLotesCargaError).HasName("PK__ASIC_MAS__868348BBA85F5A09");

                entity.ToTable("ASIC_MASIVA_LOTE_CARGA_ERRORES");

                entity.Property(e => e.IdLotesCargaError).HasColumnName("idLotesCargaError");
                entity.Property(e => e.DescripcionCampoLote)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionCampoLote");
                entity.Property(e => e.DescripcionErrorLote)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("descripcionErrorLote");
                entity.Property(e => e.FecCargaErrorLote)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCargaErrorLote");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.LoteId).HasColumnName("loteId");
                entity.Property(e => e.NroFilaLote).HasColumnName("nroFilaLote");

                entity.HasOne(d => d.Lote).WithMany(p => p.AsicMasivaLoteCargaErrores)
                    .HasForeignKey(d => d.LoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOTE_CARGA_ERRORES_LOTES_idLote");
            });

            modelBuilder.Entity<AsicSede>(entity =>
            {
                entity.HasKey(e => e.IdSede).HasName("PK__ASIC_SED__C5AF63D0FC52AEB6");

                entity.ToTable("ASIC_SEDES");

                entity.Property(e => e.IdSede).HasColumnName("idSede");
                entity.Property(e => e.DepartamentoSede)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("departamentoSede");
                entity.Property(e => e.EstadoSede).HasColumnName("estadoSede");
                entity.Property(e => e.PaisSede)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("paisSede");
                entity.Property(e => e.ProvinciaSede)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("provinciaSede");
            });

            modelBuilder.Entity<BendActividade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__BEND_ACT__3213E83F524DA46B");

                entity.ToTable("BEND_ACTIVIDADES");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Activo).HasColumnName("activo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
                entity.Property(e => e.EsDetenido).HasColumnName("esDetenido");
                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaActualizacion");
                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");
                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAsignacion");
                entity.Property(e => e.FechaCancelacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCancelacion");
                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio");
                entity.Property(e => e.FechaReactivacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReactivacion");
                entity.Property(e => e.FechaReingreso)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaReingreso");
                entity.Property(e => e.FechaSuspension)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaSuspension");
                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaTermino");
                entity.Property(e => e.IdActividad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idActividad");
                entity.Property(e => e.IdExpediente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("idExpediente");
                entity.Property(e => e.IdReproceso).HasColumnName("idReproceso");
                entity.Property(e => e.IdRol).HasColumnName("idRol");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.IdWorkFlow).HasColumnName("idWorkFlow");
                entity.Property(e => e.Permiso).HasColumnName("permiso");
                entity.Property(e => e.Status)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<BendCampoCliente>(entity =>
            {
                entity.HasKey(e => e.IdCampoCliente).HasName("PK__BEND_CAM__F627E5564ECE3F7F");

                entity.ToTable("BEND_CAMPO_CLIENTES");

                entity.Property(e => e.IdCampoCliente).HasColumnName("idCampoCliente");
                entity.Property(e => e.CampoId).HasColumnName("campoId");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.EstadoCampoCliente).HasColumnName("estadoCampoCliente");
                entity.Property(e => e.OrdenCampo).HasColumnName("ordenCampo");

                entity.HasOne(d => d.Campo).WithMany(p => p.BendCampoClientes)
                    .HasForeignKey(d => d.CampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPO_CLIENTES_PLANTILLACAMPOS_idCampo");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BendCampoClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CAMPO_CLIENTES_PLANTILLACAMPOS_idcliente");
            });

            modelBuilder.Entity<BendCatActividadesW>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__BEND_CAT__3213E83FC89B33AE");

                entity.ToTable("BEND_CAT_ACTIVIDADES_WS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Actividad)
                    .HasMaxLength(100)
                    .HasColumnName("actividad");
                entity.Property(e => e.Etapa)
                    .HasMaxLength(40)
                    .HasColumnName("etapa");
                entity.Property(e => e.IdActividad)
                    .HasMaxLength(50)
                    .HasColumnName("idActividad");
                entity.Property(e => e.IdProceso)
                    .HasMaxLength(50)
                    .HasColumnName("idProceso");
                entity.Property(e => e.Page)
                    .HasMaxLength(50)
                    .HasColumnName("page");
                entity.Property(e => e.Proceso)
                    .HasMaxLength(20)
                    .HasColumnName("proceso");
                entity.Property(e => e.TiempoPromedio).HasColumnName("tiempoPromedio");
                entity.Property(e => e.Tipo)
                    .HasMaxLength(20)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<BendCustomizaElemento>(entity =>
            {
                entity.HasKey(e => e.IdCustomizaElemento).HasName("PK__BEND_CUS__3EB03196B999C708");

                entity.ToTable("BEND_CUSTOMIZA_ELEMENTOS");

                entity.Property(e => e.IdCustomizaElemento).HasColumnName("idCustomizaElemento");
                entity.Property(e => e.FecActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacion");
                entity.Property(e => e.FecCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.TipoColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoColor");
            });

            modelBuilder.Entity<BendDeceval>(entity =>
            {
                entity.HasKey(e => e.IdDeceval).HasName("PK__BEND_DEC__B56AF5230CDE5CD1");

                entity.ToTable("BEND_DECEVAL");

                entity.Property(e => e.IdDeceval).HasColumnName("idDeceval");
                entity.Property(e => e.Activo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("activo");
                entity.Property(e => e.Certficicado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("certficicado");
                entity.Property(e => e.CuentaId).HasColumnName("cuentaId");
                entity.Property(e => e.DeudorDecevalId).HasColumnName("deudorDecevalId");
                entity.Property(e => e.Digital)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("digital");
                entity.Property(e => e.Enlace)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("enlace");
                entity.Property(e => e.Estado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("estado");
                entity.Property(e => e.FecActualizacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fecActualizacion");
                entity.Property(e => e.FecCreacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.FecExpedicion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fecExpedicion");
                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaVencimiento");
                entity.Property(e => e.Mti)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mti");
                entity.Property(e => e.Observacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
                entity.Property(e => e.Proceso)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("proceso");
                entity.Property(e => e.SedeId).HasColumnName("sedeId");
                entity.Property(e => e.TipoCertificado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoCertificado");
                entity.Property(e => e.TipoPagare)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoPagare");
                entity.Property(e => e.Unidad)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("unidad");
                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("valor");
                entity.Property(e => e.ValorInteres)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("valorInteres");

                entity.HasOne(d => d.Cuenta).WithMany(p => p.BendDecevals)
                    .HasForeignKey(d => d.CuentaId)
                    .HasConstraintName("FK__CUENTA_DEUDORDECEVALL_idCuenta");

                entity.HasOne(d => d.DeudorDeceval).WithMany(p => p.BendDecevals)
                    .HasForeignKey(d => d.DeudorDecevalId)
                    .HasConstraintName("FK_DEUDORDECEVAL_DECEVAL_idDeudorDeceval");

                entity.HasOne(d => d.Sede).WithMany(p => p.BendDecevals)
                    .HasForeignKey(d => d.SedeId)
                    .HasConstraintName("FK__SEDE_DEUDORDECEVALL_idSede");
            });

            modelBuilder.Entity<BendDeudorBien>(entity =>
            {
                entity.HasKey(e => e.IdDeudorBien).HasName("PK__BEND_DEU__B6C4A93F26C9A231");

                entity.ToTable("BEND_DEUDOR_BIEN");

                entity.Property(e => e.IdDeudorBien).HasColumnName("idDeudorBien");
                entity.Property(e => e.DeudorId).HasColumnName("deudorId");
                entity.Property(e => e.FecCreacionDeudorBien)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionDeudorBien");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Deudor).WithMany(p => p.BendDeudorBiens)
                    .HasForeignKey(d => d.DeudorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIEN_DETALLES_DEUDOR_idDeudor");
            });

            modelBuilder.Entity<BendDeudorDeceval>(entity =>
            {
                entity.HasKey(e => e.IdDeudorDeceval).HasName("PK__BEND_DEU__40144E53CC7426EE");

                entity.ToTable("BEND_DEUDOR_DECEVAL");

                entity.Property(e => e.IdDeudorDeceval).HasColumnName("idDeudorDeceval");
                entity.Property(e => e.DeudorId).HasColumnName("deudorId");
                entity.Property(e => e.EstadoDeceval)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoDeceval");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecRecepcion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecRecepcion");
                entity.Property(e => e.FecSolicitud)
                    .HasColumnType("datetime")
                    .HasColumnName("fecSolicitud");

                entity.HasOne(d => d.Deudor).WithMany(p => p.BendDeudorDecevals)
                    .HasForeignKey(d => d.DeudorId)
                    .HasConstraintName("FK_DEUDORDECEVAL_DEUDOR_idDeudor");

                entity.HasOne(d => d.Expediente).WithMany(p => p.BendDeudorDecevals)
                    .HasForeignKey(d => d.ExpedienteId)
                    .HasConstraintName("FK_DEUDORDECEVAL_ASICEXPEDIENTE_idExpediente");
            });

            modelBuilder.Entity<BendDeudorRamaJudicial>(entity =>
            {
                entity.HasKey(e => e.IdDeudorRamaJudicial).HasName("PK__BEND_DEU__25C7BFE5F3276A1A");

                entity.ToTable("BEND_DEUDOR_RAMA_JUDICIAL");

                entity.Property(e => e.IdDeudorRamaJudicial).HasColumnName("idDeudorRamaJudicial");
                entity.Property(e => e.DeudorId).HasColumnName("deudorId");
                entity.Property(e => e.FecFintTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fecFintTermino");
                entity.Property(e => e.FecInicioTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioTermino");
                entity.Property(e => e.FecRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecRegistro");
                entity.Property(e => e.NroRadicacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroRadicacion");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Deudor).WithMany(p => p.BendDeudorRamaJudicials)
                    .HasForeignKey(d => d.DeudorId)
                    .HasConstraintName("FK_RAMA_JUDICIAL_DEUDOR_idDeudor");
            });

            modelBuilder.Entity<BendDeudorSalario>(entity =>
            {
                entity.HasKey(e => e.IdDeudorSalario).HasName("PK__BEND_DEU__351AE0F5A5D3056E");

                entity.ToTable("BEND_DEUDOR_SALARIO");

                entity.Property(e => e.IdDeudorSalario).HasColumnName("idDeudorSalario");
                entity.Property(e => e.DeudorId).HasColumnName("deudorId");
                entity.Property(e => e.FecCreacionSaliario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionSaliario");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Deudor).WithMany(p => p.BendDeudorSalarios)
                    .HasForeignKey(d => d.DeudorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALARIO_DETALLE_DEUDOR_idDeudor");
            });

            modelBuilder.Entity<BendDeudorVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdDeudorVehiculo).HasName("PK__BEND_DEU__015479B9CD0D5A8B");

                entity.ToTable("BEND_DEUDOR_VEHICULO");

                entity.Property(e => e.IdDeudorVehiculo).HasColumnName("idDeudorVehiculo");
                entity.Property(e => e.DeudorId).HasColumnName("deudorId");
                entity.Property(e => e.FecActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacion");
                entity.Property(e => e.FecCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Deudor).WithMany(p => p.BendDeudorVehiculos)
                    .HasForeignKey(d => d.DeudorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_DETALLES_DEUDOR_idDeudor");
            });

            modelBuilder.Entity<BendDeudore>(entity =>
            {
                entity.HasKey(e => e.IdDeudor).HasName("PK__BEND_DEU__8FA83C7282E33368");

                entity.ToTable("BEND_DEUDORES");

                entity.Property(e => e.IdDeudor).HasColumnName("idDeudor");
                entity.Property(e => e.ApeMaternoDeudor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("apeMaternoDeudor");
                entity.Property(e => e.ApePaternoDeudor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("apePaternoDeudor");
                entity.Property(e => e.FecCreacionDeudor)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionDeudor");
                entity.Property(e => e.NombreDeudor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreDeudor");
                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroDocumento");
                entity.Property(e => e.PaisId).HasColumnName("paisId");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BendDeudores)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DEUDORES_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BendEstadoElectronicosRj>(entity =>
            {
                entity.HasKey(e => e.IdEstadoElectronico).HasName("PK__BEND_EST__70DB6CA38D8058AE");

                entity.ToTable("BEND_ESTADO_ELECTRONICOS_RJ");

                entity.Property(e => e.IdEstadoElectronico).HasColumnName("idEstadoElectronico");
                entity.Property(e => e.AnioEstadoElectronico).HasColumnName("anioEstadoElectronico");
                entity.Property(e => e.EnlaceEstadoElectronico)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("enlaceEstadoElectronico");
                entity.Property(e => e.FecActualizacionEstadoElectronico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionEstadoElectronico");
                entity.Property(e => e.FecCreacionEstadoElectronico)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionEstadoElectronico");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.JuzgadoId).HasColumnName("juzgadoId");
                entity.Property(e => e.XpathPestEstadoElectronico)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("xpathPestEstadoElectronico");
                entity.Property(e => e.XpathTabEstadoElectronico)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("xpathTabEstadoElectronico");

                entity.HasOne(d => d.Juzgado).WithMany(p => p.BendEstadoElectronicosRjs)
                    .HasForeignKey(d => d.JuzgadoId)
                    .HasConstraintName("FK__ELECTRONICOS_JUZGADOS_idJuzgado");
            });

            modelBuilder.Entity<BendGarantiaFavore>(entity =>
            {
                entity.HasKey(e => e.IdGarantiaFavor).HasName("PK__BEND_GAR__DAB8DF288384CA15");

                entity.ToTable("BEND_GARANTIA_FAVORES");

                entity.Property(e => e.IdGarantiaFavor).HasColumnName("idGarantiaFavor");
                entity.Property(e => e.ConfeCamara)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("confeCamara");
                entity.Property(e => e.FecInscripcionGarantiaFavor)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInscripcionGarantiaFavor");
                entity.Property(e => e.IdentificacionAcreedor)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("identificacionAcreedor");
                entity.Property(e => e.PatrimonioAutonomo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("patrimonioAutonomo");
            });

            modelBuilder.Entity<BendHistBusqBienesDetalle>(entity =>
            {
                entity.HasKey(e => e.IdHistBusqBien).HasName("PK__BEND_HIS__779B445CE06BE16C");

                entity.ToTable("BEND_HIST_BUSQ_BIENES_DETALLES");

                entity.Property(e => e.IdHistBusqBien).HasColumnName("idHistBusqBien");
                entity.Property(e => e.Avaluo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("avaluo");
                entity.Property(e => e.Ciudad)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");
                entity.Property(e => e.DetalleError)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("detalleError");
                entity.Property(e => e.DeudorBienId).HasColumnName("deudorBienId");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
                entity.Property(e => e.ErrorBusqueda)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("errorBusqueda");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FecBusqueda)
                    .HasColumnType("datetime")
                    .HasColumnName("fecBusqueda");
                entity.Property(e => e.FecCreacionBien)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionBien");
                entity.Property(e => e.Matricula)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("matricula");
                entity.Property(e => e.Observacion)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
                entity.Property(e => e.OficinaRegistro)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("oficinaRegistro");

                entity.HasOne(d => d.DeudorBien).WithMany(p => p.BendHistBusqBienesDetalles)
                    .HasForeignKey(d => d.DeudorBienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BIEN_BUSQBIEN_idDeudorBien");
            });

            modelBuilder.Entity<BendHistBusqSalariosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdHistBusqSalario).HasName("PK__BEND_HIS__7FDEC5D44F692695");

                entity.ToTable("BEND_HIST_BUSQ_SALARIOS_DETALLES");

                entity.Property(e => e.IdHistBusqSalario).HasColumnName("idHistBusqSalario");
                entity.Property(e => e.DetalleError)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("detalleError");
                entity.Property(e => e.DeudorSalarioId).HasColumnName("deudorSalarioId");
                entity.Property(e => e.DireccionEmpresa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("direccionEmpresa");
                entity.Property(e => e.Empresa)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("empresa");
                entity.Property(e => e.EntidadSalario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("entidadSalario");
                entity.Property(e => e.ErrorBusqueda)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("errorBusqueda");
                entity.Property(e => e.EstadoSalario).HasColumnName("estadoSalario");
                entity.Property(e => e.FecAfilEfectiva)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAfilEfectiva");
                entity.Property(e => e.FecAfilFinalizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAfilFinalizacion");
                entity.Property(e => e.FecBusqueda)
                    .HasColumnType("datetime")
                    .HasColumnName("fecBusqueda");
                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroDocumento");
                entity.Property(e => e.Observacion)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salario");
                entity.Property(e => e.TipoAfiliadoSalario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoAfiliadoSalario");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");
                entity.Property(e => e.TipoRegimenSalario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoRegimenSalario");

                entity.HasOne(d => d.DeudorSalario).WithMany(p => p.BendHistBusqSalariosDetalles)
                    .HasForeignKey(d => d.DeudorSalarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SALARIO_DETALLE_idDeudorSalario");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BendHistBusqSalariosDetalles)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .HasConstraintName("FK_SALARIO_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BendHistBusqVehiculosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdHistBusqVehiculo).HasName("PK__BEND_HIS__AB4588F3A8EB12C2");

                entity.ToTable("BEND_HIST_BUSQ_VEHICULOS_DETALLES");

                entity.Property(e => e.IdHistBusqVehiculo).HasColumnName("idHistBusqVehiculo");
                entity.Property(e => e.AutoridadTransitoVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("autoridadTransitoVehiculo");
                entity.Property(e => e.CilindrajeVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cilindrajeVehiculo");
                entity.Property(e => e.CiudadVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ciudadVehiculo");
                entity.Property(e => e.ClasicoAntiguoVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("clasicoAntiguoVehiculo");
                entity.Property(e => e.ColorVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("colorVehiculo");
                entity.Property(e => e.CombustibleVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("combustibleVehiculo");
                entity.Property(e => e.DetalleError)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("detalleError");
                entity.Property(e => e.DeudorVehiculoId).HasColumnName("deudorVehiculoId");
                entity.Property(e => e.ErrorBusqueda)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("errorBusqueda");
                entity.Property(e => e.EstadoGarFavorDe)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("estadoGarFavorDe");
                entity.Property(e => e.EstadoLimPropiedadVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("estadoLimPropiedadVehiculo");
                entity.Property(e => e.EstadoRuntVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoRuntVehiculo");
                entity.Property(e => e.EstadoVehiculo).HasColumnName("estadoVehiculo");
                entity.Property(e => e.FecMatriculaInicialVehiculo)
                    .HasColumnType("datetime")
                    .HasColumnName("fecMatriculaInicialVehiculo");
                entity.Property(e => e.GarantiaFavorId).HasColumnName("garantiaFavorId");
                entity.Property(e => e.GravemenesPropiedad)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("gravemenesPropiedad");
                entity.Property(e => e.LimitacionPropiedadId).HasColumnName("limitacionPropiedadId");
                entity.Property(e => e.LineaVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lineaVehiculo");
                entity.Property(e => e.MarcaVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marcaVehiculo");
                entity.Property(e => e.ModeloVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modeloVehiculo");
                entity.Property(e => e.NroChasisVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroChasisVehiculo");
                entity.Property(e => e.NroMotorVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroMotorVehiculo");
                entity.Property(e => e.NroPlacaVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nroPlacaVehiculo");
                entity.Property(e => e.NroSerieVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroSerieVehiculo");
                entity.Property(e => e.NroVinVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroVinVehiculo");
                entity.Property(e => e.Observacion)
                    .IsUnicode(false)
                    .HasColumnName("observacion");
                entity.Property(e => e.OficinaRegistro)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("oficinaRegistro");
                entity.Property(e => e.OtrasCaracteristicas)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("otrasCaracteristicas");
                entity.Property(e => e.RepotenciadoVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("repotenciadoVehiculo");
                entity.Property(e => e.TipoCarroceriaVehiculo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoCarroceriaVehiculo");

                entity.HasOne(d => d.DeudorVehiculo).WithMany(p => p.BendHistBusqVehiculosDetalles)
                    .HasForeignKey(d => d.DeudorVehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_BUSQVEHICULO_idDeudorVehiculo");

                entity.HasOne(d => d.GarantiaFavor).WithMany(p => p.BendHistBusqVehiculosDetalles)
                    .HasForeignKey(d => d.GarantiaFavorId)
                    .HasConstraintName("FK_BUSQ_VEHICULOS_GARANTIA_idGarantiaFavor");

                entity.HasOne(d => d.LimitacionPropiedad).WithMany(p => p.BendHistBusqVehiculosDetalles)
                    .HasForeignKey(d => d.LimitacionPropiedadId)
                    .HasConstraintName("FK_BUSQ_VEHICULOS_LIMITACION_idLimitacionPropiedad");
            });

            modelBuilder.Entity<BendHistRamaJudicial>(entity =>
            {
                entity.HasKey(e => e.IdHistRamaJudicial).HasName("PK__BEND_HIS__F1A006A011A0646C");

                entity.ToTable("BEND_HIST_RAMA_JUDICIAL");

                entity.Property(e => e.IdHistRamaJudicial).HasColumnName("idHistRamaJudicial");
                entity.Property(e => e.ActuacionAnotacion)
                    .IsUnicode(false)
                    .HasColumnName("actuacionAnotacion");
                entity.Property(e => e.Anotacion)
                    .IsUnicode(false)
                    .HasColumnName("anotacion");
                entity.Property(e => e.ClaseProcesoRamaJudicial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("claseProcesoRamaJudicial");
                entity.Property(e => e.CoincidenciaRamaJudicial)
                    .IsUnicode(false)
                    .HasColumnName("coincidenciaRamaJudicial");
                entity.Property(e => e.Concateacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("concateacion");
                entity.Property(e => e.ConcateacionTyba)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("concateacionTyba");
                entity.Property(e => e.DemandanteRamaJudicial)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("demandanteRamaJudicial");
                entity.Property(e => e.DepartamentoRamaJudicial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("departamentoRamaJudicial");
                entity.Property(e => e.DespachoRamaJudicial)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("despachoRamaJudicial");
                entity.Property(e => e.DetalleError)
                    .IsUnicode(false)
                    .HasColumnName("detalleError");
                entity.Property(e => e.DeudorRamaJudicialId).HasColumnName("deudorRamaJudicialId");
                entity.Property(e => e.ErrorBusqueda)
                    .IsUnicode(false)
                    .HasColumnName("errorBusqueda");
                entity.Property(e => e.EstadoRamaJudicial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estadoRamaJudicial");
                entity.Property(e => e.ExpedienteId).HasColumnName("expedienteId");
                entity.Property(e => e.FecActuacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActuacion");
                entity.Property(e => e.FecActuacionTybaProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActuacionTybaProceso");
                entity.Property(e => e.FecActualizacionAntRamaJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionAntRamaJudicial");
                entity.Property(e => e.FecActualizacionRamaJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionRamaJudicial");
                entity.Property(e => e.FecBusqueda)
                    .HasColumnType("datetime")
                    .HasColumnName("fecBusqueda");
                entity.Property(e => e.FecCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.FecCreacionRamaJudicial)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionRamaJudicial");
                entity.Property(e => e.FecFintTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fecFintTermino");
                entity.Property(e => e.FecInicioTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioTermino");
                entity.Property(e => e.FecRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fecRegistro");
                entity.Property(e => e.FecRegistroTybaProceso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecRegistroTybaProceso");
                entity.Property(e => e.FechaActualizacionMicrositio).HasColumnType("datetime");
                entity.Property(e => e.FechaActualizacionMicrositioP4).HasColumnType("datetime");
                entity.Property(e => e.FechaCarga).HasColumnType("datetime");
                entity.Property(e => e.FechaMicrositio).HasColumnType("datetime");
                entity.Property(e => e.JuzgadoId).HasColumnName("juzgadoId");
                entity.Property(e => e.LlaveRamaJudicial)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("llaveRamaJudicial");
                entity.Property(e => e.ObservacionMicrositio)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.ObservacionMicrositioP4)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.RutaDctoPdf)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("rutaDctoPdf");
                entity.Property(e => e.RutaDctoPdfEstado)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.RutaDctoPdfEstadoP4)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.RutaDctoPdfProvidP4)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.SedeId).HasColumnName("sedeId");
                entity.Property(e => e.SolicitaDetalleEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("solicitaDetalleEstado");
                entity.Property(e => e.TipActuacionesTybaProceso)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipActuacionesTybaProceso");
                entity.Property(e => e.UsuarioCreacionRamaJudicial).HasColumnName("usuarioCreacionRamaJudicial");

                entity.HasOne(d => d.DeudorRamaJudicial).WithMany(p => p.BendHistRamaJudicials)
                    .HasForeignKey(d => d.DeudorRamaJudicialId)
                    .HasConstraintName("FK__RAMAJUDICIAL_HISTRAMAJUDICIAL_idDeudorRamaJudicial");

                entity.HasOne(d => d.Juzgado).WithMany(p => p.BendHistRamaJudicials)
                    .HasForeignKey(d => d.JuzgadoId)
                    .HasConstraintName("FK__JUZAGADO_HISTRAMAJUDICIAL_idJuzgado");

                entity.HasOne(d => d.Sede).WithMany(p => p.BendHistRamaJudicials)
                    .HasForeignKey(d => d.SedeId)
                    .HasConstraintName("FK__SEDE_HISTRAMAJUDICIAL_idSede");
            });

            modelBuilder.Entity<BendHistValidacione>(entity =>
            {
                entity.HasKey(e => e.IdHistValidacion).HasName("PK__BEND_HIS__732CFC9A822A0670");

                entity.ToTable("BEND_HIST_VALIDACIONES");

                entity.Property(e => e.IdHistValidacion).HasColumnName("idHistValidacion");
                entity.Property(e => e.CodigoVerifHistValidacion)
                    .HasMaxLength(150)
                    .HasColumnName("codigoVerifHistValidacion");
                entity.Property(e => e.EmailHistValidacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("emailHistValidacion");
                entity.Property(e => e.FecCodigoVerifHistValidacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCodigoVerifHistValidacion");
                entity.Property(e => e.FecInicioSesionHistValidacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioSesionHistValidacion");
                entity.Property(e => e.FlagExitoSesionHistValidacion).HasColumnName("flagExitoSesionHistValidacion");
                entity.Property(e => e.LocacionId).HasColumnName("locacionId");
                entity.Property(e => e.TelefonoHistValidacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoHistValidacion");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValidacionId).HasColumnName("validacionId");

                entity.HasOne(d => d.Locacion).WithMany(p => p.BendHistValidaciones)
                    .HasForeignKey(d => d.LocacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISVALIDACION_LOCACIONES_idLocacion");

                entity.HasOne(d => d.Usuario).WithMany(p => p.BendHistValidaciones)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISVALIDACION_USUARIOS_idUsuario");

                entity.HasOne(d => d.Validacion).WithMany(p => p.BendHistValidaciones)
                    .HasForeignKey(d => d.ValidacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISVALIDACION_VALIDACIONES_idValidacion");
            });

            modelBuilder.Entity<BendLimitacionPropiedade>(entity =>
            {
                entity.HasKey(e => e.IdLimitacionPropiedad).HasName("PK__BEND_LIM__35AC6A411E9CADC4");

                entity.ToTable("BEND_LIMITACION_PROPIEDADES");

                entity.Property(e => e.IdLimitacionPropiedad).HasColumnName("idLimitacionPropiedad");
                entity.Property(e => e.Departamento)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("departamento");
                entity.Property(e => e.EntidadJuridica)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("entidadJuridica");
                entity.Property(e => e.FecExpedicionOficio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecExpedicionOficio");
                entity.Property(e => e.FecRegistroSistema)
                    .HasColumnType("datetime")
                    .HasColumnName("fecRegistroSistema");
                entity.Property(e => e.Municipio)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("municipio");
                entity.Property(e => e.NroOficio)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nroOficio");
                entity.Property(e => e.TipoLimitacionPropiedad)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoLimitacionPropiedad");
            });

            modelBuilder.Entity<BendObjeto>(entity =>
            {
                entity.HasKey(e => e.IdObjeto).HasName("PK__BEND_OBJ__C3C88194B35110F8");

                entity.ToTable("BEND_OBJETOS");

                entity.Property(e => e.IdObjeto).HasColumnName("idObjeto");
                entity.Property(e => e.EstadoObjeto).HasColumnName("estadoObjeto");
                entity.Property(e => e.NombreObjeto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreObjeto");
                entity.Property(e => e.PadreObjetoId).HasColumnName("padreObjetoId");
                entity.Property(e => e.RutaObjeto)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("rutaObjeto");
                entity.Property(e => e.TipoAmbienteId).HasColumnName("tipoAmbienteId");
                entity.Property(e => e.TipoObjetoId).HasColumnName("tipoObjetoId");

                entity.HasOne(d => d.TipoAmbiente).WithMany(p => p.BendObjetos)
                    .HasForeignKey(d => d.TipoAmbienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OBJETO_AMBIENTE_idTipoAmbiente");

                entity.HasOne(d => d.TipoObjeto).WithMany(p => p.BendObjetos)
                    .HasForeignKey(d => d.TipoObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OBJETO_TIPO_OBJETOS_idTipoObjeto");
            });

            modelBuilder.Entity<BendPlantillaCampo>(entity =>
            {
                entity.HasKey(e => e.IdCampo).HasName("PK__BEND_PLA__5245D63CF5F18C9E");

                entity.ToTable("BEND_PLANTILLA_CAMPOS");

                entity.Property(e => e.IdCampo).HasColumnName("idCampo");
                entity.Property(e => e.DescripcionCampo)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("descripcionCampo");
                entity.Property(e => e.EstadoCampo).HasColumnName("estadoCampo");
                entity.Property(e => e.FecCreacionCampo)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionCampo");
                entity.Property(e => e.GrupoCampo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("grupoCampo");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreCampo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombreCampo");
                entity.Property(e => e.RequeridoCampo).HasColumnName("requeridoCampo");
                entity.Property(e => e.TipoControlCampo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("tipoControlCampo");
                entity.Property(e => e.TipoDatoCampo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoDatoCampo");
            });

            modelBuilder.Entity<BendPreguntaSesione>(entity =>
            {
                entity.HasKey(e => e.IdPregunta).HasName("PK__BEND_PRE__623EEC4237F68B14");

                entity.ToTable("BEND_PREGUNTA_SESIONES");

                entity.Property(e => e.IdPregunta).HasColumnName("idPregunta");
                entity.Property(e => e.DescripcionPregunta)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionPregunta");
            });

            modelBuilder.Entity<BendRespuestaSesione>(entity =>
            {
                entity.HasKey(e => e.IdRespuesta).HasName("PK__BEND_RES__8AB5BFC843F16337");

                entity.ToTable("BEND_RESPUESTA_SESIONES");

                entity.Property(e => e.IdRespuesta).HasColumnName("idRespuesta");
                entity.Property(e => e.DescripcionRespuesta)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionRespuesta");
                entity.Property(e => e.PreguntaId).HasColumnName("preguntaId");

                entity.HasOne(d => d.Pregunta).WithMany(p => p.BendRespuestaSesiones)
                    .HasForeignKey(d => d.PreguntaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESPUESTA_PREGUNTA_idPregunta");
            });

            modelBuilder.Entity<BendTbletapa>(entity =>
            {
                entity.HasKey(e => e.IdEtapa).HasName("PK__BEND_TBL__C587A24F24A9C6AB");

                entity.ToTable("BEND_TBLETAPAS");

                entity.Property(e => e.IdEtapa)
                    .ValueGeneratedNever()
                    .HasColumnName("idEtapa");
                entity.Property(e => e.Activo).HasColumnName("activo");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaAlta");
                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.TiempoPromedio).HasColumnName("tiempoPromedio");
                entity.Property(e => e.TipoFlujo)
                    .HasMaxLength(80)
                    .HasColumnName("tipoFlujo");
            });

            modelBuilder.Entity<BendTipoExpDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoExpDocumento).HasName("PK__BEND_TIP__B5486DC0493BA8F3");

                entity.ToTable("BEND_TIPO_EXP_DOCUMENTOS");

                entity.Property(e => e.IdTipoExpDocumento).HasColumnName("idTipoExpDocumento");
                entity.Property(e => e.DescripcionTipoExpDocumento)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoExpDocumento");
                entity.Property(e => e.FecCreacionTipoExpDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoExpDocumento");
            });

            modelBuilder.Entity<BendTipoObjeto>(entity =>
            {
                entity.HasKey(e => e.IdTipoObjeto).HasName("PK__BEND_TIP__D3389F8ED680DD0F");

                entity.ToTable("BEND_TIPO_OBJETOS");

                entity.Property(e => e.IdTipoObjeto).HasColumnName("idTipoObjeto");
                entity.Property(e => e.DescriptcionTipoObjeto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descriptcionTipoObjeto");
                entity.Property(e => e.EstadoTipoObjeto).HasColumnName("estadoTipoObjeto");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            });

            modelBuilder.Entity<BendUsuario>(entity =>
            {
                entity.HasKey(e => e.UsuarioId).HasName("PK__BEND_USU__A5B1AB8E3FBD4A7A");

                entity.ToTable("BEND_USUARIOS");

                entity.Property(e => e.UsuarioId)
                    .ValueGeneratedNever()
                    .HasColumnName("usuarioId");
                entity.Property(e => e.Contrasena)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FecAltaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAltaUsuario");
                entity.Property(e => e.FecBajaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecBajaUsuario");

                entity.HasOne(d => d.Usuario).WithOne(p => p.BendUsuario)
                    .HasForeignKey<BendUsuario>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BENDUSUARIO_BOFFUSUARIO_idUsuario");
            });

            modelBuilder.Entity<BendValidacione>(entity =>
            {
                entity.HasKey(e => e.IdValidacion).HasName("PK__BEND_VAL__B0AAE7CFAAB8B7C6");

                entity.ToTable("BEND_VALIDACIONES");

                entity.Property(e => e.IdValidacion).HasColumnName("idValidacion");
                entity.Property(e => e.TipoValidacion)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoValidacion");
            });

            modelBuilder.Entity<BoffApoderado>(entity =>
            {
                entity.HasKey(e => e.IdApoderado).HasName("PK__BOFF_APO__D735979D9565A136");

                entity.ToTable("BOFF_APODERADOS");

                entity.Property(e => e.IdApoderado).HasColumnName("idApoderado");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.DireccionApoderado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("direccionApoderado");
                entity.Property(e => e.EmailApoderado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailApoderado");
                entity.Property(e => e.EstadoApoderado).HasColumnName("estadoApoderado");
                entity.Property(e => e.FecCreacionApoderado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionApoderado");
                entity.Property(e => e.NombreApoderado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreApoderado");
                entity.Property(e => e.NumeroDocumentoApoderado)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoApoderado");
                entity.Property(e => e.TelefonoApoderado)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("telefonoApoderado");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffApoderados)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APODERADOS_CLIENTE_idCliente");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BoffApoderados)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APODERADOS_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BoffAsociacionColorCliente>(entity =>
            {
                entity.HasKey(e => e.IdAsociacionColorCliente).HasName("PK__BOFF_ASO__A70CC7277294E1F8");

                entity.ToTable("BOFF_ASOCIACION_COLOR_CLIENTES");

                entity.Property(e => e.IdAsociacionColorCliente).HasColumnName("idAsociacionColorCliente");
                entity.Property(e => e.ColorId).HasColumnName("colorId");
                entity.Property(e => e.CustomizaElementoId).HasColumnName("customizaElementoId");
                entity.Property(e => e.FecActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacion");
                entity.Property(e => e.FecCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacion");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.Color).WithMany(p => p.BoffAsociacionColorClientes)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASOC_COLOR_idColor");

                entity.HasOne(d => d.CustomizaElemento).WithMany(p => p.BoffAsociacionColorClientes)
                    .HasForeignKey(d => d.CustomizaElementoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASOC_CUSTOM_idCustomizaElemento");
            });

            modelBuilder.Entity<BoffCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente).HasName("PK__BOFF_CLI__885457EE6860AC5D");

                entity.ToTable("BOFF_CLIENTES");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");
                entity.Property(e => e.DireccionCliente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("direccionCliente");
                entity.Property(e => e.EmailCliente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailCliente");
                entity.Property(e => e.EstadoCliente).HasColumnName("estadoCliente");
                entity.Property(e => e.FecCreacionCliente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionCliente");
                entity.Property(e => e.LocacionId).HasColumnName("locacionId");
                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreCliente");
                entity.Property(e => e.NumeroDocumentoCliente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoCliente");
                entity.Property(e => e.RutaLogoCliente)
                    .HasMaxLength(250)
                    .HasColumnName("rutaLogoCliente");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");
                entity.Property(e => e.TipoPersonaId).HasColumnName("tipoPersonaId");

                entity.HasOne(d => d.Locacion).WithMany(p => p.BoffClientes)
                    .HasForeignKey(d => d.LocacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTES_LOCACION_idLocacion");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BoffClientes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTES_TIPODOCUMENTO_idTipoDocumento");

                entity.HasOne(d => d.TipoPersona).WithMany(p => p.BoffClientes)
                    .HasForeignKey(d => d.TipoPersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTES_TIPOPERSONA_idTipoPersona");
            });

            modelBuilder.Entity<BoffColore>(entity =>
            {
                entity.HasKey(e => e.IdColor).HasName("PK__BOFF_COL__504A3B8810CB4F85");

                entity.ToTable("BOFF_COLORES");

                entity.Property(e => e.IdColor).HasColumnName("idColor");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.FecActualizacionColor)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionColor");
                entity.Property(e => e.FecCreacionColor)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionColor");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.Primario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("primario");
                entity.Property(e => e.Secundario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("secundario");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffColores)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COLOR_CLIENTE_idCliente");
            });

            modelBuilder.Entity<BoffConfigCliente>(entity =>
            {
                entity.HasKey(e => e.IdConfigCliente).HasName("PK__BOFF_CON__789329F06D4D5968");

                entity.ToTable("BOFF_CONFIG_CLIENTES");

                entity.Property(e => e.IdConfigCliente).HasColumnName("idConfigCliente");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.CorrelativoConfigCliente)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("correlativoConfigCliente");
                entity.Property(e => e.EstadoConfigcliente).HasColumnName("estadoConfigcliente");
                entity.Property(e => e.FecCreacionConfigCliente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionConfigCliente");
                entity.Property(e => e.PrefijoConfigCliente)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("prefijoConfigCliente");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffConfigClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONFIGCLIENTES_CLIENTES_idCliente");
            });

            modelBuilder.Entity<BoffCuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta).HasName("PK__BOFF_CUE__BBC6DF326E210EFC");

                entity.ToTable("BOFF_CUENTAS");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.CodIdentificacionCuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codIdentificacionCuenta");
                entity.Property(e => e.EstadoCuenta).HasColumnName("estadoCuenta");
                entity.Property(e => e.FecCreacionCuenta)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionCuenta");
                entity.Property(e => e.NombreCuenta)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreCuenta");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffCuenta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CUENTA_CLIENTE_idCliente");
            });

            modelBuilder.Entity<BoffCuentasAgente>(entity =>
            {
                entity.HasKey(e => e.IdCuentaAgente).HasName("PK__BOFF_CUE__3833D224DD53C00F");

                entity.ToTable("BOFF_CUENTAS_AGENTE");

                entity.Property(e => e.IdCuentaAgente).HasColumnName("idCuentaAgente");
                entity.Property(e => e.CuentaId).HasColumnName("cuentaId");
                entity.Property(e => e.DireccionAgente)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("direccionAgente");
                entity.Property(e => e.EmailAgente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailAgente");
                entity.Property(e => e.EstadoAgente).HasColumnName("estadoAgente");
                entity.Property(e => e.FecCreacionAgente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionAgente");
                entity.Property(e => e.NombreAgente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreAgente");
                entity.Property(e => e.NumeroDocumentoAgente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoAgente");
                entity.Property(e => e.PoderDemanda).HasColumnName("poderDemanda");
                entity.Property(e => e.TelefonoAgente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoAgente");
                entity.Property(e => e.TipoAgente)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tipoAgente");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Cuenta).WithMany(p => p.BoffCuentasAgentes)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENTE_CUENTA_idCuenta");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BoffCuentasAgentes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENTE_TIPO_DOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BoffEstadoProcesalDocumento>(entity =>
            {
                entity.HasKey(e => e.IdEstadoProcesalDocumento).HasName("PK__BOFF_EST__A8FC7B32E179CAA4");

                entity.ToTable("BOFF_ESTADO_PROCESAL_DOCUMENTOS");

                entity.Property(e => e.IdEstadoProcesalDocumento).HasColumnName("idEstadoProcesalDocumento");
                entity.Property(e => e.EstadoDocumento).HasColumnName("estadoDocumento");
                entity.Property(e => e.EstatusProcesoId).HasColumnName("estatusProcesoId");
                entity.Property(e => e.FecActulacionEntregaDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActulacionEntregaDocumento");
                entity.Property(e => e.FecCreacionEstadoProcesalDocumento)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionEstadoProcesalDocumento");
                entity.Property(e => e.TipoExpDocumentoId).HasColumnName("tipoExpDocumentoId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.EstatusProceso).WithMany(p => p.BoffEstadoProcesalDocumentos)
                    .HasForeignKey(d => d.EstatusProcesoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESAL_DOCUMENTOS_ESTATUS_idEstatusProceso");

                entity.HasOne(d => d.TipoExpDocumento).WithMany(p => p.BoffEstadoProcesalDocumentos)
                    .HasForeignKey(d => d.TipoExpDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESAL_DOCUMENTOS_TIPOEXPDOCUMENTOS_idTipoExpDocumento");

                entity.HasOne(d => d.Usuario).WithMany(p => p.BoffEstadoProcesalDocumentos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROCESAL_DOCUMENTOS_USUARIO_idUsuario");
            });

            modelBuilder.Entity<BoffHistContrasena>(entity =>
            {
                entity.HasKey(e => e.IdHistContrasena).HasName("PK__BOFF_HIS__F64B5534225010A8");

                entity.ToTable("BOFF_HIST_CONTRASENAS");

                entity.Property(e => e.IdHistContrasena).HasColumnName("idHistContrasena");
                entity.Property(e => e.FecFinContrasena)
                    .HasColumnType("date")
                    .HasColumnName("fecFinContrasena");
                entity.Property(e => e.FecIniContrasena)
                    .HasColumnType("date")
                    .HasColumnName("fecIniContrasena");
                entity.Property(e => e.UsuarioContrasena)
                    .HasMaxLength(250)
                    .HasColumnName("usuarioContrasena");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValidacionId).HasColumnName("validacionId");

                entity.HasOne(d => d.Usuario).WithMany(p => p.BoffHistContrasenas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISCONTRASENA_USUARIOS_idUsuario");

                entity.HasOne(d => d.Validacion).WithMany(p => p.BoffHistContrasenas)
                    .HasForeignKey(d => d.ValidacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISCONTRASENA_VALIDACIONES_idValidacion");
            });

            modelBuilder.Entity<BoffHistSesionesActiva>(entity =>
            {
                entity.HasKey(e => e.IdHistSesionActiva).HasName("PK__BOFF_HIS__BBEC5BD445B0A8DE");

                entity.ToTable("BOFF_HIST_SESIONES_ACTIVAS");

                entity.Property(e => e.IdHistSesionActiva).HasColumnName("idHistSesionActiva");
                entity.Property(e => e.FecInicioHistSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioHistSesion");
                entity.Property(e => e.FecfinHistSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecfinHistSesion");
                entity.Property(e => e.SesionActivaUsuarioId).HasColumnName("sesionActivaUsuarioId");
            });

            modelBuilder.Entity<BoffHistSesionesErronea>(entity =>
            {
                entity.HasKey(e => e.IdHistSesionErronea).HasName("PK__BOFF_HIS__F331AC4D4FD18AA5");

                entity.ToTable("BOFF_HIST_SESIONES_ERRONEAS");

                entity.Property(e => e.IdHistSesionErronea).HasColumnName("idHistSesionErronea");
                entity.Property(e => e.FecInicioHistSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioHistSesion");
                entity.Property(e => e.FecfinHistSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecfinHistSesion");
                entity.Property(e => e.SesionErroneaUsuarioId).HasColumnName("sesionErroneaUsuarioId");
            });

            modelBuilder.Entity<BoffPerfilRole>(entity =>
            {
                entity.HasKey(e => e.IdPerfilRol).HasName("PK__BOFF_PER__FF59545BF1B08156");

                entity.ToTable("BOFF_PERFIL_ROLES");

                entity.Property(e => e.IdPerfilRol).HasColumnName("idPerfilRol");
                entity.Property(e => e.Actor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("actor");
                entity.Property(e => e.DescripcionPerfilRol)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descripcionPerfilRol");
                entity.Property(e => e.EstadoPerfilRol).HasColumnName("estadoPerfilRol");
                entity.Property(e => e.FecCreacionPerfilRol)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPerfilRol");
                entity.Property(e => e.IdUsuarioAlta).HasColumnName("idUsuarioAlta");
                entity.Property(e => e.PerfilId).HasColumnName("perfilId");
                entity.Property(e => e.RolId).HasColumnName("rolId");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Perfil).WithMany(p => p.BoffPerfilRoles)
                    .HasForeignKey(d => d.PerfilId)
                    .HasConstraintName("FK_PERFIL_ROLES_idPerfil");

                entity.HasOne(d => d.Rol).WithMany(p => p.BoffPerfilRoles)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIL_ROLES_idRol");

                entity.HasOne(d => d.Usuario).WithMany(p => p.BoffPerfilRoles)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFIL_ROLES_idUsuario");
            });

            modelBuilder.Entity<BoffPerfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfil).HasName("PK__BOFF_PER__40F13B608F16E885");

                entity.ToTable("BOFF_PERFILES");

                entity.Property(e => e.IdPerfil).HasColumnName("idPerfil");
                entity.Property(e => e.DescripcionPerfil)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionPerfil");
                entity.Property(e => e.EstadoPerfil).HasColumnName("estadoPerfil");
                entity.Property(e => e.FecActualizacionPerfil)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionPerfil");
                entity.Property(e => e.FecCreacionPerfil)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPerfil");
            });

            modelBuilder.Entity<BoffPerfilesPermiso>(entity =>
            {
                entity.HasKey(e => e.IdPerfilPermiso).HasName("PK__BOFF_PER__47153D95E992EB55");

                entity.ToTable("BOFF_PERFILES_PERMISOS");

                entity.Property(e => e.IdPerfilPermiso).HasColumnName("idPerfilPermiso");
                entity.Property(e => e.EstadoPerfilPermiso).HasColumnName("estadoPerfilPermiso");
                entity.Property(e => e.FecActualizacionPerfilPermiso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionPerfilPermiso");
                entity.Property(e => e.FecCreacionPerfilPermiso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPerfilPermiso");
                entity.Property(e => e.FuncionPerfilPermiso)
                    .HasMaxLength(250)
                    .HasColumnName("funcionPerfilPermiso");
                entity.Property(e => e.ObjetoId).HasColumnName("objetoId");
                entity.Property(e => e.PerfilId).HasColumnName("perfilId");
                entity.Property(e => e.PermisoId).HasColumnName("permisoId");
                entity.Property(e => e.UrlPerfilPermiso)
                    .HasMaxLength(400)
                    .HasColumnName("urlPerfilPermiso");

                entity.HasOne(d => d.Objeto).WithMany(p => p.BoffPerfilesPermisos)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFILPERMISOS_OBJETOS_idObjeto");

                entity.HasOne(d => d.Perfil).WithMany(p => p.BoffPerfilesPermisos)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFILPERMISOS_PERFILES_idPerfil");

                entity.HasOne(d => d.Permiso).WithMany(p => p.BoffPerfilesPermisos)
                    .HasForeignKey(d => d.PermisoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PERFILPERMISOS_PERMISOS_idPermiso");
            });

            modelBuilder.Entity<BoffPermiso>(entity =>
            {
                entity.HasKey(e => e.IdPermiso).HasName("PK__BOFF_PER__06A5848641D0CE82");

                entity.ToTable("BOFF_PERMISOS");

                entity.Property(e => e.IdPermiso).HasColumnName("idPermiso");
                entity.Property(e => e.DescripcionPermiso)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionPermiso");
                entity.Property(e => e.EstadoPermiso).HasColumnName("estadoPermiso");
                entity.Property(e => e.FecActualizacionPermiso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionPermiso");
                entity.Property(e => e.FecCreacionPermiso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionPermiso");
            });

            modelBuilder.Entity<BoffRepresentante>(entity =>
            {
                entity.HasKey(e => e.IdRepresentante).HasName("PK__BOFF_REP__119773E3876662D1");

                entity.ToTable("BOFF_REPRESENTANTES");

                entity.Property(e => e.IdRepresentante).HasColumnName("idRepresentante");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.DireccionRepresentante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("direccionRepresentante");
                entity.Property(e => e.EmailRepresentante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailRepresentante");
                entity.Property(e => e.EstadoRepresentante).HasColumnName("estadoRepresentante");
                entity.Property(e => e.FecCreacionRepresentante)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionRepresentante");
                entity.Property(e => e.NombreRepresentante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreRepresentante");
                entity.Property(e => e.NumeroDocumentoRepresentante)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoRepresentante");
                entity.Property(e => e.TelefonoRepresentante)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("telefonoRepresentante");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffRepresentantes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPRESENTANTES_CLIENTE_idCliente");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BoffRepresentantes)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPRESENTANTES_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BoffRole>(entity =>
            {
                entity.HasKey(e => e.IdRol).HasName("PK__BOFF_ROL__3C872F766444C158");

                entity.ToTable("BOFF_ROLES");

                entity.Property(e => e.IdRol).HasColumnName("idRol");
                entity.Property(e => e.DescripcionRol)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionRol");
                entity.Property(e => e.EstadoRol).HasColumnName("estadoRol");
                entity.Property(e => e.FecActualizacionRol)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionRol");
                entity.Property(e => e.FecCreacionRol)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionRol");
            });

            modelBuilder.Entity<BoffSesionesActiva>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("BOFF_SESIONES_ACTIVAS");

                entity.Property(e => e.CodigoVerifSesion)
                    .HasMaxLength(150)
                    .HasColumnName("codigoVerifSesion");
                entity.Property(e => e.FecCodigoVerifSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCodigoVerifSesion");
                entity.Property(e => e.FecInicioSesion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecInicioSesion");
                entity.Property(e => e.FlagExitoSesion).HasColumnName("flagExitoSesion");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
                entity.Property(e => e.ValidacionId).HasColumnName("validacionId");

                entity.HasOne(d => d.Usuario).WithMany()
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESIONACTIVA_USUARIOS_idUsuario");

                entity.HasOne(d => d.Validacion).WithMany()
                    .HasForeignKey(d => d.ValidacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESIONACTIVA_VALIDACION_idValidacion");
            });

            modelBuilder.Entity<BoffSesionesErronea>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("BOFF_SESIONES_ERRONEAS");

                entity.Property(e => e.FecSesionErronea)
                    .HasColumnType("datetime")
                    .HasColumnName("fecSesionErronea");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Usuario).WithMany()
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESIONERRONEA_USUARIOS_idUsuario");
            });

            modelBuilder.Entity<BoffSesionesObjeto>(entity =>
            {
                entity.HasKey(e => e.IdSesionObjeto).HasName("PK__BOFF_SES__04AAA2544A2A7157");

                entity.ToTable("BOFF_SESIONES_OBJETOS");

                entity.Property(e => e.IdSesionObjeto).HasColumnName("idSesionObjeto");
                entity.Property(e => e.FecSesionObjeto)
                    .HasColumnType("datetime")
                    .HasColumnName("fecSesionObjeto");
                entity.Property(e => e.ObjetoId).HasColumnName("objetoId");
                entity.Property(e => e.SesionId).HasColumnName("sesionId");

                entity.HasOne(d => d.Objeto).WithMany(p => p.BoffSesionesObjetos)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SESIONOBJETO_OBJETO_idObjeto");
            });

            modelBuilder.Entity<BoffTipoBitacora>(entity =>
            {
                entity.HasKey(e => e.IdTipoBitacora).HasName("PK__BOFF_TIP__D4B6FAF82C245321");

                entity.ToTable("BOFF_TIPO_BITACORA");

                entity.Property(e => e.IdTipoBitacora).HasColumnName("idTipoBitacora");
                entity.Property(e => e.CodigoBitacora)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("codigoBitacora");
                entity.Property(e => e.ControlWeb).HasColumnName("controlWeb");
                entity.Property(e => e.EstadoBitacora).HasColumnName("estadoBitacora");
                entity.Property(e => e.FecActualizacionBitacora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionBitacora");
                entity.Property(e => e.FecCreacionBitacora)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionBitacora");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreBitacora)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreBitacora");
            });

            modelBuilder.Entity<BoffTipoEtapaMedidaCautelar>(entity =>
            {
                entity.HasKey(e => e.IdTipoEtapaMedidaCautelar).HasName("PK__BOFF_TIP__AFDF208CB5D595D5");

                entity.ToTable("BOFF_TIPO_ETAPA_MEDIDA_CAUTELAR");

                entity.Property(e => e.IdTipoEtapaMedidaCautelar).HasColumnName("idTipoEtapaMedidaCautelar");
                entity.Property(e => e.EstadoTipoEtapaMedidaCautelar).HasColumnName("estadoTipoEtapaMedidaCautelar");
                entity.Property(e => e.FecActualizacionTipoEtapaMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionTipoEtapaMedidaCautelar");
                entity.Property(e => e.FecCreacionTipoEtapaMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoEtapaMedidaCautelar");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreTipoEtapaMedidaCautelar)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreTipoEtapaMedidaCautelar");
                entity.Property(e => e.NroOrdenEtapaMedidaCautelar).HasColumnName("nroOrdenEtapaMedidaCautelar");
            });

            modelBuilder.Entity<BoffTipoMedidasCautelare>(entity =>
            {
                entity.HasKey(e => e.IdTipoMedidaCautelar).HasName("PK__BOFF_TIP__8FD696B62D6C34B7");

                entity.ToTable("BOFF_TIPO_MEDIDAS_CAUTELARES");

                entity.Property(e => e.IdTipoMedidaCautelar).HasColumnName("idTipoMedidaCautelar");
                entity.Property(e => e.DescripcionTipoMedidaCautelar)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoMedidaCautelar");
                entity.Property(e => e.EstadoTipoMedidaCautelar).HasColumnName("estadoTipoMedidaCautelar");
                entity.Property(e => e.FecActualizacionTipoMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionTipoMedidaCautelar");
                entity.Property(e => e.FecCreacionTipoMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTipoMedidaCautelar");
            });

            modelBuilder.Entity<BoffTipoSubetapaMedidaCautelar>(entity =>
            {
                entity.HasKey(e => e.IdTipoSubetapaMedidaCautelar).HasName("PK__BOFF_TIP__4920BBA3F92F582E");

                entity.ToTable("BOFF_TIPO_SUBETAPA_MEDIDA_CAUTELAR");

                entity.Property(e => e.IdTipoSubetapaMedidaCautelar).HasColumnName("idTipoSubetapaMedidaCautelar");
                entity.Property(e => e.EstadoSubetapaMedidaCautelar).HasColumnName("estadoSubetapaMedidaCautelar");
                entity.Property(e => e.FecActualizacionSubetapaMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionSubetapaMedidaCautelar");
                entity.Property(e => e.FecCreacionSubetapaMedidaCautelar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionSubetapaMedidaCautelar");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.NombreSubetapaMedidaCautelar)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreSubetapaMedidaCautelar");
                entity.Property(e => e.NroOrdenSubetapaMedidaCautelar).HasColumnName("nroOrdenSubetapaMedidaCautelar");
                entity.Property(e => e.TipoEtapaMedidaCautelarId).HasColumnName("tipoEtapaMedidaCautelarId");

                entity.HasOne(d => d.TipoEtapaMedidaCautelar).WithMany(p => p.BoffTipoSubetapaMedidaCautelars)
                    .HasForeignKey(d => d.TipoEtapaMedidaCautelarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SUBETAPA_MEDIDACAUTELAR_ETAPAMEDIDACAUTELAR_idTipoEtapaMedidaCautelar");
            });

            modelBuilder.Entity<BoffUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario).HasName("PK__BOFF_USU__645723A6BC285E6B");

                entity.ToTable("BOFF_USUARIOS");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
                entity.Property(e => e.ApellidosUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("apellidosUsuario");
                entity.Property(e => e.ClienteId).HasColumnName("clienteId");
                entity.Property(e => e.ContrasenaUsuario)
                    .HasMaxLength(250)
                    .HasColumnName("contrasenaUsuario");
                entity.Property(e => e.DescripcionEstadoUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionEstadoUsuario");
                entity.Property(e => e.EmailUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailUsuario");
                entity.Property(e => e.EstadoContrasenaUsuario).HasColumnName("estadoContrasenaUsuario");
                entity.Property(e => e.EstadoUsuario).HasColumnName("estadoUsuario");
                entity.Property(e => e.FecAltaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAltaUsuario");
                entity.Property(e => e.FecBajaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecBajaUsuario");
                entity.Property(e => e.FecFinContrasenaUsuario)
                    .HasColumnType("datetime")
                    .HasColumnName("fecFinContrasenaUsuario");
                entity.Property(e => e.LoginUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("loginUsuario");
                entity.Property(e => e.NombresUsuario)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombresUsuario");
                entity.Property(e => e.NumeroDocumentoUsuario)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoUsuario");
                entity.Property(e => e.RespuestaId).HasColumnName("respuestaId");
                entity.Property(e => e.RolId).HasColumnName("rolId");
                entity.Property(e => e.TelefonoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoUsuario");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");
                entity.Property(e => e.VerificarCorreo).HasColumnName("verificarCorreo");

                entity.HasOne(d => d.Cliente).WithMany(p => p.BoffUsuarios)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOFFUSUARIO_CLIENTES_idCliente");

                entity.HasOne(d => d.Respuesta).WithMany(p => p.BoffUsuarios)
                    .HasForeignKey(d => d.RespuestaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOFFUSUARIO_RESPUESTAS_idRespuesta");

                entity.HasOne(d => d.Rol).WithMany(p => p.BoffUsuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOFFUSUARIO_ROLES_idRol");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.BoffUsuarios)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOFFUSUARIO_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<BoffUsuarioCuenta>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioCuenta).HasName("PK__BOFF_USU__3127B6D2C80DCED8");

                entity.ToTable("BOFF_USUARIO_CUENTAS");

                entity.Property(e => e.IdUsuarioCuenta).HasColumnName("idUsuarioCuenta");
                entity.Property(e => e.CuentaId).HasColumnName("cuentaId");
                entity.Property(e => e.EstadoUsuarioCuenta).HasColumnName("estadoUsuarioCuenta");
                entity.Property(e => e.IdUsuarioCreador).HasColumnName("idUsuarioCreador");
                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Cuenta).WithMany(p => p.BoffUsuarioCuenta)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_CUENTAS_CUENTAS_idCuenta");

                entity.HasOne(d => d.Usuario).WithMany(p => p.BoffUsuarioCuenta)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_CUENTAS_USUARIOS_idUsuario");
            });

            modelBuilder.Entity<GbotBot>(entity =>
            {
                entity.HasKey(e => e.IdBot).HasName("PK__GBOT_BOT__383960253D6A4C3E");

                entity.ToTable("GBOT_BOTS");

                entity.Property(e => e.IdBot).HasColumnName("idBot");
                entity.Property(e => e.CodigoBot)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("codigoBot");
                entity.Property(e => e.NombreBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreBot");
                entity.Property(e => e.ProcesoBotId).HasColumnName("procesoBotId");
                entity.Property(e => e.TipoAmbienteId).HasColumnName("tipoAmbienteId");

                entity.HasOne(d => d.ProcesoBot).WithMany(p => p.GbotBots)
                    .HasForeignKey(d => d.ProcesoBotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOTS_PROCESOSBOTS_idProcesoBot");

                entity.HasOne(d => d.TipoAmbiente).WithMany(p => p.GbotBots)
                    .HasForeignKey(d => d.TipoAmbienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOTS_TIPOAMBIENTES_idTipoAmbiente");
            });

            modelBuilder.Entity<GbotHistGestionBot>(entity =>
            {
                entity.HasKey(e => e.IdGestBot).HasName("PK__GBOT_HIS__9D7964CD03619914");

                entity.ToTable("GBOT_HIST_GESTION_BOTS");

                entity.Property(e => e.IdGestBot)
                    .ValueGeneratedNever()
                    .HasColumnName("idGestBot");
                entity.Property(e => e.BotId).HasColumnName("botId");
                entity.Property(e => e.FecGestBot)
                    .HasColumnType("datetime")
                    .HasColumnName("fecGestBot");
                entity.Property(e => e.NumeroDocumentoAuxGestBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoAuxGestBot");
                entity.Property(e => e.NumeroDocumentoGestBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoGestBot");
                entity.Property(e => e.ObjetoId).HasColumnName("objetoId");
                entity.Property(e => e.TipoDocumentoAuxGestBot)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumentoAuxGestBot");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Bot).WithMany(p => p.GbotHistGestionBots)
                    .HasForeignKey(d => d.BotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTGESTBOTS_BOTS_idBot");

                entity.HasOne(d => d.Objeto).WithMany(p => p.GbotHistGestionBots)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTGESTBOTS_OBJETOS_idObjeto");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.GbotHistGestionBots)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTGESTBOTS_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<GbotHistLogBot>(entity =>
            {
                entity.HasKey(e => e.IdLogBot).HasName("PK__GBOT_HIS__2E2BA02A3EAE9F2A");

                entity.ToTable("GBOT_HIST_LOG_BOTS");

                entity.Property(e => e.IdLogBot)
                    .ValueGeneratedNever()
                    .HasColumnName("idLogBot");
                entity.Property(e => e.BotId).HasColumnName("botId");
                entity.Property(e => e.FecLogBot)
                    .HasColumnType("datetime")
                    .HasColumnName("fecLogBot");
                entity.Property(e => e.FlagBarrido).HasColumnName("flagBarrido");
                entity.Property(e => e.LogCategoriaId).HasColumnName("logCategoriaId");
                entity.Property(e => e.LogEventoId).HasColumnName("logEventoId");
                entity.Property(e => e.LogFuenteId).HasColumnName("logFuenteId");
                entity.Property(e => e.LogInteraccionId).HasColumnName("logInteraccionId");
                entity.Property(e => e.Mensaje)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("mensaje");
                entity.Property(e => e.NumeroDocumentoAuxLogBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoAuxLogBot");
                entity.Property(e => e.NumeroDocumentoLogBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("numeroDocumentoLogBot");
                entity.Property(e => e.TipoDocumentoAuxLogBot)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumentoAuxLogBot");
                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumentoId");

                entity.HasOne(d => d.Bot).WithMany(p => p.GbotHistLogBots)
                    .HasForeignKey(d => d.BotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTLOGBOTS_BOTS_idBot");

                entity.HasOne(d => d.LogCategoria).WithMany(p => p.GbotHistLogBots)
                    .HasForeignKey(d => d.LogCategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTLOGBOTS_LOGCATEGORIAS_idLogCategoria");

                entity.HasOne(d => d.LogEvento).WithMany(p => p.GbotHistLogBots)
                    .HasForeignKey(d => d.LogEventoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTLOGBOTS_LOGEVENTOS_idLogEvento");

                entity.HasOne(d => d.LogInteraccion).WithMany(p => p.GbotHistLogBots)
                    .HasForeignKey(d => d.LogInteraccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTLOGBOTS_LOGINTERACCIONES_idLogInteraccion");

                entity.HasOne(d => d.TipoDocumento).WithMany(p => p.GbotHistLogBots)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HISTLOGBOTS_TIPODOCUMENTO_idTipoDocumento");
            });

            modelBuilder.Entity<GbotLogCategoria>(entity =>
            {
                entity.HasKey(e => e.IdLogCategoria).HasName("PK__GBOT_LOG__869C228EC2872207");

                entity.ToTable("GBOT_LOG_CATEGORIAS");

                entity.Property(e => e.IdLogCategoria).HasColumnName("idLogCategoria");
                entity.Property(e => e.NombreLogCategoria)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreLogCategoria");
            });

            modelBuilder.Entity<GbotLogEvento>(entity =>
            {
                entity.HasKey(e => e.IdLogEvento).HasName("PK__GBOT_LOG__45215E7B2FEAD496");

                entity.ToTable("GBOT_LOG_EVENTOS");

                entity.Property(e => e.IdLogEvento).HasColumnName("idLogEvento");
                entity.Property(e => e.NombreLogEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreLogEvento");
            });

            modelBuilder.Entity<GbotLogFuente>(entity =>
            {
                entity.HasKey(e => e.IdLogFuentes).HasName("PK__GBOT_LOG__18D45F923F362261");

                entity.ToTable("GBOT_LOG_FUENTES");

                entity.Property(e => e.IdLogFuentes).HasColumnName("idLogFuentes");
                entity.Property(e => e.NombreLogFuentes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreLogFuentes");
            });

            modelBuilder.Entity<GbotLogInteraccione>(entity =>
            {
                entity.HasKey(e => e.IdLogInteraccion).HasName("PK__GBOT_LOG__05C411ACB220EBC3");

                entity.ToTable("GBOT_LOG_INTERACCIONES");

                entity.Property(e => e.IdLogInteraccion).HasColumnName("idLogInteraccion");
                entity.Property(e => e.NombreLogInteraccion)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreLogInteraccion");
            });

            modelBuilder.Entity<GbotProcesosBot>(entity =>
            {
                entity.HasKey(e => e.IdProcesoBot).HasName("PK__GBOT_PRO__EF60F4E84954BBB3");

                entity.ToTable("GBOT_PROCESOS_BOTS");

                entity.Property(e => e.IdProcesoBot).HasColumnName("idProcesoBot");
                entity.Property(e => e.NombreProcesoBot)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombreProcesoBot");
            });

            modelBuilder.Entity<GibdAuditoriaTabla>(entity =>
            {
                entity.HasKey(e => e.IdAuditoriaTabla).HasName("PK__GIBD_AUD__7616020EFEA9F17A");

                entity.ToTable("GIBD_AUDITORIA_TABLAS");

                entity.Property(e => e.IdAuditoriaTabla).HasColumnName("idAuditoriaTabla");
                entity.Property(e => e.DescripcionAuditoriaTabla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("descripcionAuditoriaTabla");
                entity.Property(e => e.FecAuditoriaTabla)
                    .HasColumnType("datetime")
                    .HasColumnName("fecAuditoriaTabla");
                entity.Property(e => e.TablaId).HasColumnName("tablaId");

                entity.HasOne(d => d.Tabla).WithMany(p => p.GibdAuditoriaTablas)
                    .HasForeignKey(d => d.TablaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AUDITORIATABLA_TABLAS_idTabla");
            });

            modelBuilder.Entity<GibdProcesosTabla>(entity =>
            {
                entity.HasKey(e => e.IdProceso).HasName("PK__GIBD_PRO__DEC8292695F896B8");

                entity.ToTable("GIBD_PROCESOS_TABLAS");

                entity.Property(e => e.IdProceso).HasColumnName("idProceso");
                entity.Property(e => e.EstadoProceso).HasColumnName("estadoProceso");
                entity.Property(e => e.NombreProceso)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreProceso");
                entity.Property(e => e.PrefijoProceso)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("prefijoProceso");
            });

            modelBuilder.Entity<GibdTabla>(entity =>
            {
                entity.HasKey(e => e.IdTabla).HasName("PK__GIBD_TAB__716BDE20DB284C34");

                entity.ToTable("GIBD_TABLAS");

                entity.Property(e => e.IdTabla).HasColumnName("idTabla");
                entity.Property(e => e.FecActualizacionTabla)
                    .HasColumnType("datetime")
                    .HasColumnName("fecActualizacionTabla");
                entity.Property(e => e.FecCreacionTabla)
                    .HasColumnType("datetime")
                    .HasColumnName("fecCreacionTabla");
                entity.Property(e => e.NombreTabla)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreTabla");
                entity.Property(e => e.ProcesoId).HasColumnName("procesoId");
                entity.Property(e => e.TipoAmbienteId).HasColumnName("tipoAmbienteId");

                entity.HasOne(d => d.Proceso).WithMany(p => p.GibdTablas)
                    .HasForeignKey(d => d.ProcesoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABLAS_PROCESO_idProceso");

                entity.HasOne(d => d.TipoAmbiente).WithMany(p => p.GibdTablas)
                    .HasForeignKey(d => d.TipoAmbienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABLAS_AMBIENTE_idTipoAmbiente");
            });

            modelBuilder.Entity<GibdTipoAmbiente>(entity =>
            {
                entity.HasKey(e => e.IdTipoAmbiente).HasName("PK__GIBD_TIP__AE5ECEDBB873144F");

                entity.ToTable("GIBD_TIPO_AMBIENTES");

                entity.Property(e => e.IdTipoAmbiente).HasColumnName("idTipoAmbiente");
                entity.Property(e => e.NombreAmbiente)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombreAmbiente");
            });

            modelBuilder.Entity<InvbTipoInmueble>(entity =>
            {
                entity.HasKey(e => e.IdTipoInmueble).HasName("PK__INVB_TIP__73A1AD1514FE7C9F");

                entity.ToTable("INVB_TIPO_INMUEBLES");

                entity.Property(e => e.IdTipoInmueble).HasColumnName("idTipoInmueble");
                entity.Property(e => e.DescripcionTipoInmueble)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descripcionTipoInmueble");
            });

            modelBuilder.Entity<BendHistBusqCabecera>()
            .HasOne(b => b.TipoMedidaCautelar)
            .WithMany()
            .HasForeignKey(b => b.TipoMedidaCautelarId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqCabecera>()
                .HasOne(b => b.Deudor)
                .WithMany()
                .HasForeignKey(b => b.DeudorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqCabecera>()
                .ToTable("Bend_Hist_Busq_Cabeceras");
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<BendHistBusqOtrosDetalle>()
            .HasOne(b => b.BendHistBusqCabecera)
            .WithMany()
            .HasForeignKey(b => b.BendHistBusqCabeceraId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqOtrosDetalle>()
                .ToTable("BEND_HIST_BUSQ_OTROS_DETALLES");
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<BendHistBusqEstablecimientoComerciosDetalle>()
            .HasOne(b => b.BendHistBusqCabecera)
            .WithMany()
            .HasForeignKey(b => b.BendHistBusqCabeceraId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqEstablecimientoComerciosDetalle>()
                .ToTable("BEND_HIST_BUSQ_ESTABLECIMIENTOS_COMERCIOS_DETALLES");
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<BendHistBusqCuentasBancariasDetalle>()
            .HasOne(b => b.BendHistBusqCabecera)
            .WithMany()
            .HasForeignKey(b => b.BendHistBusqCabeceraId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqCuentasBancariasDetalle>()
                .ToTable("BEND_HIST_BUSQ_CUENTAS_BANCARIAS_DETALLES");
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<BendHistBusqRemanentesDetalle>()
            .HasOne(b => b.BendHistBusqCabecera)
            .WithMany()
            .HasForeignKey(b => b.BendHistBusqCabeceraId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BendHistBusqRemanentesDetalle>()
                .ToTable("BEND_HIST_BUSQ_CUENTAS_REMANENTES_DETALLES");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
