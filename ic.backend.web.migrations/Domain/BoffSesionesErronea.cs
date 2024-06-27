using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffSesionesErronea
{
    public int UsuarioId { get; set; }

    public DateTime FecSesionErronea { get; set; }

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
