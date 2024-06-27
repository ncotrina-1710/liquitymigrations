using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliActuacionesExpediente
{
    public int IdActuacionExpediente { get; set; }

    public int ExpedienteId { get; set; }

    public int? SubEtapaId { get; set; }

    public string? NombreActuacionExpediente { get; set; }

    public string? UrlDocAdjunto { get; set; }

    public int Estado { get; set; }

    public DateTime? FecGestionActuacion { get; set; }

    public DateTime? FecEstadoActuacion { get; set; }

    public DateTime? FecActuacion { get; set; }

    public DateTime FecCreacion { get; set; }

    public int UsuarioId { get; set; }

    public virtual AsicExpediente Expediente { get; set; } = null!;

    public virtual ApliSubetapa? SubEtapa { get; set; }
}
