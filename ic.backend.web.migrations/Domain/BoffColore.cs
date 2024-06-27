using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffColore
{
    public int IdColor { get; set; }

    public int ClienteId { get; set; }

    public string Primario { get; set; } = null!;

    public string Secundario { get; set; } = null!;

    public DateTime FecCreacionColor { get; set; }

    public DateTime? FecActualizacionColor { get; set; }

    public int IdUsuario { get; set; }

    public virtual ICollection<BoffAsociacionColorCliente> BoffAsociacionColorClientes { get; set; } = new List<BoffAsociacionColorCliente>();

    public virtual BoffCliente Cliente { get; set; } = null!;
}
