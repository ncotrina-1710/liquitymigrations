using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendValidacione
{
    public int IdValidacion { get; set; }

    public string? TipoValidacion { get; set; }

    public virtual ICollection<BendHistValidacione> BendHistValidaciones { get; set; } = new List<BendHistValidacione>();

    public virtual ICollection<BoffHistContrasena> BoffHistContrasenas { get; set; } = new List<BoffHistContrasena>();
}
