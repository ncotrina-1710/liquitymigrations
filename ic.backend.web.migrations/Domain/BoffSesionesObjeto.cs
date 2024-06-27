using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffSesionesObjeto
{
    public int IdSesionObjeto { get; set; }

    public int SesionId { get; set; }

    public int ObjetoId { get; set; }

    public DateTime FecSesionObjeto { get; set; }

    public virtual BendObjeto Objeto { get; set; } = null!;
}
