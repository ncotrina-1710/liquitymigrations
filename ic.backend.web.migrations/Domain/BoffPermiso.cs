using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffPermiso
{
    public int IdPermiso { get; set; }

    public string DescripcionPermiso { get; set; } = null!;

    public int EstadoPermiso { get; set; }

    public DateTime FecCreacionPermiso { get; set; }

    public DateTime? FecActualizacionPermiso { get; set; }

    public virtual ICollection<BoffPerfilesPermiso> BoffPerfilesPermisos { get; set; } = new List<BoffPerfilesPermiso>();
}
