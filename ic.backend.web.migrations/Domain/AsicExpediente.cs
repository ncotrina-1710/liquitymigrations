using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class AsicExpediente
{
    public int IdExpediente { get; set; }

    public int? CabeceraId { get; set; }

    public string? Expediente { get; set; }

    public int? ClienteId { get; set; }

    public string? Llave { get; set; }

    public int? RepresentanteId { get; set; }

    public int? ApoderadoId { get; set; }

    public int? DemandadoId { get; set; }

    public int? DemandadoId2 { get; set; }

    public int? DemandadoId3 { get; set; }

    public int? DemandadoId4 { get; set; }

    public int? DemandanteId { get; set; }

    public int? TipoProcesoId { get; set; }

    public int? SedeId { get; set; }

    public int? CuentaId { get; set; }

    public int? SubEtapaId { get; set; }

    public int? EstadoProcesalId { get; set; }

    public int? AbogadoId { get; set; }

    public int? TipocuantiaId { get; set; }

    public string? NroRadicacion { get; set; }

    public string? NroRadicacionCorta { get; set; }

    public string? Gyc { get; set; }

    public bool? PlanCompartir { get; set; }

    public int? EstadoDetalle { get; set; }

    public DateTime? FecAsignacion { get; set; }

    public DateTime? PrescripcionDetalle { get; set; }

    public DateTime? FecSustitucion { get; set; }

    public DateTime? FecPresentacion { get; set; }

    public bool? FlagFng { get; set; }

    public bool? DocFngTramitado { get; set; }

    public decimal? VrPagoFng { get; set; }

    public DateTime? FecLiquidacion { get; set; }

    public decimal? ValorLiquidacion { get; set; }

    public decimal? ValorRemate { get; set; }

    public string? ObservacionDetalle { get; set; }

    public DateTime? FecCreacionExpediente { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ApliAbogado? Abogado { get; set; }

    public virtual ICollection<ApliActuacionesExpediente> ApliActuacionesExpedientes { get; set; } = new List<ApliActuacionesExpediente>();

    public virtual ICollection<ApliAsignacione> ApliAsignaciones { get; set; } = new List<ApliAsignacione>();

    public virtual ICollection<ApliDetalleExpedienteEvento> ApliDetalleExpedienteEventos { get; set; } = new List<ApliDetalleExpedienteEvento>();

    public virtual ICollection<ApliEstatusProceso> ApliEstatusProcesos { get; set; } = new List<ApliEstatusProceso>();

    public virtual ICollection<ApliExpDocumento> ApliExpDocumentos { get; set; } = new List<ApliExpDocumento>();

    public virtual ICollection<ApliJuzgadoExpediente> ApliJuzgadoExpedientes { get; set; } = new List<ApliJuzgadoExpediente>();

    public virtual ICollection<ApliMedidaCautelarExpediente> ApliMedidaCautelarExpedientes { get; set; } = new List<ApliMedidaCautelarExpediente>();

    public virtual ICollection<ApliPagaresExpediente> ApliPagaresExpedientes { get; set; } = new List<ApliPagaresExpediente>();

    public virtual BoffApoderado? Apoderado { get; set; }

    public virtual ICollection<AsicExpedienteCargaErrore> AsicExpedienteCargaErrores { get; set; } = new List<AsicExpedienteCargaErrore>();

    public virtual ICollection<BendDeudorDeceval> BendDeudorDecevals { get; set; } = new List<BendDeudorDeceval>();

    public virtual AsicMasivaCabecera? Cabecera { get; set; }

    public virtual BoffCliente? Cliente { get; set; }

    public virtual BoffCuenta? Cuenta { get; set; }

    public virtual ApliDemandado? Demandado { get; set; }

    public virtual ApliDemandante? Demandante { get; set; }

    public virtual ApliEstadoProcesal? EstadoProcesal { get; set; }

    public virtual BoffRepresentante? Representante { get; set; }

    public virtual AsicSede? Sede { get; set; }

    public virtual ApliSubetapa? SubEtapa { get; set; }

    public virtual ApliTipoProceso? TipoProceso { get; set; }

    public virtual ApliTipoCuantia? Tipocuantia { get; set; }
    [NotMapped]
    public int TotalRegistros { get; set; }
}
