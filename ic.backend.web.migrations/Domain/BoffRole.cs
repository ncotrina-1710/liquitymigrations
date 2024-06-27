using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffRole
{
    public int IdRol { get; set; }

    public string DescripcionRol { get; set; } = null!;

    public int EstadoRol { get; set; }

    public DateTime FecCreacionRol { get; set; }

    public DateTime? FecActualizacionRol { get; set; }

    public virtual ICollection<BoffPerfilRole> BoffPerfilRoles { get; set; } = new List<BoffPerfilRole>();

    public virtual ICollection<BoffUsuario> BoffUsuarios { get; set; } = new List<BoffUsuario>();
}
