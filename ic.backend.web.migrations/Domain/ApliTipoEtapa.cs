using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoEtapa
{
    public int IdTipoEtapa { get; set; }

    public int TipoProcesoId { get; set; }

    public int NroOrdenEtapa { get; set; }

    public string NombreTipoEtapa { get; set; } = null!;

    public int EstadoTipoEtapa { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime FecCreacionTipoEtapa { get; set; }

    public DateTime? FecActualizacionTipoEtapa { get; set; }

    public virtual ICollection<ApliEstadoProcesal> ApliEstadoProcesals { get; set; } = new List<ApliEstadoProcesal>();

    public virtual ICollection<ApliSubetapa> ApliSubetapas { get; set; } = new List<ApliSubetapa>();

    public virtual ApliTipoProceso TipoProceso { get; set; } = null!;
}
