using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffPerfile
{
    public int IdPerfil { get; set; }

    public string DescripcionPerfil { get; set; } = null!;

    public int EstadoPerfil { get; set; }

    public DateTime FecCreacionPerfil { get; set; }

    public DateTime? FecActualizacionPerfil { get; set; }

    public virtual ICollection<BoffPerfilRole> BoffPerfilRoles { get; set; } = new List<BoffPerfilRole>();

    public virtual ICollection<BoffPerfilesPermiso> BoffPerfilesPermisos { get; set; } = new List<BoffPerfilesPermiso>();
}
