using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotBot
{
    public int IdBot { get; set; }

    public int TipoAmbienteId { get; set; }

    public int ProcesoBotId { get; set; }

    public string? CodigoBot { get; set; }

    public string? NombreBot { get; set; }

    public virtual ICollection<GbotHistGestionBot> GbotHistGestionBots { get; set; } = new List<GbotHistGestionBot>();

    public virtual ICollection<GbotHistLogBot> GbotHistLogBots { get; set; } = new List<GbotHistLogBot>();

    public virtual GbotProcesosBot ProcesoBot { get; set; } = null!;

    public virtual GibdTipoAmbiente TipoAmbiente { get; set; } = null!;
}
