using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffHistContrasena
{
    public int IdHistContrasena { get; set; }

    public int UsuarioId { get; set; }

    public string UsuarioContrasena { get; set; } = null!;

    public int ValidacionId { get; set; }

    public DateTime FecIniContrasena { get; set; }

    public DateTime FecFinContrasena { get; set; }

    public virtual BoffUsuario Usuario { get; set; } = null!;

    public virtual BendValidacione Validacion { get; set; } = null!;
}
