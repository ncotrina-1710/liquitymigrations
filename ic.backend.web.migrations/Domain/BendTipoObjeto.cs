using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendTipoObjeto
{
    public int IdTipoObjeto { get; set; }

    public string DescriptcionTipoObjeto { get; set; } = null!;

    public int EstadoTipoObjeto { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<BendObjeto> BendObjetos { get; set; } = new List<BendObjeto>();
}
