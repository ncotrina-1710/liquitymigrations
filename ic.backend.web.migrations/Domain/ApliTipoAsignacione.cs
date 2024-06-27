using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoAsignacione
{
    public int IdTipoAsignacion { get; set; }

    public string? DescripcionTipoAsignacion { get; set; }

    public virtual ICollection<ApliAsignacione> ApliAsignaciones { get; set; } = new List<ApliAsignacione>();
}
