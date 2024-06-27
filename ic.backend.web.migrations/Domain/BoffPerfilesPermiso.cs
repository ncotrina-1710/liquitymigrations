using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffPerfilesPermiso
{
    public int IdPerfilPermiso { get; set; }

    public int PerfilId { get; set; }

    public int ObjetoId { get; set; }

    public int PermisoId { get; set; }

    public string UrlPerfilPermiso { get; set; } = null!;

    public string FuncionPerfilPermiso { get; set; } = null!;

    public int EstadoPerfilPermiso { get; set; }

    public DateTime FecCreacionPerfilPermiso { get; set; }

    public DateTime? FecActualizacionPerfilPermiso { get; set; }

    public virtual BendObjeto Objeto { get; set; } = null!;

    public virtual BoffPerfile Perfil { get; set; } = null!;

    public virtual BoffPermiso Permiso { get; set; } = null!;
}
