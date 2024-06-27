using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliEstadoProcesal
{
    public int IdEstadoProcesal { get; set; }

    public int NroOrdenEstado { get; set; }

    public int TipoEtapaId { get; set; }

    public string NombreEstadoProcesal { get; set; } = null!;

    public int EstadoEstadoProcesal { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionEstadoProcesal { get; set; }

    public DateTime? FecActualizacionEstadoProcesal { get; set; }

    public virtual ICollection<ApliEstatusProceso> ApliEstatusProcesos { get; set; } = new List<ApliEstatusProceso>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ApliTipoEtapa TipoEtapa { get; set; } = null!;
}
