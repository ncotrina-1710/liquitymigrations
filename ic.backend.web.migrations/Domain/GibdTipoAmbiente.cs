using System;
using System.Collections.Generic;

namespace Domain;

public partial class GibdTipoAmbiente
{
    public int IdTipoAmbiente { get; set; }

    public string? NombreAmbiente { get; set; }

    public virtual ICollection<BendObjeto> BendObjetos { get; set; } = new List<BendObjeto>();

    public virtual ICollection<GbotBot> GbotBots { get; set; } = new List<GbotBot>();

    public virtual ICollection<GibdTabla> GibdTablas { get; set; } = new List<GibdTabla>();
}
