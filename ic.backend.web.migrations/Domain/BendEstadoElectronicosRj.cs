using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendEstadoElectronicosRj
{
    public int IdEstadoElectronico { get; set; }

    public int? JuzgadoId { get; set; }

    public int AnioEstadoElectronico { get; set; }

    public string EnlaceEstadoElectronico { get; set; } = null!;

    public string XpathPestEstadoElectronico { get; set; } = null!;

    public string XpathTabEstadoElectronico { get; set; } = null!;

    public DateTime FecCreacionEstadoElectronico { get; set; }

    public DateTime? FecActualizacionEstadoElectronico { get; set; }

    public int IdUsuario { get; set; }

    public virtual ApliJuzgado? Juzgado { get; set; }
}
