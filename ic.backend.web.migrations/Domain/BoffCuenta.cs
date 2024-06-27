using System;
using System.Collections.Generic;

namespace Domain;

public partial class BoffCuenta
{
    public int IdCuenta { get; set; }

    public string? CodIdentificacionCuenta { get; set; }

    public string NombreCuenta { get; set; } = null!;

    public int ClienteId { get; set; }

    public int EstadoCuenta { get; set; }

    public DateTime FecCreacionCuenta { get; set; }

    public virtual ICollection<AsicExpediente> AsicExpedientes { get; set; } = new List<AsicExpediente>();

    public virtual ICollection<BendDeceval> BendDecevals { get; set; } = new List<BendDeceval>();

    public virtual ICollection<BoffCuentasAgente> BoffCuentasAgentes { get; set; } = new List<BoffCuentasAgente>();

    public virtual ICollection<BoffUsuarioCuenta> BoffUsuarioCuenta { get; set; } = new List<BoffUsuarioCuenta>();

    public virtual BoffCliente Cliente { get; set; } = null!;
}
