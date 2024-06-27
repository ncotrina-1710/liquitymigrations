using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendUsuario
{
    public int UsuarioId { get; set; }

    public DateTime FecAltaUsuario { get; set; }

    public string Contrasena { get; set; } = null!;

    public int? Estado { get; set; }

    public DateTime? FecBajaUsuario { get; set; }

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
