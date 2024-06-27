using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendTbletapa
{
    public int IdEtapa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public bool Activo { get; set; }

    public int? TiempoPromedio { get; set; }

    public string? TipoFlujo { get; set; }
}
