using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffUsuarioCuenta
{
    public int IdUsuarioCuenta { get; set; }

    public int CuentaId { get; set; }

    public int UsuarioId { get; set; }

    public int EstadoUsuarioCuenta { get; set; }

    public int IdUsuarioCreador { get; set; }

    public virtual BoffCuenta Cuenta { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
