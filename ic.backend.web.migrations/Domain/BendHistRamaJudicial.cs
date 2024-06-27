using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendHistRamaJudicial
{
    public int IdHistRamaJudicial { get; set; }

    public int? DeudorRamaJudicialId { get; set; }

    public int? ExpedienteId { get; set; }

    public int? JuzgadoId { get; set; }

    public int? SedeId { get; set; }

    public string? ActuacionAnotacion { get; set; }

    public string? Anotacion { get; set; }

    public DateTime? FecActuacion { get; set; }

    public string? TipActuacionesTybaProceso { get; set; }

    public DateTime? FecActuacionTybaProceso { get; set; }

    public string? SolicitaDetalleEstado { get; set; }

    public string? DemandanteRamaJudicial { get; set; }

    public string? LlaveRamaJudicial { get; set; }

    public DateTime? FecInicioTermino { get; set; }

    public DateTime? FecFintTermino { get; set; }

    public DateTime? FecRegistro { get; set; }

    public string? CoincidenciaRamaJudicial { get; set; }

    public string? DepartamentoRamaJudicial { get; set; }

    public string? EstadoRamaJudicial { get; set; }

    public string? DespachoRamaJudicial { get; set; }

    public string? ClaseProcesoRamaJudicial { get; set; }

    public DateTime FecCreacionRamaJudicial { get; set; }

    public DateTime? FecActualizacionRamaJudicial { get; set; }

    public int UsuarioCreacionRamaJudicial { get; set; }

    public DateTime? FecActualizacionAntRamaJudicial { get; set; }

    public string? ErrorBusqueda { get; set; }

    public string? DetalleError { get; set; }

    public DateTime? FecBusqueda { get; set; }

    public DateTime? FecCreacion { get; set; }

    public string? Concateacion { get; set; }

    public string? ConcateacionTyba { get; set; }

    public DateTime? FecRegistroTybaProceso { get; set; }

    public string? RutaDctoPdf { get; set; }

    public string? RutaDctoPdfEstado { get; set; }

    public DateTime? FechaCarga { get; set; }

    public DateTime? FechaActualizacionMicrositio { get; set; }

    public string? ObservacionMicrositio { get; set; }

    public string? RutaDctoPdfEstadoP4 { get; set; }

    public string? RutaDctoPdfProvidP4 { get; set; }

    public string? ObservacionMicrositioP4 { get; set; }

    public DateTime? FechaMicrositio { get; set; }

    public DateTime? FechaActualizacionMicrositioP4 { get; set; }

    public virtual BendDeudorRamaJudicial? DeudorRamaJudicial { get; set; }

    public virtual ApliJuzgado? Juzgado { get; set; }

    public virtual AsicSede? Sede { get; set; }
}
