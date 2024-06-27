using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotLogEvento
{
    public int IdLogEvento { get; set; }

    public string? NombreLogEvento { get; set; }

    public virtual ICollection<GbotHistLogBot> GbotHistLogBots { get; set; } = new List<GbotHistLogBot>();
}
