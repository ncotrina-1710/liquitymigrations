using System;
using System.Collections.Generic;

namespace Domain;

public partial class GibdTabla
{
    public int IdTabla { get; set; }

    public int TipoAmbienteId { get; set; }

    public int ProcesoId { get; set; }

    public string? NombreTabla { get; set; }

    public DateTime? FecCreacionTabla { get; set; }

    public DateTime? FecActualizacionTabla { get; set; }

    public virtual ICollection<GibdAuditoriaTabla> GibdAuditoriaTablas { get; set; } = new List<GibdAuditoriaTabla>();

    public virtual GibdProcesosTabla Proceso { get; set; } = null!;

    public virtual GibdTipoAmbiente TipoAmbiente { get; set; } = null!;
}
