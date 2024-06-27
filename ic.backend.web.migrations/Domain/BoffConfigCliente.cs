using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffConfigCliente
{
    public int IdConfigCliente { get; set; }

    public int ClienteId { get; set; }

    public string PrefijoConfigCliente { get; set; } = null!;

    public string CorrelativoConfigCliente { get; set; } = null!;

    public int EstadoConfigcliente { get; set; }

    public DateTime FecCreacionConfigCliente { get; set; }

    public virtual BoffCliente Cliente { get; set; } = null!;
}
