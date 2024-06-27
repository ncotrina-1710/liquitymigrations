using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendPreguntaSesione
{
    public int IdPregunta { get; set; }

    public string? DescripcionPregunta { get; set; }

    public virtual ICollection<BendRespuestaSesione> BendRespuestaSesiones { get; set; } = new List<BendRespuestaSesione>();
}
