using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliSubetapa
{
    public int IdSubEtapa { get; set; }

    public int NroOrdenSubtapa { get; set; }

    public int TipoEtapaId { get; set; }

    public int? EventoId { get; set; }

    public string NombreSubEtapa { get; set; } = null!;

    public int EstadoSubEtapa { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionSubEtapa { get; set; }

    public DateTime? FecActualizacionSubEtapa { get; set; }

    public virtual ICollection<ApliActuacionesExpediente> ApliActuacionesExpedientes { get; set; } = new List<ApliActuacionesExpediente>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ApliTipoEtapa TipoEtapa { get; set; } = null!;
}
