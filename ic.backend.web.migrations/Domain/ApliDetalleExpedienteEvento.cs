using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public partial class ApliDetalleExpedienteEvento
{
    public int IdDetalleExpedienteEvento { get; set; }

    public int ExpedienteId { get; set; }

    public int EventoId { get; set; }

    public string? DescripcionDetalleExpedienteEvento { get; set; }

    public string? ArchivoAdjunto { get; set; }

    public DateTime FecCreacionExpedienteEvento { get; set; }

    public DateTime? FecActualizacionExpedienteEvento { get; set; }

    public DateTime? FecAsignadaInicio { get; set; }

    public DateTime? FecAsignadaFin { get; set; }

    public TimeSpan? HoraAsignadaInicio { get; set; }

    public TimeSpan? HoraAsignadaFin { get; set; }

    public int? UsuarioId { get; set; }

    public bool ControlWeb { get; set; }

    public int EstadoExpedienteEvento { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? Observacion { get; set; }

    public virtual ApliEvento Evento { get; set; } = null!;

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual BoffUsuario? Usuario { get; set; }
    [NotMapped]
    public int TotalTareasHome { get; set; }
    [NotMapped]
    public int TotalAlertasHome { get; set; }
}
