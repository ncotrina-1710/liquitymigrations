using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffPerfilRole
{
    public int IdPerfilRol { get; set; }

    public int UsuarioId { get; set; }

    public int? PerfilId { get; set; }

    public int RolId { get; set; }

    public string? Actor { get; set; }

    public string? DescripcionPerfilRol { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int EstadoPerfilRol { get; set; }

    public DateTime FecCreacionPerfilRol { get; set; }

    public virtual BoffPerfile? Perfil { get; set; }

    public virtual BoffRole Rol { get; set; } = null!;

    public virtual BoffUsuario Usuario { get; set; } = null!;
}
