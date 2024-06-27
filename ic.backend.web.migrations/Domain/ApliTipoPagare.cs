using System;
using System.Collections.Generic;

namespace Domain;

public partial class ApliTipoPagare
{
    public int IdTipoPagare { get; set; }

    public string? DescripcionTipoPagare { get; set; }

    public virtual ICollection<ApliPagare> ApliPagares { get; set; } = new List<ApliPagare>();
}
