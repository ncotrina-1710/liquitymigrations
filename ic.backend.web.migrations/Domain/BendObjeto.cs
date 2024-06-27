using System;
using System.Collections.Generic;

namespace Domain;

public partial class BendObjeto
{
    public int IdObjeto { get; set; }

    public int TipoObjetoId { get; set; }

    public int? PadreObjetoId { get; set; }

    public string NombreObjeto { get; set; } = null!;

    public string RutaObjeto { get; set; } = null!;

    public int EstadoObjeto { get; set; }

    public int TipoAmbienteId { get; set; }

    public virtual ICollection<BoffPerfilesPermiso> BoffPerfilesPermisos { get; set; } = new List<BoffPerfilesPermiso>();

    public virtual ICollection<BoffSesionesObjeto> BoffSesionesObjetos { get; set; } = new List<BoffSesionesObjeto>();

    public virtual ICollection<GbotHistGestionBot> GbotHistGestionBots { get; set; } = new List<GbotHistGestionBot>();

    public virtual GibdTipoAmbiente TipoAmbiente { get; set; } = null!;

    public virtual BendTipoObjeto TipoObjeto { get; set; } = null!;
}
