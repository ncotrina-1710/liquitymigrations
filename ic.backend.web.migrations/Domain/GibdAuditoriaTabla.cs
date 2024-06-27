using System;
using System.Collections.Generic;

namespace Domain;

public partial class GibdAuditoriaTabla
{
    public int IdAuditoriaTabla { get; set; }

    public int TablaId { get; set; }

    public DateTime FecAuditoriaTabla { get; set; }

    public string DescripcionAuditoriaTabla { get; set; } = null!;

    public virtual GibdTabla Tabla { get; set; } = null!;
}
