using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoProceso
{
    public int IdTipoProceso { get; set; }

    public string? NombreProceso { get; set; }

    public DateTime FecCreacionProceso { get; set; }

    public DateTime? FecActualizacionProceso { get; set; }

    public int? Usuarioid { get; set; }

    public virtual ICollection<ApliTipoEtapa> ApliTipoEtapas { get; set; } = new List<ApliTipoEtapa>();

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();
}
