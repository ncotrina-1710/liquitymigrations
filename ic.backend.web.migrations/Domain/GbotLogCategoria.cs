using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotLogCategoria
{
    public int IdLogCategoria { get; set; }

    public string? NombreLogCategoria { get; set; }

    public virtual ICollection<GbotHistLogBot> GbotHistLogBots { get; set; } = new List<GbotHistLogBot>();
}
