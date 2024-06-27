using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotProcesosBot
{
    public int IdProcesoBot { get; set; }

    public string? NombreProcesoBot { get; set; }

    public virtual ICollection<GbotBot> GbotBots { get; set; } = new List<GbotBot>();
}
