using System;
using System.Collections.Generic;

namespace Domain;

public partial class GibdProcesosTabla
{
    public int IdProceso { get; set; }

    public string? NombreProceso { get; set; }

    public string? PrefijoProceso { get; set; }

    public int? EstadoProceso { get; set; }

    public virtual ICollection<GibdTabla> GibdTablas { get; set; } = new List<GibdTabla>();
}
