using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendCatActividadesW
{
    public int Id { get; set; }

    public string Actividad { get; set; } = null!;

    public string IdActividad { get; set; } = null!;

    public string IdProceso { get; set; } = null!;

    public string Proceso { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Page { get; set; }

    public string? Etapa { get; set; }

    public int? TiempoPromedio { get; set; }
}
