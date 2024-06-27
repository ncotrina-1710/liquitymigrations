using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendRespuestaSesione
{
    public int IdRespuesta { get; set; }

    public string? DescripcionRespuesta { get; set; }

    public int PreguntaId { get; set; }

    public virtual ICollection<BoffUsuario> BoffUsuarios { get; set; } = new List<BoffUsuario>();

    public virtual BendPreguntaSesione Pregunta { get; set; } = null!;
}
