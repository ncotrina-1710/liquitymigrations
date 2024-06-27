using System;
using System.Collections.Generic;

namespace Domain;

public partial class GbotLogInteraccione
{
    public int IdLogInteraccion { get; set; }

    public string? NombreLogInteraccion { get; set; }

    public virtual ICollection<GbotHistLogBot> GbotHistLogBots { get; set; } = new List<GbotHistLogBot>();
}
